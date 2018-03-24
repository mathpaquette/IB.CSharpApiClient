using System;
using System.Text;
using System.Threading.Tasks;
using IB.CSharpApiClient.Example.Domain.ValueObject;
using IBApi;

namespace IB.CSharpApiClient.Example.Domain
{
    public class DomainClassExample
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly IRealTimeDataProviderExample _realTimeDataProviderExample;

        public DomainClassExample(IRealTimeDataProviderExample realTimeDataProviderExample)
        {
            _realTimeDataProviderExample = realTimeDataProviderExample;
        }

        private void RealTimeDataProviderExampleOnMarketData(object sender, Level1MarketDataEventArgs level1MarketDataEventArgs)
        {
            Logger.Info(level1MarketDataEventArgs);
        }

        public async void RequestDataExample(string host, int port, int clientId)
        {
            // Wait until connected
            await ConnectAsync(host, port, clientId);

            // Subscribe to RealTimeDataProvider MarketData event and request Level 1 market data
            SubscribeLevel1MarketData("AAPL");

            // Request scanners 
            RequestScanner();

            // Delaying...
            await Delaying();

            // Unsubscribe to MarketData
            UnsubscribeLevel1MarketData("AAPL");
        }

        private async Task ConnectAsync(string host, int port, int clientId)
        {
            Logger.Info("Trying to connect to IB...");
            await _realTimeDataProviderExample.ConnectAsync(host, port, clientId);
            Logger.Info("Connected!");
        }

        private void SubscribeLevel1MarketData(string symbol)
        {
            Logger.Info($"Requesting level 1 market data for: {symbol}");
            _realTimeDataProviderExample.MarketData += RealTimeDataProviderExampleOnMarketData;
            _realTimeDataProviderExample.SubscribeMarketData(symbol);
        }

        private Task Delaying()
        {
            Logger.Info("Delaying 15 seconds before cancelling level 1 market data...");
            return Task.Delay((int)TimeSpan.FromSeconds(15).TotalMilliseconds);
        }

        private void UnsubscribeLevel1MarketData(string symbol)
        {
            Logger.Info($"Cancelling level 1 market data for: {symbol}");
            _realTimeDataProviderExample.UnsubscribeMarketData(symbol);
            _realTimeDataProviderExample.MarketData -= RealTimeDataProviderExampleOnMarketData;
        }

        private async void RequestScanner()
        {
            var delayTimeSec = 30;

            var scannerSubscription = new ScannerSubscription
            {
                ScanCode = ScanCode.TOP_PERC_GAIN,
                Instrument = "STK",
                LocationCode = "STK.US",
                NumberOfRows = 25
            };

            while (true)
            {
                try
                {
                    Logger.Info("Requesting scanner...");
                    var scanners = await _realTimeDataProviderExample.GetScannerAsync(scannerSubscription);

                    StringBuilder sb = new StringBuilder();
                    for (var i = 0; i < scanners.Length; i++)
                    {
                        var scanner = scanners[i];
                        if (i != 0) sb.Append(", ");
                        sb.Append($"[{scanner.Rank}]: {scanner.ContractDetails.Summary.Symbol}");
                    }

                    Logger.Info($"Scanner results: {sb}");
                }
                catch (Exception e)
                {
                    Logger.Error(e);
                }

                Logger.Info($"Waiting {delayTimeSec} seconds before the next scanner request...");
                await Task.Delay((int)TimeSpan.FromSeconds(delayTimeSec).TotalMilliseconds);
            }
        }
    }
}
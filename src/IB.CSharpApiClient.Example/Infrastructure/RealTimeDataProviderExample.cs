using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using IB.CSharpApiClient.Events;
using IB.CSharpApiClient.Example.Domain;
using IB.CSharpApiClient.Example.Domain.ValueObject;
using IB.CSharpApiClient.Extensions;
using IBApi;

namespace IB.CSharpApiClient.Example.Infrastructure
{
    public class RealTimeDataProviderExample : ApiClient, IRealTimeDataProviderExample
    {
        public event EventHandler<Level1MarketData> MarketData;
        private readonly Dictionary<string, int> _requestIdsBySymbol;
        private readonly Dictionary<int, Level1MarketData> _lastsByRequestId;

        public RealTimeDataProviderExample()
        {
            _requestIdsBySymbol = new Dictionary<string, int>();
            _lastsByRequestId = new Dictionary<int, Level1MarketData>();
            EventDispatcher.TickPrice += EventDispatcherOnTickPrice;
            EventDispatcher.TickSize += EventDispatcherOnTickSize;
        }

        public Task<Scanner[]> GetScannerAsync(ScannerSubscription scannerSubscription, List<TagValue> scannerSubscriptionOptions = null)
        {
            var ct = new CancellationTokenSource(DefaultTimeoutMs);
            var res = new TaskCompletionSource<Scanner[]>();
            ct.Token.Register(() => res.TrySetCanceled(), false);

            var reqId = new Random(DateTime.Now.Millisecond).Next();
            scannerSubscriptionOptions = scannerSubscriptionOptions ?? new List<TagValue>();
            var scanners = new List<Scanner>();

            EventHandler<ScannerEventArgs> scanner = (sender, args) =>
            {
                if (args.RequestId != reqId) return;
                scanners.Add(new Scanner(args.Rank, args.ContractDetails, args.Distance, args.Benchmark, args.Projection, args.LegsStr));
            };

            EventHandler<ScannerEndEventArgs> scannerEnd = (sender, args) =>
            {
                if (args.RequestId != reqId) return;
                res.SetResult(scanners.ToArray());
            };
            EventDispatcher.Scanner += scanner;
            EventDispatcher.ScannerEnd += scannerEnd;
            
            ClientSocket.reqScannerSubscription(reqId, scannerSubscription, scannerSubscriptionOptions);

            res.Task.ContinueWith(x =>
            {
                ClientSocket.cancelScannerSubscription(reqId);
                EventDispatcher.Scanner -= scanner;
                EventDispatcher.ScannerEnd -= scannerEnd;

            }, TaskContinuationOptions.None);

            return res.Task;
        }

        public void SubscribeMarketData(string symbol)
        {
            lock (_requestIdsBySymbol)
            {
                if (_requestIdsBySymbol.ContainsKey(symbol)) return;
                var contract = new Contract
                {
                    Symbol = symbol.ToUpper(),
                    SecType = "STK",
                    Currency = "USD",
                    Exchange = "SMART"
                };
                var requestId = new Random().Next();
                ClientSocket.reqMktData(requestId, contract, string.Empty, false, false, null);
                _requestIdsBySymbol.Add(symbol, requestId);
            }
        }

        public void UnsubscribeMarketData(string symbol)
        {
            lock (_requestIdsBySymbol)
            {
                if (_requestIdsBySymbol.TryGetValue(symbol, out var requestId))
                {
                    ClientSocket.cancelMktData(requestId);
                    _requestIdsBySymbol.Remove(symbol);
                    _lastsByRequestId.Remove(requestId);
                }
            }
        }

        private void EventDispatcherOnTickPrice(object o, TickPriceEventArgs tickPriceEventArgs)
        {
            if (!_lastsByRequestId.TryGetValue(tickPriceEventArgs.RequestId, out var last))
            {
                last = new Level1MarketData();
                _lastsByRequestId.Add(tickPriceEventArgs.RequestId, last);
            }

            last.UpdateValues(tickPriceEventArgs.Field, tickPriceEventArgs.Price);
            MarketData.RaiseEvent(this, last.ShallowCopy());
        }

        private void EventDispatcherOnTickSize(object o, TickSizeEventArgs tickSizeEventArgs)
        {
            if (!_lastsByRequestId.TryGetValue(tickSizeEventArgs.RequestId, out var last))
            {
                last = new Level1MarketData();
                _lastsByRequestId.Add(tickSizeEventArgs.RequestId, last);
            }

            last.UpdateValues(tickSizeEventArgs.Field, tickSizeEventArgs.Size);
            MarketData.RaiseEvent(this, last.ShallowCopy());
        }
    }
}
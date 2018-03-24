using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IB.CSharpApiClient.Example.Domain.ValueObject;
using IBApi;

namespace IB.CSharpApiClient.Example.Domain
{
    public interface IRealTimeDataProviderExample : IApiClient
    {
        event EventHandler<Level1MarketDataEventArgs> MarketData;
        Task<Scanner[]> GetScannerAsync(ScannerSubscription scannerSubscription, List<TagValue> scannerSubscriptionOptions = null);
        void SubscribeMarketData(string symbol);
        void UnsubscribeMarketData(string symbol);
    }
}
using System.Collections.Generic;
using IBApi;

namespace IB.CSharpApiClient
{
    public interface IEClientSocket
    {
        int ServerVersion { get; }
        EWrapper Wrapper { get; }
        bool AllowRedirect { get; set; }
        string ServerTime { get; }
        string optionalCapabilities { get; set; }
        bool AsyncEConnect { get; set; }
        void calculateImpliedVolatility(int reqId, Contract contract, double optionPrice, double underPrice, List<TagValue> impliedVolatilityOptions);
        void calculateOptionPrice(int reqId, Contract contract, double volatility, double underPrice, List<TagValue> optionPriceOptions);
        void cancelAccountSummary(int reqId);
        void cancelAccountUpdatesMulti(int requestId);
        void cancelCalculateImpliedVolatility(int reqId);
        void cancelCalculateOptionPrice(int reqId);
        void cancelFundamentalData(int reqId);
        void cancelHeadTimestamp(int tickerId);
        void cancelHistogramData(int tickerId);
        void cancelHistoricalData(int reqId);
        void cancelMktData(int tickerId);
        void cancelMktDepth(int tickerId, bool isSmartDepth);
        void cancelNewsBulletin();
        void cancelOrder(int orderId, string manualOrderCancelTime);
        void cancelPnL(int reqId);
        void cancelPnLSingle(int reqId);
        void cancelPositions();
        void cancelPositionsMulti(int requestId);
        void cancelRealTimeBars(int tickerId);
        void cancelScannerSubscription(int tickerId);
        void cancelTickByTickData(int requestId);
        void cancelWshEventData(int reqId);
        void cancelWshMetaData(int reqId);
        void Close();
        void DisableUseV100Plus();
        void eConnect(string host, int port, int clientId);
        void eConnect(string host, int port, int clientId, bool extraAuth);
        void eDisconnect(bool resetState = true);
        void exerciseOptions(int tickerId, Contract contract, int exerciseAction, int exerciseQuantity, string account, int ovrd);
        bool IsConnected();
        bool IsDataAvailable();
        void placeOrder(int id, Contract contract, Order order);
        void queryDisplayGroups(int requestId);
        byte[] ReadAtLeastNBytes(int msgSize);
        byte[] ReadByteArray(int msgSize);
        int ReadInt();
        void redirect(string host);
        void replaceFA(int reqId, int faDataType, string xml);
        void reqAccountSummary(int reqId, string group, string tags);
        void reqAccountUpdates(bool subscribe, string acctCode);
        void reqAccountUpdatesMulti(int requestId, string account, string modelCode, bool ledgerAndNLV);
        void reqAllOpenOrders();
        void reqAutoOpenOrders(bool autoBind);
        void reqCompletedOrders(bool apiOnly);
        void reqContractDetails(int reqId, Contract contract);
        void reqCurrentTime();
        void reqExecutions(int reqId, ExecutionFilter filter);
        void reqFamilyCodes();
        void reqFundamentalData(int reqId, Contract contract, string reportType, List<TagValue> fundamentalDataOptions);
        void reqGlobalCancel();
        void reqHeadTimestamp(int tickerId, Contract contract, string whatToShow, int useRTH, int formatDate);
        void reqHistogramData(int tickerId, Contract contract, bool useRTH, string period);
        void reqHistoricalData(int tickerId, Contract contract, string endDateTime, string durationStr, string barSizeSetting, string whatToShow, int useRTH, int formatDate, bool keepUpToDate, List<TagValue> chartOptions);
        void reqHistoricalNews(int requestId, int conId, string providerCodes, string startDateTime, string endDateTime, int totalResults, List<TagValue> historicalNewsOptions);
        void reqHistoricalTicks(int reqId, Contract contract, string startDateTime, string endDateTime, int numberOfTicks, string whatToShow, int useRth, bool ignoreSize, List<TagValue> miscOptions);
        void reqIds(int numIds);
        void reqManagedAccts();
        void reqMarketDataType(int marketDataType);
        void reqMarketDepth(int tickerId, Contract contract, int numRows, bool isSmartDepth, List<TagValue> mktDepthOptions);
        void reqMarketRule(int marketRuleId);
        void reqMatchingSymbols(int reqId, string pattern);
        void reqMktData(int tickerId, Contract contract, string genericTickList, bool snapshot, bool regulatorySnaphsot, List<TagValue> mktDataOptions);
        void reqMktDepthExchanges();
        void reqNewsArticle(int requestId, string providerCode, string articleId, List<TagValue> newsArticleOptions);
        void reqNewsBulletins(bool allMessages);
        void reqNewsProviders();
        void reqOpenOrders();
        void reqPnL(int reqId, string account, string modelCode);
        void reqPnLSingle(int reqId, string account, string modelCode, int conId);
        void reqPositions();
        void reqPositionsMulti(int requestId, string account, string modelCode);
        void reqRealTimeBars(int tickerId, Contract contract, int barSize, string whatToShow, bool useRTH, List<TagValue> realTimeBarsOptions);
        void reqScannerParameters();
        void reqScannerSubscription(int reqId, ScannerSubscription subscription, List<TagValue> scannerSubscriptionOptions, List<TagValue> scannerSubscriptionFilterOptions);
        void reqScannerSubscription(int reqId, ScannerSubscription subscription, string scannerSubscriptionOptions, string scannerSubscriptionFilterOptions);
        void reqSecDefOptParams(int reqId, string underlyingSymbol, string futFopExchange, string underlyingSecType, int underlyingConId);
        void reqSmartComponents(int reqId, string bboExchange);
        void reqSoftDollarTiers(int reqId);
        void reqTickByTickData(int requestId, Contract contract, string tickType, int numberOfTicks, bool ignoreSize);
        void requestFA(int faDataType);
        void reqUserInfo(int reqId);
        void reqWshEventData(int reqId, WshEventData wshEventData);
        void reqWshMetaData(int reqId);
        void SetConnectOptions(string connectOptions);
        void setServerLogLevel(int logLevel);
        void startApi();
        void subscribeToGroupEvents(int requestId, int groupId);
        void unsubscribeFromGroupEvents(int requestId);
        void updateDisplayGroup(int requestId, string contractInfo);
        void verifyAndAuthMessage(string apiData, string xyzResponse);
        void verifyAndAuthRequest(string apiName, string apiVersion, string opaqueIsvKey);
        void verifyMessage(string apiData);
        void verifyRequest(string apiName, string apiVersion);
    }
}
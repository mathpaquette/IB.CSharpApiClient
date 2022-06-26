using System.Collections.Generic;
using IBApi;

namespace IB.CSharpApiClient
{
    public interface IClientSocket
    {
        int ServerVersion { get; }
        EWrapper Wrapper { get; }
        bool AllowRedirect { get; set; }
        string ServerTime { get; }
        string OptionalCapabilities { get; set; }
        bool AsyncEConnect { get; set; }
        void CalculateImpliedVolatility(int reqId, Contract contract, double optionPrice, double underPrice, List<TagValue> impliedVolatilityOptions);
        void CalculateOptionPrice(int reqId, Contract contract, double volatility, double underPrice, List<TagValue> optionPriceOptions);
        void CancelAccountSummary(int reqId);
        void CancelAccountUpdatesMulti(int requestId);
        void CancelCalculateImpliedVolatility(int reqId);
        void CancelCalculateOptionPrice(int reqId);
        void CancelFundamentalData(int reqId);
        void CancelHeadTimestamp(int tickerId);
        void CancelHistogramData(int tickerId);
        void CancelHistoricalData(int reqId);
        void CancelMktData(int tickerId);
        void CancelMktDepth(int tickerId, bool isSmartDepth);
        void CancelNewsBulletin();
        void CancelOrder(int orderId, string manualOrderCancelTime);
        void CancelPnL(int reqId);
        void CancelPnLSingle(int reqId);
        void CancelPositions();
        void CancelPositionsMulti(int requestId);
        void CancelRealTimeBars(int tickerId);
        void CancelScannerSubscription(int tickerId);
        void CancelTickByTickData(int requestId);
        void CancelWshEventData(int reqId);
        void CancelWshMetaData(int reqId);
        void Close();
        void DisableUseV100Plus();
        void EConnect(string host, int port, int clientId);
        void EConnect(string host, int port, int clientId, bool extraAuth);
        void EDisconnect(bool resetState = true);
        void ExerciseOptions(int tickerId, Contract contract, int exerciseAction, int exerciseQuantity, string account, int ovrd);
        bool IsConnected();
        bool IsDataAvailable();
        void PlaceOrder(int id, Contract contract, Order order);
        void QueryDisplayGroups(int requestId);
        byte[] ReadAtLeastNBytes(int msgSize);
        byte[] ReadByteArray(int msgSize);
        int ReadInt();
        void Redirect(string host);
        void ReplaceFA(int reqId, int faDataType, string xml);
        void ReqAccountSummary(int reqId, string group, string tags);
        void ReqAccountUpdates(bool subscribe, string acctCode);
        void ReqAccountUpdatesMulti(int requestId, string account, string modelCode, bool ledgerAndNLV);
        void ReqAllOpenOrders();
        void ReqAutoOpenOrders(bool autoBind);
        void ReqCompletedOrders(bool apiOnly);
        void ReqContractDetails(int reqId, Contract contract);
        void ReqCurrentTime();
        void ReqExecutions(int reqId, ExecutionFilter filter);
        void ReqFamilyCodes();
        void ReqFundamentalData(int reqId, Contract contract, string reportType, List<TagValue> fundamentalDataOptions);
        void ReqGlobalCancel();
        void ReqHeadTimestamp(int tickerId, Contract contract, string whatToShow, int useRTH, int formatDate);
        void ReqHistogramData(int tickerId, Contract contract, bool useRTH, string period);
        void ReqHistoricalData(int tickerId, Contract contract, string endDateTime, string durationStr, string barSizeSetting, string whatToShow, int useRTH, int formatDate, bool keepUpToDate, List<TagValue> chartOptions);
        void ReqHistoricalNews(int requestId, int conId, string providerCodes, string startDateTime, string endDateTime, int totalResults, List<TagValue> historicalNewsOptions);
        void ReqHistoricalTicks(int reqId, Contract contract, string startDateTime, string endDateTime, int numberOfTicks, string whatToShow, int useRth, bool ignoreSize, List<TagValue> miscOptions);
        void ReqIds(int numIds);
        void ReqManagedAccts();
        void ReqMarketDataType(int marketDataType);
        void ReqMarketDepth(int tickerId, Contract contract, int numRows, bool isSmartDepth, List<TagValue> mktDepthOptions);
        void ReqMarketRule(int marketRuleId);
        void ReqMatchingSymbols(int reqId, string pattern);
        void ReqMktData(int tickerId, Contract contract, string genericTickList, bool snapshot, bool regulatorySnaphsot, List<TagValue> mktDataOptions);
        void ReqMktDepthExchanges();
        void ReqNewsArticle(int requestId, string providerCode, string articleId, List<TagValue> newsArticleOptions);
        void ReqNewsBulletins(bool allMessages);
        void ReqNewsProviders();
        void ReqOpenOrders();
        void ReqPnL(int reqId, string account, string modelCode);
        void ReqPnLSingle(int reqId, string account, string modelCode, int conId);
        void ReqPositions();
        void ReqPositionsMulti(int requestId, string account, string modelCode);
        void ReqRealTimeBars(int tickerId, Contract contract, int barSize, string whatToShow, bool useRTH, List<TagValue> realTimeBarsOptions);
        void ReqScannerParameters();
        void ReqScannerSubscription(int reqId, ScannerSubscription subscription, List<TagValue> scannerSubscriptionOptions, List<TagValue> scannerSubscriptionFilterOptions);
        void ReqScannerSubscription(int reqId, ScannerSubscription subscription, string scannerSubscriptionOptions, string scannerSubscriptionFilterOptions);
        void ReqSecDefOptParams(int reqId, string underlyingSymbol, string futFopExchange, string underlyingSecType, int underlyingConId);
        void ReqSmartComponents(int reqId, string bboExchange);
        void ReqSoftDollarTiers(int reqId);
        void ReqTickByTickData(int requestId, Contract contract, string tickType, int numberOfTicks, bool ignoreSize);
        void RequestFA(int faDataType);
        void ReqUserInfo(int reqId);
        void ReqWshEventData(int reqId, WshEventData wshEventData);
        void ReqWshMetaData(int reqId);
        void SetConnectOptions(string connectOptions);
        void SetServerLogLevel(int logLevel);
        void StartApi();
        void SubscribeToGroupEvents(int requestId, int groupId);
        void UnsubscribeFromGroupEvents(int requestId);
        void UpdateDisplayGroup(int requestId, string contractInfo);
        void VerifyAndAuthMessage(string apiData, string xyzResponse);
        void VerifyAndAuthRequest(string apiName, string apiVersion, string opaqueIsvKey);
        void VerifyMessage(string apiData);
        void VerifyRequest(string apiName, string apiVersion);
    }
}
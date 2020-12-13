using System;
using System.Collections.Generic;
using IBApi;

namespace IB.CSharpApiClient
{
    public interface IClientCommand
    {
        void Connect(string host, int port, int clientId);
        void Connect(string host, int port, int clientId, bool extraAuth);
        void Redirect(string host);
        void Disconnect(bool resetState = true);
        void SetConnectOptions(string connectOptions);
        void DisableUseV100Plus();
        bool AllowRedirect { get; set; }
        int ServerVersion { get; }
        string ServerTime { get; }
        string OptionalCapabilities { get; set; }
        bool ConnectAsync { get; set; }
        bool IsConnected();
        void StartApi();
        void Close();
        void ReqCompletedOrders(bool apiOnly);
        void CancelTickByTickData(int requestId);
        void ReqTickByTickData(int requestId, Contract contract, string tickType, int numberOfTicks, bool ignoreSize);
        void CancelHistoricalData(int reqId);

        void CalculateImpliedVolatility(int reqId, Contract contract, double optionPrice, double underPrice,
            //reserved for future use, must be blank
            List<TagValue> impliedVolatilityOptions);

        void CalculateOptionPrice(int reqId, Contract contract, double volatility, double underPrice,
            //reserved for future use, must be blank
            List<TagValue> optionPriceOptions);

        void CancelAccountSummary(int reqId);
        void CancelCalculateImpliedVolatility(int reqId);
        void CancelCalculateOptionPrice(int reqId);
        void CancelFundamentalData(int reqId);
        void CancelMktData(int tickerId);
        void CancelMktDepth(int tickerId, bool isSmartDepth);
        void CancelNewsBulletin();
        void CancelOrder(int orderId);
        void CancelPositions();
        void CancelRealTimeBars(int tickerId);
        void CancelScannerSubscription(int tickerId);
        void ExerciseOptions(int tickerId, Contract contract, int exerciseAction, int exerciseQuantity, string account, int ovrd);
        void PlaceOrder(int id, Contract contract, Order order);
        void ReplaceFA(int reqId, int faDataType, string xml);
        void RequestFA(int faDataType);
        void ReqAccountSummary(int reqId, string group, string tags);
        void ReqAccountUpdates(bool subscribe, string acctCode);
        void ReqAllOpenOrders();
        void ReqAutoOpenOrders(bool autoBind);
        void ReqContractDetails(int reqId, Contract contract);
        void ReqCurrentTime();
        void ReqExecutions(int reqId, ExecutionFilter filter);

        void ReqFundamentalData(int reqId, Contract contract, string reportType,
            //reserved for future use, must be blank
            List<TagValue> fundamentalDataOptions);

        void ReqGlobalCancel();

        void ReqHistoricalData(int tickerId, Contract contract, string endDateTime,
            string durationString, string barSizeSetting, string whatToShow, int useRTH, int formatDate, bool keepUpToDate, List<TagValue> chartOptions);

        void ReqIds(int numIds);
        void ReqManagedAccts();
        void ReqMktData(int tickerId, Contract contract, string genericTickList, bool snapshot, bool regulatorySnaphsot, List<TagValue> mktDataOptions);
        void ReqMarketDataType(int marketDataType);
        void ReqMarketDepth(int tickerId, Contract contract, int numRows, bool isSmartDepth, List<TagValue> mktDepthOptions);
        void ReqNewsBulletins(bool allMessages);
        void ReqOpenOrders();
        void ReqPositions();
        void ReqRealTimeBars(int tickerId, Contract contract, int barSize, string whatToShow, bool useRTH, List<TagValue> realTimeBarsOptions);
        void ReqScannerParameters();
        void ReqScannerSubscription(int reqId, ScannerSubscription subscription, List<TagValue> scannerSubscriptionOptions, List<TagValue> scannerSubscriptionFilterOptions);
        void ReqScannerSubscription(int reqId, ScannerSubscription subscription, string scannerSubscriptionOptions, string scannerSubscriptionFilterOptions);
        void SetServerLogLevel(int logLevel);
        void VerifyRequest(string apiName, string apiVersion);
        void VerifyMessage(string apiData);
        void VerifyAndAuthRequest(string apiName, string apiVersion, string opaqueIsvKey);
        void VerifyAndAuthMessage(string apiData, string xyzResponse);
        void QueryDisplayGroups(int requestId);
        void SubscribeToGroupEvents(int requestId, int groupId);
        void UpdateDisplayGroup(int requestId, string contractInfo);
        void UnsubscribeFromGroupEvents(int requestId);
        void ReqPositionsMulti(int requestId, string account, string modelCode);
        void CancelPositionsMulti(int requestId);
        void ReqAccountUpdatesMulti(int requestId, string account, string modelCode, bool ledgerAndNLV);
        void CancelAccountUpdatesMulti(int requestId);
        void ReqSecDefOptParams(int reqId, string underlyingSymbol, string futFopExchange, string underlyingSecType, int underlyingConId);
        void ReqSoftDollarTiers(int reqId);
        void ReqFamilyCodes();
        void ReqMatchingSymbols(int reqId, string pattern);
        void ReqMktDepthExchanges();
        void ReqSmartComponents(int reqId, string bboExchange);
        void ReqNewsProviders();
        void ReqNewsArticle(int requestId, string providerCode, string articleId, List<TagValue> newsArticleOptions);
        void ReqHistoricalNews(int requestId, int conId, string providerCodes, string startDateTime, string endDateTime, int totalResults, List<TagValue> historicalNewsOptions);
        void ReqHeadTimestamp(int tickerId, Contract contract, string whatToShow, int useRTH, int formatDate);
        void CancelHeadTimestamp(int tickerId);
        void ReqHistogramData(int tickerId, Contract contract, bool useRTH, string period);
        void CancelHistogramData(int tickerId);
        void ReqMarketRule(int marketRuleId);
        void ReqPnL(int reqId, string account, string modelCode);
        void CancelPnL(int reqId);
        void ReqPnLSingle(int reqId, string account, string modelCode, int conId);
        void CancelPnLSingle(int reqId);

        void ReqHistoricalTicks(int reqId, Contract contract, string startDateTime,
            string endDateTime, int numberOfTicks, string whatToShow, int useRth, bool ignoreSize,
            List<TagValue> miscOptions);

        bool IsDataAvailable();
        int ReadInt();
        byte[] ReadAtLeastNBytes(int msgSize);
        byte[] ReadByteArray(int msgSize);
    }
}

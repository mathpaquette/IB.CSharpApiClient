using System.Collections.Generic;
using IBApi;

namespace IB.CSharpApiClient
{
    public partial class IBClient : IClientSocket
    {
        public int ServerVersion => _clientSocket.ServerVersion;
        public EWrapper Wrapper => _clientSocket.Wrapper;

        public bool AllowRedirect
        {
            get => _clientSocket.AllowRedirect;
            set => _clientSocket.AllowRedirect = value;
        }

        public string ServerTime => _clientSocket.ServerTime;

        public string OptionalCapabilities
        {
            get => _clientSocket.optionalCapabilities;
            set => _clientSocket.optionalCapabilities = value;
        }

        public bool AsyncEConnect
        {
            get => _clientSocket.AsyncEConnect;
            set => _clientSocket.AsyncEConnect = value;
        }

        public void CalculateImpliedVolatility(int reqId, Contract contract, double optionPrice, double underPrice, List<TagValue> impliedVolatilityOptions)
        {
            _clientSocket.calculateImpliedVolatility(reqId, contract, optionPrice, underPrice, impliedVolatilityOptions);
        }

        public void CalculateOptionPrice(int reqId, Contract contract, double volatility, double underPrice, List<TagValue> optionPriceOptions)
        {
            _clientSocket.calculateOptionPrice(reqId, contract, volatility, underPrice, optionPriceOptions);
        }

        public void CancelAccountSummary(int reqId)
        {
            _clientSocket.cancelAccountSummary(reqId);
        }

        public void CancelAccountUpdatesMulti(int requestId)
        {
            _clientSocket.cancelAccountUpdatesMulti(requestId);
        }

        public void CancelCalculateImpliedVolatility(int reqId)
        {
            _clientSocket.cancelCalculateImpliedVolatility(reqId);
        }

        public void CancelCalculateOptionPrice(int reqId)
        {
            _clientSocket.cancelCalculateOptionPrice(reqId);
        }

        public void CancelFundamentalData(int reqId)
        {
            _clientSocket.cancelFundamentalData(reqId);
        }

        public void CancelHeadTimestamp(int tickerId)
        {
            _clientSocket.cancelHeadTimestamp(tickerId);
        }

        public void CancelHistogramData(int tickerId)
        {
            _clientSocket.cancelHistogramData(tickerId);
        }

        public void CancelHistoricalData(int reqId)
        {
            _clientSocket.cancelHistoricalData(reqId);
        }

        public void CancelMktData(int tickerId)
        {
            _clientSocket.cancelMktData(tickerId);
        }

        public void CancelMktDepth(int tickerId, bool isSmartDepth)
        {
            _clientSocket.cancelMktDepth(tickerId, isSmartDepth);
        }

        public void CancelNewsBulletin()
        {
            _clientSocket.cancelNewsBulletin();
        }

        public void CancelOrder(int orderId, string manualOrderCancelTime)
        {
            _clientSocket.cancelOrder(orderId, manualOrderCancelTime);
        }

        public void CancelPnL(int reqId)
        {
            _clientSocket.cancelPnL(reqId);
        }

        public void CancelPnLSingle(int reqId)
        {
            _clientSocket.cancelPnL(reqId);
        }

        public void CancelPositions()
        {
            _clientSocket.cancelPositions();
        }

        public void CancelPositionsMulti(int requestId)
        {
            _clientSocket.cancelPositionsMulti(requestId);
        }

        public void CancelRealTimeBars(int tickerId)
        {
            _clientSocket.cancelRealTimeBars(tickerId);
        }

        public void CancelScannerSubscription(int tickerId)
        {
            _clientSocket.cancelScannerSubscription(tickerId);
        }

        public void CancelTickByTickData(int requestId)
        {
            _clientSocket.cancelTickByTickData(requestId);
        }

        public void CancelWshEventData(int reqId)
        {
            _clientSocket.cancelWshEventData(reqId);
        }

        public void CancelWshMetaData(int reqId)
        {
            _clientSocket.cancelWshMetaData(reqId);
        }

        public void Close()
        {
            _clientSocket.Close();
        }

        public void DisableUseV100Plus()
        {
            _clientSocket.DisableUseV100Plus();
        }

        public void EConnect(string host, int port, int clientId)
        {
            _clientSocket.eConnect(host, port, clientId);
        }

        public void EConnect(string host, int port, int clientId, bool extraAuth)
        {
            _clientSocket.eConnect(host, port, clientId, extraAuth);
        }

        public void EDisconnect(bool resetState = true)
        {
            _clientSocket.eDisconnect(resetState);
        }

        public void ExerciseOptions(int tickerId, Contract contract, int exerciseAction, int exerciseQuantity, string account, int ovrd)
        {
            _clientSocket.exerciseOptions(tickerId, contract, exerciseAction, exerciseQuantity, account, ovrd);
        }

        public bool IsConnected()
        {
            return _clientSocket.IsConnected();
        }

        public bool IsDataAvailable()
        {
            return _clientSocket.IsDataAvailable();
        }

        public void PlaceOrder(int id, Contract contract, Order order)
        {
            _clientSocket.placeOrder(id, contract, order);
        }

        public void QueryDisplayGroups(int requestId)
        {
            _clientSocket.queryDisplayGroups(requestId);
        }

        public byte[] ReadAtLeastNBytes(int msgSize)
        {
            return _clientSocket.ReadAtLeastNBytes(msgSize);
        }

        public byte[] ReadByteArray(int msgSize)
        {
            return _clientSocket.ReadByteArray(msgSize);
        }

        public int ReadInt()
        {
            return _clientSocket.ReadInt();
        }

        public void Redirect(string host)
        {
            _clientSocket.redirect(host);
        }

        public void ReplaceFA(int reqId, int faDataType, string xml)
        {
            _clientSocket.replaceFA(reqId, faDataType, xml);
        }

        public void ReqAccountSummary(int reqId, string group, string tags)
        {
            _clientSocket.reqAccountSummary(reqId, group, tags);
        }

        public void ReqAccountUpdates(bool subscribe, string acctCode)
        {
            _clientSocket.reqAccountUpdates(subscribe, acctCode);
        }

        public void ReqAccountUpdatesMulti(int requestId, string account, string modelCode, bool ledgerAndNLV)
        {
            _clientSocket.reqAccountUpdatesMulti(requestId, account, modelCode, ledgerAndNLV);
        }

        public void ReqAllOpenOrders()
        {
            _clientSocket.reqAllOpenOrders();
        }

        public void ReqAutoOpenOrders(bool autoBind)
        {
            _clientSocket.reqAutoOpenOrders(autoBind);
        }

        public void ReqCompletedOrders(bool apiOnly)
        {
            _clientSocket.reqCompletedOrders(apiOnly);
        }

        public void ReqContractDetails(int reqId, Contract contract)
        {
            _clientSocket.reqContractDetails(reqId, contract);
        }

        public void ReqCurrentTime()
        {
            _clientSocket.reqCurrentTime();
        }

        public void ReqExecutions(int reqId, ExecutionFilter filter)
        {
            _clientSocket.reqExecutions(reqId, filter);
        }

        public void ReqFamilyCodes()
        {
            _clientSocket.reqFamilyCodes();
        }

        public void ReqFundamentalData(int reqId, Contract contract, string reportType, List<TagValue> fundamentalDataOptions)
        {
            _clientSocket.reqFundamentalData(reqId, contract, reportType, fundamentalDataOptions);
        }

        public void ReqGlobalCancel()
        {
            _clientSocket.reqGlobalCancel();
        }

        public void ReqHeadTimestamp(int tickerId, Contract contract, string whatToShow, int useRTH, int formatDate)
        {
            _clientSocket.reqHeadTimestamp(tickerId, contract, whatToShow, useRTH, formatDate);
        }

        public void ReqHistogramData(int tickerId, Contract contract, bool useRTH, string period)
        {
            _clientSocket.reqHistogramData(tickerId, contract, useRTH, period);
        }

        public void ReqHistoricalData(int tickerId, Contract contract, string endDateTime, string durationStr, string barSizeSetting, string whatToShow, int useRTH, int formatDate, bool keepUpToDate, List<TagValue> chartOptions)
        {
            _clientSocket.reqHistoricalData(tickerId, contract, endDateTime, durationStr, barSizeSetting, whatToShow, useRTH, formatDate, keepUpToDate, chartOptions);
        }

        public void ReqHistoricalNews(int requestId, int conId, string providerCodes, string startDateTime, string endDateTime, int totalResults, List<TagValue> historicalNewsOptions)
        {
            _clientSocket.reqHistoricalNews(requestId, conId, providerCodes, startDateTime, endDateTime, totalResults, historicalNewsOptions);
        }

        public void ReqHistoricalTicks(int reqId, Contract contract, string startDateTime, string endDateTime, int numberOfTicks, string whatToShow, int useRth, bool ignoreSize, List<TagValue> miscOptions)
        {
            _clientSocket.reqHistoricalTicks(reqId, contract, startDateTime, endDateTime, numberOfTicks, whatToShow, useRth, ignoreSize, miscOptions);
        }

        public void ReqIds(int numIds)
        {
            _clientSocket.reqIds(numIds);
        }

        public void ReqManagedAccts()
        {
            _clientSocket.reqManagedAccts();
        }

        public void ReqMarketDataType(int marketDataType)
        {
            _clientSocket.reqMarketDataType(marketDataType);
        }

        public void ReqMarketDepth(int tickerId, Contract contract, int numRows, bool isSmartDepth, List<TagValue> mktDepthOptions)
        {
            _clientSocket.reqMarketDepth(tickerId, contract, numRows, isSmartDepth, mktDepthOptions);
        }

        public void ReqMarketRule(int marketRuleId)
        {
            _clientSocket.reqMarketRule(marketRuleId);
        }

        public void ReqMatchingSymbols(int reqId, string pattern)
        {
            _clientSocket.reqMatchingSymbols(reqId, pattern);
        }

        public void ReqMktData(int tickerId, Contract contract, string genericTickList, bool snapshot, bool regulatorySnaphsot, List<TagValue> mktDataOptions)
        {
            _clientSocket.reqMktData(tickerId, contract, genericTickList, snapshot, regulatorySnaphsot, mktDataOptions);
        }

        public void ReqMktDepthExchanges()
        {
            _clientSocket.reqMktDepthExchanges();
        }

        public void ReqNewsArticle(int requestId, string providerCode, string articleId, List<TagValue> newsArticleOptions)
        {
            _clientSocket.reqNewsArticle(requestId, providerCode, articleId, newsArticleOptions);
        }

        public void ReqNewsBulletins(bool allMessages)
        {
            _clientSocket.reqNewsBulletins(allMessages);
        }

        public void ReqNewsProviders()
        {
            _clientSocket.reqNewsProviders();
        }

        public void ReqOpenOrders()
        {
            _clientSocket.reqOpenOrders();
        }

        public void ReqPnL(int reqId, string account, string modelCode)
        {
            _clientSocket.reqPnL(reqId, account, modelCode);
        }

        public void ReqPnLSingle(int reqId, string account, string modelCode, int conId)
        {
            _clientSocket.reqPnLSingle(reqId, account, modelCode, conId);
        }

        public void ReqPositions()
        {
            _clientSocket.reqPositions();
        }

        public void ReqPositionsMulti(int requestId, string account, string modelCode)
        {
            _clientSocket.reqPositionsMulti(requestId, account, modelCode);
        }

        public void ReqRealTimeBars(int tickerId, Contract contract, int barSize, string whatToShow, bool useRTH, List<TagValue> realTimeBarsOptions)
        {
            _clientSocket.reqRealTimeBars(tickerId, contract, barSize, whatToShow, useRTH, realTimeBarsOptions);
        }

        public void ReqScannerParameters()
        {
            _clientSocket.reqScannerParameters();
        }

        public void ReqScannerSubscription(int reqId, ScannerSubscription subscription, List<TagValue> scannerSubscriptionOptions, List<TagValue> scannerSubscriptionFilterOptions)
        {
            _clientSocket.reqScannerSubscription(reqId, subscription, scannerSubscriptionOptions, scannerSubscriptionFilterOptions);
        }

        public void ReqScannerSubscription(int reqId, ScannerSubscription subscription, string scannerSubscriptionOptions, string scannerSubscriptionFilterOptions)
        {
            _clientSocket.reqScannerSubscription(reqId, subscription, scannerSubscriptionOptions, scannerSubscriptionFilterOptions);
        }

        public void ReqSecDefOptParams(int reqId, string underlyingSymbol, string futFopExchange, string underlyingSecType, int underlyingConId)
        {
            _clientSocket.reqSecDefOptParams(reqId, underlyingSymbol, futFopExchange, underlyingSecType, underlyingConId);
        }

        public void ReqSmartComponents(int reqId, string bboExchange)
        {
            _clientSocket.reqSmartComponents(reqId, bboExchange);
        }

        public void ReqSoftDollarTiers(int reqId)
        {
            _clientSocket.reqSoftDollarTiers(reqId);
        }

        public void ReqTickByTickData(int requestId, Contract contract, string tickType, int numberOfTicks, bool ignoreSize)
        {
            _clientSocket.reqTickByTickData(requestId, contract, tickType, numberOfTicks, ignoreSize);
        }

        public void RequestFA(int faDataType)
        {
            _clientSocket.requestFA(faDataType);
        }

        public void ReqUserInfo(int reqId)
        {
            _clientSocket.reqUserInfo(reqId);
        }

        public void ReqWshEventData(int reqId, WshEventData wshEventData)
        {
            _clientSocket.reqWshEventData(reqId, wshEventData);
        }

        public void ReqWshMetaData(int reqId)
        {
            _clientSocket.reqWshMetaData(reqId);
        }

        public void SetConnectOptions(string connectOptions)
        {
            _clientSocket.SetConnectOptions(connectOptions);
        }

        public void SetServerLogLevel(int logLevel)
        {
            _clientSocket.setServerLogLevel(logLevel);
        }

        public void StartApi()
        {
            _clientSocket.startApi();
        }

        public void SubscribeToGroupEvents(int requestId, int groupId)
        {
            _clientSocket.subscribeToGroupEvents(requestId, groupId);
        }

        public void UnsubscribeFromGroupEvents(int requestId)
        {
            _clientSocket.unsubscribeFromGroupEvents(requestId);
        }

        public void UpdateDisplayGroup(int requestId, string contractInfo)
        {
            _clientSocket.updateDisplayGroup(requestId, contractInfo);
        }

        public void VerifyAndAuthMessage(string apiData, string xyzResponse)
        {
            _clientSocket.verifyAndAuthMessage(apiData, xyzResponse);
        }

        public void VerifyAndAuthRequest(string apiName, string apiVersion, string opaqueIsvKey)
        {
            _clientSocket.verifyAndAuthRequest(apiName, apiVersion, opaqueIsvKey);
        }

        public void VerifyMessage(string apiData)
        {
            _clientSocket.verifyMessage(apiData);
        }

        public void VerifyRequest(string apiName, string apiVersion)
        {
            _clientSocket.verifyRequest(apiName, apiVersion);
        }
    }
}
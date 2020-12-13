using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using IB.CSharpApiClient.Messages;
using IBApi;

namespace IB.CSharpApiClient
{
    public class IBClient : IClientCommand, IClientMessage, IClientCommandAsync
    {
        #region Messages

        public event Action<AccountDownloadEndMessage> AccountDownloadEnd
        {
            add => _messageHandler.AccountDownloadEnd += value;
            remove => _messageHandler.AccountDownloadEnd -= value;
        }

        public event Action<AccountSummaryMessage> AccountSummary
        {
            add => _messageHandler.AccountSummary += value;
            remove => _messageHandler.AccountSummary -= value;
        }

        public event Action<AccountSummaryEndMessage> AccountSummaryEnd
        {
            add => _messageHandler.AccountSummaryEnd += value;
            remove => _messageHandler.AccountSummaryEnd -= value;
        }

        public event Action<AccountUpdateMultiMessage> AccountUpdateMulti
        {
            add => _messageHandler.AccountUpdateMulti += value;
            remove => _messageHandler.AccountUpdateMulti -= value;
        }

        public event Action<AccountUpdateMultiEndMessage> AccountUpdateMultiEnd
        {
            add => _messageHandler.AccountUpdateMultiEnd += value;
            remove => _messageHandler.AccountUpdateMultiEnd -= value;
        }

        public event Action<BondContractDetailsMessage> BondContractDetails
        {
            add => _messageHandler.BondContractDetails += value;
            remove => _messageHandler.BondContractDetails -= value;
        }

        public event Action<CommissionReportMessage> CommissionReport
        {
            add => _messageHandler.CommissionReport += value;
            remove => _messageHandler.CommissionReport -= value;
        }

        public event Action<CompletedOrderMessage> CompletedOrder
        {
            add => _messageHandler.CompletedOrder += value;
            remove => _messageHandler.CompletedOrder -= value;
        }

        public event Action CompletedOrdersEnd
        {
            add => _messageHandler.CompletedOrdersEnd += value;
            remove => _messageHandler.CompletedOrdersEnd -= value;
        }

        public event Action ConnectAck
        {
            add => _messageHandler.ConnectAck += value;
            remove => _messageHandler.ConnectAck -= value;
        }

        public event Action ConnectionClosed
        {
            add => _messageHandler.ConnectionClosed += value;
            remove => _messageHandler.ConnectionClosed -= value;
        }

        public event Action<ContractDetailsMessage> ContractDetails
        {
            add => _messageHandler.ContractDetails += value;
            remove => _messageHandler.ContractDetails -= value;
        }

        public event Action<ContractDetailsEndMessage> ContractDetailsEnd
        {
            add => _messageHandler.ContractDetailsEnd += value;
            remove => _messageHandler.ContractDetailsEnd -= value;
        }

        public event Action<CurrentTimeMessage> CurrentTime
        {
            add => _messageHandler.CurrentTime += value;
            remove => _messageHandler.CurrentTime -= value;
        }

        public event Action<DeltaNeutralValidationMessage> DeltaNeutralValidation
        {
            add => _messageHandler.DeltaNeutralValidation += value;
            remove => _messageHandler.DeltaNeutralValidation -= value;
        }

        public event Action<DisplayGroupListMessage> DisplayGroupList
        {
            add => _messageHandler.DisplayGroupList += value;
            remove => _messageHandler.DisplayGroupList -= value;
        }

        public event Action<DisplayGroupUpdatedMessage> DisplayGroupUpdated
        {
            add => _messageHandler.DisplayGroupUpdated += value;
            remove => _messageHandler.DisplayGroupUpdated -= value;
        }

        public event Action<ErrorMessage> Error
        {
            add => _messageHandler.Error += value;
            remove => _messageHandler.Error -= value;
        }

        public event Action<ExecDetailsMessage> ExecDetails
        {
            add => _messageHandler.ExecDetails += value;
            remove => _messageHandler.ExecDetails -= value;
        }

        public event Action<ExecDetailsEndMessage> ExecDetailsEnd
        {
            add => _messageHandler.ExecDetailsEnd += value;
            remove => _messageHandler.ExecDetailsEnd -= value;
        }

        public event Action<FamilyCodesMessage> FamilyCodes
        {
            add => _messageHandler.FamilyCodes += value;
            remove => _messageHandler.FamilyCodes -= value;
        }

        public event Action<FundamentalDataMessage> FundamentalData
        {
            add => _messageHandler.FundamentalData += value;
            remove => _messageHandler.FundamentalData -= value;
        }

        public event Action<HeadTimestampMessage> HeadTimestamp
        {
            add => _messageHandler.HeadTimestamp += value;
            remove => _messageHandler.HeadTimestamp -= value;
        }

        public event Action<HistogramDataMessage> HistogramData
        {
            add => _messageHandler.HistogramData += value;
            remove => _messageHandler.HistogramData -= value;
        }

        public event Action<HistoricalDataMessage> HistoricalData
        {
            add => _messageHandler.HistoricalData += value;
            remove => _messageHandler.HistoricalData -= value;
        }

        public event Action<HistoricalDataEndMessage> HistoricalDataEnd
        {
            add => _messageHandler.HistoricalDataEnd += value;
            remove => _messageHandler.HistoricalDataEnd -= value;
        }

        public event Action<HistoricalDataUpdateMessage> HistoricalDataUpdate
        {
            add => _messageHandler.HistoricalDataUpdate += value;
            remove => _messageHandler.HistoricalDataUpdate -= value;
        }

        public event Action<HistoricalNewsMessage> HistoricalNews
        {
            add => _messageHandler.HistoricalNews += value;
            remove => _messageHandler.HistoricalNews -= value;
        }

        public event Action<HistoricalNewsEndMessage> HistoricalNewsEnd
        {
            add => _messageHandler.HistoricalNewsEnd += value;
            remove => _messageHandler.HistoricalNewsEnd -= value;
        }

        public event Action<HistoricalTicksMessage> HistoricalTicks
        {
            add => _messageHandler.HistoricalTicks += value;
            remove => _messageHandler.HistoricalTicks -= value;
        }

        public event Action<HistoricalTicksBidAskMessage> HistoricalTicksBidAsk
        {
            add => _messageHandler.HistoricalTicksBidAsk += value;
            remove => _messageHandler.HistoricalTicksBidAsk -= value;
        }

        public event Action<HistoricalTicksLastMessage> HistoricalTicksLast
        {
            add => _messageHandler.HistoricalTicksLast += value;
            remove => _messageHandler.HistoricalTicksLast -= value;
        }

        public event Action<ManagedAccountsMessage> ManagedAccounts
        {
            add => _messageHandler.ManagedAccounts += value;
            remove => _messageHandler.ManagedAccounts -= value;
        }

        public event Action<MarketDataTypeMessage> MarketDataType
        {
            add => _messageHandler.MarketDataType += value;
            remove => _messageHandler.MarketDataType -= value;
        }

        public event Action<MarketRuleMessage> MarketRule
        {
            add => _messageHandler.MarketRule += value;
            remove => _messageHandler.MarketRule -= value;
        }

        public event Action<MktDepthExchangesMessage> MktDepthExchanges
        {
            add => _messageHandler.MktDepthExchanges += value;
            remove => _messageHandler.MktDepthExchanges -= value;
        }

        public event Action<NewsArticleMessage> NewsArticle
        {
            add => _messageHandler.NewsArticle += value;
            remove => _messageHandler.NewsArticle -= value;
        }

        public event Action<NewsProvidersMessage> NewsProviders
        {
            add => _messageHandler.NewsProviders += value;
            remove => _messageHandler.NewsProviders -= value;
        }

        public event Action<NextValidIdMessage> NextValidId
        {
            add => _messageHandler.NextValidId += value;
            remove => _messageHandler.NextValidId -= value;
        }

        public event Action<OpenOrderMessage> OpenOrder
        {
            add => _messageHandler.OpenOrder += value;
            remove => _messageHandler.OpenOrder -= value;
        }

        public event Action OpenOrderEnd
        {
            add => _messageHandler.OpenOrderEnd += value;
            remove => _messageHandler.OpenOrderEnd -= value;
        }

        public event Action<OrderBoundMessage> OrderBound
        {
            add => _messageHandler.OrderBound += value;
            remove => _messageHandler.OrderBound -= value;
        }

        public event Action<OrderStatusMessage> OrderStatus
        {
            add => _messageHandler.OrderStatus += value;
            remove => _messageHandler.OrderStatus -= value;
        }

        public event Action<PnLMessage> PnL
        {
            add => _messageHandler.PnL += value;
            remove => _messageHandler.PnL -= value;
        }

        public event Action<PnLSingleMessage> PnLSingle
        {
            add => _messageHandler.PnLSingle += value;
            remove => _messageHandler.PnLSingle -= value;
        }

        public event Action<PositionMessage> Position
        {
            add => _messageHandler.Position += value;
            remove => _messageHandler.Position -= value;
        }

        public event Action PositionEnd
        {
            add => _messageHandler.PositionEnd += value;
            remove => _messageHandler.PositionEnd -= value;
        }

        public event Action<PositionMultiMessage> PositionMulti
        {
            add => _messageHandler.PositionMulti += value;
            remove => _messageHandler.PositionMulti -= value;
        }

        public event Action<PositionMultiEndMessage> PositionMultiEnd
        {
            add => _messageHandler.PositionMultiEnd += value;
            remove => _messageHandler.PositionMultiEnd -= value;
        }

        public event Action<RealTimeBarMessage> RealTimeBar
        {
            add => _messageHandler.RealTimeBar += value;
            remove => _messageHandler.RealTimeBar -= value;
        }

        public event Action<ReceiveFAMessage> ReceiveFA
        {
            add => _messageHandler.ReceiveFA += value;
            remove => _messageHandler.ReceiveFA -= value;
        }

        public event Action<RerouteMktDataReqMessage> RerouteMktDataReq
        {
            add => _messageHandler.RerouteMktDataReq += value;
            remove => _messageHandler.RerouteMktDataReq -= value;
        }

        public event Action<RerouteMktDepthReqMessage> RerouteMktDepthReq
        {
            add => _messageHandler.RerouteMktDepthReq += value;
            remove => _messageHandler.RerouteMktDepthReq -= value;
        }

        public event Action<ScannerDataMessage> ScannerData
        {
            add => _messageHandler.ScannerData += value;
            remove => _messageHandler.ScannerData -= value;
        }

        public event Action<ScannerDataEndMessage> ScannerDataEnd
        {
            add => _messageHandler.ScannerDataEnd += value;
            remove => _messageHandler.ScannerDataEnd -= value;
        }

        public event Action<ScannerParametersMessage> ScannerParameters
        {
            add => _messageHandler.ScannerParameters += value;
            remove => _messageHandler.ScannerParameters -= value;
        }

        public event Action<SecurityDefinitionOptionParameterMessage> SecurityDefinitionOptionParameter
        {
            add => _messageHandler.SecurityDefinitionOptionParameter += value;
            remove => _messageHandler.SecurityDefinitionOptionParameter -= value;
        }

        public event Action<SecurityDefinitionOptionParameterEndMessage> SecurityDefinitionOptionParameterEnd
        {
            add => _messageHandler.SecurityDefinitionOptionParameterEnd += value;
            remove => _messageHandler.SecurityDefinitionOptionParameterEnd -= value;
        }

        public event Action<SmartComponentsMessage> SmartComponents
        {
            add => _messageHandler.SmartComponents += value;
            remove => _messageHandler.SmartComponents -= value;
        }

        public event Action<SoftDollarTiersMessage> SoftDollarTiers
        {
            add => _messageHandler.SoftDollarTiers += value;
            remove => _messageHandler.SoftDollarTiers -= value;
        }

        public event Action<SymbolSamplesMessage> SymbolSamples
        {
            add => _messageHandler.SymbolSamples += value;
            remove => _messageHandler.SymbolSamples -= value;
        }

        public event Action<TickByTickAllLastMessage> TickByTickAllLast
        {
            add => _messageHandler.TickByTickAllLast += value;
            remove => _messageHandler.TickByTickAllLast -= value;
        }

        public event Action<TickByTickBidAskMessage> TickByTickBidAsk
        {
            add => _messageHandler.TickByTickBidAsk += value;
            remove => _messageHandler.TickByTickBidAsk -= value;
        }

        public event Action<TickByTickMidPointMessage> TickByTickMidPoint
        {
            add => _messageHandler.TickByTickMidPoint += value;
            remove => _messageHandler.TickByTickMidPoint -= value;
        }

        public event Action<TickEFPMessage> TickEFP
        {
            add => _messageHandler.TickEFP += value;
            remove => _messageHandler.TickEFP -= value;
        }

        public event Action<TickGenericMessage> TickGeneric
        {
            add => _messageHandler.TickGeneric += value;
            remove => _messageHandler.TickGeneric -= value;
        }

        public event Action<TickNewsMessage> TickNews
        {
            add => _messageHandler.TickNews += value;
            remove => _messageHandler.TickNews -= value;
        }

        public event Action<TickOptionComputationMessage> TickOptionComputation
        {
            add => _messageHandler.TickOptionComputation += value;
            remove => _messageHandler.TickOptionComputation -= value;
        }

        public event Action<TickPriceMessage> TickPrice
        {
            add => _messageHandler.TickPrice += value;
            remove => _messageHandler.TickPrice -= value;
        }

        public event Action<TickReqParamsMessage> TickReqParams
        {
            add => _messageHandler.TickReqParams += value;
            remove => _messageHandler.TickReqParams -= value;
        }

        public event Action<TickSizeMessage> TickSize
        {
            add => _messageHandler.TickSize += value;
            remove => _messageHandler.TickSize -= value;
        }

        public event Action<TickSnapshotEndMessage> TickSnapshotEnd
        {
            add => _messageHandler.TickSnapshotEnd += value;
            remove => _messageHandler.TickSnapshotEnd -= value;
        }

        public event Action<TickStringMessage> TickString
        {
            add => _messageHandler.TickString += value;
            remove => _messageHandler.TickString -= value;
        }

        public event Action<UpdateAccountTimeMessage> UpdateAccountTime
        {
            add => _messageHandler.UpdateAccountTime += value;
            remove => _messageHandler.UpdateAccountTime -= value;
        }

        public event Action<UpdateAccountValueMessage> UpdateAccountValue
        {
            add => _messageHandler.UpdateAccountValue += value;
            remove => _messageHandler.UpdateAccountValue -= value;
        }

        public event Action<UpdateMktDepthMessage> UpdateMktDepth
        {
            add => _messageHandler.UpdateMktDepth += value;
            remove => _messageHandler.UpdateMktDepth -= value;
        }

        public event Action<UpdateMktDepthL2Message> UpdateMktDepthL2
        {
            add => _messageHandler.UpdateMktDepthL2 += value;
            remove => _messageHandler.UpdateMktDepthL2 -= value;
        }

        public event Action<UpdateNewsBulletinMessage> UpdateNewsBulletin
        {
            add => _messageHandler.UpdateNewsBulletin += value;
            remove => _messageHandler.UpdateNewsBulletin -= value;
        }

        public event Action<UpdatePortfolioMessage> UpdatePortfolio
        {
            add => _messageHandler.UpdatePortfolio += value;
            remove => _messageHandler.UpdatePortfolio -= value;
        }

        public event Action<VerifyAndAuthCompletedMessage> VerifyAndAuthCompleted
        {
            add => _messageHandler.VerifyAndAuthCompleted += value;
            remove => _messageHandler.VerifyAndAuthCompleted -= value;
        }

        public event Action<VerifyAndAuthMessageAPIMessage> VerifyAndAuthMessageAPI
        {
            add => _messageHandler.VerifyAndAuthMessageAPI += value;
            remove => _messageHandler.VerifyAndAuthMessageAPI -= value;
        }

        public event Action<VerifyCompletedMessage> VerifyCompleted
        {
            add => _messageHandler.VerifyCompleted += value;
            remove => _messageHandler.VerifyCompleted -= value;
        }

        public event Action<VerifyMessageAPIMessage> VerifyMessageAPI
        {
            add => _messageHandler.VerifyMessageAPI += value;
            remove => _messageHandler.VerifyMessageAPI -= value;
        }

        #endregion

        private readonly EReaderSignal _readerSignal;
        private readonly EClientSocket _clientSocket;
        private readonly IClientCommandAsync _clientCommandAsync;
        private readonly IMessageHandler _messageHandler;
        private readonly ManualResetEventSlim _manualResetEventSlim;

        public IBClient(
            EReaderSignal readerSignal,
            EClientSocket clientSocket,
            IClientCommandAsync clientCommandAsync,
            IMessageHandler messageHandler,
            ManualResetEventSlim manualResetEventSlim)
        {
            _readerSignal = readerSignal;
            _clientSocket = clientSocket;
            _clientCommandAsync = clientCommandAsync;
            _messageHandler = messageHandler;
            _manualResetEventSlim = manualResetEventSlim;
        }

        #region Commands

        #region Properties

        public bool AllowRedirect
        {
            get => _clientSocket.AllowRedirect;
            set => _clientSocket.AllowRedirect = value;
        }

        public int ServerVersion => _clientSocket.ServerVersion;

        public string ServerTime => _clientSocket.ServerTime;

        public string OptionalCapabilities
        {
            get => _clientSocket.optionalCapabilities;
            set => _clientSocket.optionalCapabilities = value;
        }

        public bool ConnectAsync
        {
            get => _clientSocket.AsyncEConnect;
            set => _clientSocket.AsyncEConnect = value;
        }

        #endregion

        public void Connect(string host, int port, int clientId)
        {
            if (IsConnected())
                return;

            _clientSocket.eConnect(host, port, clientId);
            WaitForServerConnected();
        }

        public void Connect(string host, int port, int clientId, bool extraAuth)
        {
            if (IsConnected())
                return;

            _clientSocket.eConnect(host, port, clientId, extraAuth);
            WaitForServerConnected();
        }

        public void Redirect(string host)
        {
            _clientSocket.redirect(host);
        }

        public void Disconnect(bool resetState = true)
        {
            _clientSocket.eDisconnect(resetState);
        }

        public void SetConnectOptions(string connectOptions)
        {
            _clientSocket.SetConnectOptions(connectOptions);
        }

        public void DisableUseV100Plus()
        {
            _clientSocket.DisableUseV100Plus();
        }

        public bool IsConnected()
        {
            return _clientSocket.IsConnected();
        }

        public void StartApi()
        {
            _clientSocket.startApi();
        }

        public void Close()
        {
            _clientSocket.Close();
        }

        public void ReqCompletedOrders(bool apiOnly)
        {
            _clientSocket.reqCompletedOrders(apiOnly);
        }

        public void CancelTickByTickData(int requestId)
        {
            _clientSocket.cancelTickByTickData(requestId);
        }

        public void ReqTickByTickData(int requestId, Contract contract, string tickType, int numberOfTicks,
            bool ignoreSize)
        {
            _clientSocket.reqTickByTickData(requestId, contract, tickType, numberOfTicks, ignoreSize);
        }

        public void CancelHistoricalData(int reqId)
        {
            _clientSocket.cancelHistoricalData(reqId);
        }

        public void CalculateImpliedVolatility(int reqId, Contract contract, double optionPrice, double underPrice,
            List<TagValue> impliedVolatilityOptions)
        {
            _clientSocket.calculateImpliedVolatility(reqId, contract, optionPrice, underPrice,
                impliedVolatilityOptions);
        }

        public void CalculateOptionPrice(int reqId, Contract contract, double volatility, double underPrice,
            List<TagValue> optionPriceOptions)
        {
            _clientSocket.calculateOptionPrice(reqId, contract, volatility, underPrice, optionPriceOptions);
        }

        public void CancelAccountSummary(int reqId)
        {
            _clientSocket.cancelAccountSummary(reqId);
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

        public void CancelOrder(int orderId)
        {
            _clientSocket.cancelOrder(orderId);
        }

        public void CancelPositions()
        {
            _clientSocket.cancelPositions();
        }

        public void CancelRealTimeBars(int tickerId)
        {
            _clientSocket.cancelRealTimeBars(tickerId);
        }

        public void CancelScannerSubscription(int tickerId)
        {
            _clientSocket.cancelScannerSubscription(tickerId);
        }

        public void ExerciseOptions(int tickerId, Contract contract, int exerciseAction, int exerciseQuantity,
            string account, int ovrd)
        {
            _clientSocket.exerciseOptions(tickerId, contract, exerciseAction, exerciseQuantity, account, ovrd);
        }

        public void PlaceOrder(int id, Contract contract, Order order)
        {
            _clientSocket.placeOrder(id, contract, order);
        }

        public void ReplaceFA(int faDataType, string xml)
        {
            _clientSocket.replaceFA(faDataType, xml);
        }

        public void RequestFA(int faDataType)
        {
            _clientSocket.requestFA(faDataType);
        }

        public void ReqAccountSummary(int reqId, string @group, string tags)
        {
            _clientSocket.reqAccountSummary(reqId, group, tags);
        }

        public void ReqAccountUpdates(bool subscribe, string acctCode)
        {
            _clientSocket.reqAccountUpdates(subscribe, acctCode);
        }

        public void ReqAllOpenOrders()
        {
            _clientSocket.reqAllOpenOrders();
        }

        public void ReqAutoOpenOrders(bool autoBind)
        {
            _clientSocket.reqAutoOpenOrders(autoBind);
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

        public void ReqFundamentalData(int reqId, Contract contract, string reportType,
            List<TagValue> fundamentalDataOptions)
        {
            _clientSocket.reqFundamentalData(reqId, contract, reportType, fundamentalDataOptions);
        }

        public void ReqGlobalCancel()
        {
            _clientSocket.reqGlobalCancel();
        }

        public void ReqHistoricalData(int tickerId, Contract contract, string endDateTime, string durationString,
            string barSizeSetting, string whatToShow, int useRTH, int formatDate, bool keepUpToDate,
            List<TagValue> chartOptions)
        {
            _clientSocket.reqHistoricalData(tickerId, contract, endDateTime, durationString, barSizeSetting, whatToShow,
                useRTH, formatDate, keepUpToDate, chartOptions);
        }

        public void ReqIds(int numIds)
        {
            _clientSocket.reqIds(numIds);
        }

        public void ReqManagedAccts()
        {
            _clientSocket.reqManagedAccts();
        }

        public void ReqMktData(int tickerId, Contract contract, string genericTickList, bool snapshot,
            bool regulatorySnaphsot, List<TagValue> mktDataOptions)
        {
            _clientSocket.reqMktData(tickerId, contract, genericTickList, snapshot, regulatorySnaphsot, mktDataOptions);
        }

        public void ReqMarketDataType(int marketDataType)
        {
            _clientSocket.reqMarketDataType(marketDataType);
        }

        public void ReqMarketDepth(int tickerId, Contract contract, int numRows, bool isSmartDepth,
            List<TagValue> mktDepthOptions)
        {
            _clientSocket.reqMarketDepth(tickerId, contract, numRows, isSmartDepth, mktDepthOptions);
        }

        public void ReqNewsBulletins(bool allMessages)
        {
            _clientSocket.reqNewsBulletins(allMessages);
        }

        public void ReqOpenOrders()
        {
            _clientSocket.reqOpenOrders();
        }

        public void ReqPositions()
        {
            _clientSocket.reqPositions();
        }

        public void ReqRealTimeBars(int tickerId, Contract contract, int barSize, string whatToShow, bool useRTH,
            List<TagValue> realTimeBarsOptions)
        {
            _clientSocket.reqRealTimeBars(tickerId, contract, barSize, whatToShow, useRTH, realTimeBarsOptions);
        }

        public void ReqScannerParameters()
        {
            _clientSocket.reqScannerParameters();
        }

        public void ReqScannerSubscription(int reqId, ScannerSubscription subscription,
            List<TagValue> scannerSubscriptionOptions, List<TagValue> scannerSubscriptionFilterOptions)
        {
            _clientSocket.reqScannerSubscription(reqId, subscription, scannerSubscriptionOptions,
                scannerSubscriptionFilterOptions);
        }

        public void ReqScannerSubscription(int reqId, ScannerSubscription subscription,
            string scannerSubscriptionOptions, string scannerSubscriptionFilterOptions)
        {
            _clientSocket.reqScannerSubscription(reqId, subscription, scannerSubscriptionOptions,
                scannerSubscriptionFilterOptions);
        }

        public void SetServerLogLevel(int logLevel)
        {
            _clientSocket.setServerLogLevel(logLevel);
        }

        public void VerifyRequest(string apiName, string apiVersion)
        {
            _clientSocket.verifyRequest(apiName, apiVersion);
        }

        public void VerifyMessage(string apiData)
        {
            _clientSocket.verifyMessage(apiData);
        }

        public void VerifyAndAuthRequest(string apiName, string apiVersion, string opaqueIsvKey)
        {
            _clientSocket.verifyAndAuthRequest(apiName, apiVersion, opaqueIsvKey);
        }

        public void VerifyAndAuthMessage(string apiData, string xyzResponse)
        {
            _clientSocket.verifyAndAuthMessage(apiData, xyzResponse);
        }

        public void QueryDisplayGroups(int requestId)
        {
            _clientSocket.queryDisplayGroups(requestId);
        }

        public void SubscribeToGroupEvents(int requestId, int groupId)
        {
            _clientSocket.subscribeToGroupEvents(requestId, groupId);
        }

        public void UpdateDisplayGroup(int requestId, string contractInfo)
        {
            _clientSocket.updateDisplayGroup(requestId, contractInfo);
        }

        public void UnsubscribeFromGroupEvents(int requestId)
        {
            _clientSocket.unsubscribeFromGroupEvents(requestId);
        }

        public void ReqPositionsMulti(int requestId, string account, string modelCode)
        {
            _clientSocket.reqPositionsMulti(requestId, account, modelCode);
        }

        public void CancelPositionsMulti(int requestId)
        {
            _clientSocket.cancelPositionsMulti(requestId);
        }

        public void ReqAccountUpdatesMulti(int requestId, string account, string modelCode, bool ledgerAndNLV)
        {
            _clientSocket.reqAccountUpdatesMulti(requestId, account, modelCode, ledgerAndNLV);
        }

        public void CancelAccountUpdatesMulti(int requestId)
        {
            _clientSocket.cancelAccountUpdatesMulti(requestId);
        }

        public void ReqSecDefOptParams(int reqId, string underlyingSymbol, string futFopExchange,
            string underlyingSecType, int underlyingConId)
        {
            _clientSocket.reqSecDefOptParams(reqId, underlyingSymbol, futFopExchange, underlyingSecType,
                underlyingConId);
        }

        public void ReqSoftDollarTiers(int reqId)
        {
            _clientSocket.reqSoftDollarTiers(reqId);
        }

        public void ReqFamilyCodes()
        {
            _clientSocket.reqFamilyCodes();
        }

        public void ReqMatchingSymbols(int reqId, string pattern)
        {
            _clientSocket.reqMatchingSymbols(reqId, pattern);
        }

        public void ReqMktDepthExchanges()
        {
            _clientSocket.reqMktDepthExchanges();
        }

        public void ReqSmartComponents(int reqId, string bboExchange)
        {
            _clientSocket.reqSmartComponents(reqId, bboExchange);
        }

        public void ReqNewsProviders()
        {
            _clientSocket.reqNewsProviders();
        }

        public void ReqNewsArticle(int requestId, string providerCode, string articleId,
            List<TagValue> newsArticleOptions)
        {
            _clientSocket.reqNewsArticle(requestId, providerCode, articleId, newsArticleOptions);
        }

        public void ReqHistoricalNews(int requestId, int conId, string providerCodes, string startDateTime,
            string endDateTime,
            int totalResults, List<TagValue> historicalNewsOptions)
        {
            _clientSocket.reqHistoricalNews(requestId, conId, providerCodes, startDateTime, endDateTime, totalResults,
                historicalNewsOptions);
        }

        public void ReqHeadTimestamp(int tickerId, Contract contract, string whatToShow, int useRTH, int formatDate)
        {
            _clientSocket.reqHeadTimestamp(tickerId, contract, whatToShow, useRTH, formatDate);
        }

        public void CancelHeadTimestamp(int tickerId)
        {
            _clientSocket.cancelHeadTimestamp(tickerId);
        }

        public void ReqHistogramData(int tickerId, Contract contract, bool useRTH, string period)
        {
            _clientSocket.reqHistogramData(tickerId, contract, useRTH, period);
        }

        public void CancelHistogramData(int tickerId)
        {
            _clientSocket.cancelHistogramData(tickerId);
        }

        public void ReqMarketRule(int marketRuleId)
        {
            _clientSocket.reqMarketRule(marketRuleId);
        }

        public void ReqPnL(int reqId, string account, string modelCode)
        {
            _clientSocket.reqPnL(reqId, account, modelCode);
        }

        public void CancelPnL(int reqId)
        {
            _clientSocket.cancelPnL(reqId);
        }

        public void ReqPnLSingle(int reqId, string account, string modelCode, int conId)
        {
            _clientSocket.reqPnLSingle(reqId, account, modelCode, conId);
        }

        public void CancelPnLSingle(int reqId)
        {
            _clientSocket.cancelPnLSingle(reqId);
        }

        public void ReqHistoricalTicks(int reqId, Contract contract, string startDateTime, string endDateTime,
            int numberOfTicks,
            string whatToShow, int useRth, bool ignoreSize, List<TagValue> miscOptions)
        {
            _clientSocket.reqHistoricalTicks(reqId, contract, startDateTime, endDateTime, numberOfTicks, whatToShow,
                useRth, ignoreSize, miscOptions);
        }

        public bool IsDataAvailable()
        {
            return _clientSocket.IsDataAvailable();
        }

        public int ReadInt()
        {
            return _clientSocket.ReadInt();
        }

        public byte[] ReadAtLeastNBytes(int msgSize)
        {
            return _clientSocket.ReadAtLeastNBytes(msgSize);
        }

        public byte[] ReadByteArray(int msgSize)
        {
            return _clientSocket.ReadByteArray(msgSize);
        }

        #endregion

        private void WaitForServerConnected()
        {
            _manualResetEventSlim.Reset();
            _messageHandler.NextValidId += MessageHandlerOnNextValidId;

            CreateReaderThread();

            _manualResetEventSlim.Wait();
            _messageHandler.NextValidId -= MessageHandlerOnNextValidId;

            void MessageHandlerOnNextValidId(NextValidIdMessage obj)
            {
                _manualResetEventSlim.Set();
            }
        }

        private void CreateReaderThread()
        {
            try
            {
                var reader = new EReader(_clientSocket, _readerSignal);
                reader.Start();

                new Thread(() =>
                    {
                        while (_clientSocket.IsConnected())
                        {
                            _readerSignal.waitForSignal();
                            reader.processMsgs();
                        }
                    })
                { IsBackground = true }.Start();
            }
            catch (Exception)
            {
                _messageHandler.error(-1, -1, "Please check your connection attributes.");
            }
        }

        #region Commands Async
        public Task<IEnumerable<ScannerDataMessage>> GetScannerDataAsync(ScannerSubscription subscription, List<TagValue> scannerSubscriptionOptions, List<TagValue> scannerSubscriptionFilterOptions)
        {
            return _clientCommandAsync.GetScannerDataAsync(subscription, scannerSubscriptionOptions, scannerSubscriptionFilterOptions);
        }

        public Task<IEnumerable<ScannerDataMessage>> GetScannerDataAsync(ScannerSubscription subscription, string scannerSubscriptionOptions, string scannerSubscriptionFilterOptions)
        {
            return _clientCommandAsync.GetScannerDataAsync(subscription, scannerSubscriptionOptions, scannerSubscriptionFilterOptions);
        }
        #endregion
    }
}

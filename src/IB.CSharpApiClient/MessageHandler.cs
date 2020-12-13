using System;
using System.Collections.Generic;
using IB.CSharpApiClient.Messages;
using IBApi;

namespace IB.CSharpApiClient
{
    public class MessageHandler : IMessageHandler
    {
        public event Action<AccountDownloadEndMessage> AccountDownloadEnd;
        public event Action<AccountSummaryMessage> AccountSummary;
        public event Action<AccountSummaryEndMessage> AccountSummaryEnd;
        public event Action<AccountUpdateMultiMessage> AccountUpdateMulti;
        public event Action<AccountUpdateMultiEndMessage> AccountUpdateMultiEnd;
        public event Action<BondContractDetailsMessage> BondContractDetails;
        public event Action<CommissionReportMessage> CommissionReport;
        public event Action<CompletedOrderMessage> CompletedOrder;
        public event Action CompletedOrdersEnd;
        public event Action ConnectAck;
        public event Action ConnectionClosed;
        public event Action<ContractDetailsMessage> ContractDetails;
        public event Action<ContractDetailsEndMessage> ContractDetailsEnd;
        public event Action<CurrentTimeMessage> CurrentTime;
        public event Action<DeltaNeutralValidationMessage> DeltaNeutralValidation;
        public event Action<DisplayGroupListMessage> DisplayGroupList;
        public event Action<DisplayGroupUpdatedMessage> DisplayGroupUpdated;
        public event Action<ErrorMessage> Error;
        public event Action<ExecDetailsMessage> ExecDetails;
        public event Action<ExecDetailsEndMessage> ExecDetailsEnd;
        public event Action<FamilyCodesMessage> FamilyCodes;
        public event Action<FundamentalDataMessage> FundamentalData;
        public event Action<HeadTimestampMessage> HeadTimestamp;
        public event Action<HistogramDataMessage> HistogramData;
        public event Action<HistoricalDataMessage> HistoricalData;
        public event Action<HistoricalDataEndMessage> HistoricalDataEnd;
        public event Action<HistoricalDataUpdateMessage> HistoricalDataUpdate;
        public event Action<HistoricalNewsMessage> HistoricalNews;
        public event Action<HistoricalNewsEndMessage> HistoricalNewsEnd;
        public event Action<HistoricalTicksMessage> HistoricalTicks;
        public event Action<HistoricalTicksBidAskMessage> HistoricalTicksBidAsk;
        public event Action<HistoricalTicksLastMessage> HistoricalTicksLast;
        public event Action<ManagedAccountsMessage> ManagedAccounts;
        public event Action<MarketDataTypeMessage> MarketDataType;
        public event Action<MarketRuleMessage> MarketRule;
        public event Action<MktDepthExchangesMessage> MktDepthExchanges;
        public event Action<NewsArticleMessage> NewsArticle;
        public event Action<NewsProvidersMessage> NewsProviders;
        public event Action<NextValidIdMessage> NextValidId;
        public event Action<OpenOrderMessage> OpenOrder;
        public event Action OpenOrderEnd;
        public event Action<OrderBoundMessage> OrderBound;
        public event Action<OrderStatusMessage> OrderStatus;
        public event Action<PnLMessage> PnL;
        public event Action<PnLSingleMessage> PnLSingle;
        public event Action<PositionMessage> Position;
        public event Action PositionEnd;
        public event Action<PositionMultiMessage> PositionMulti;
        public event Action<PositionMultiEndMessage> PositionMultiEnd;
        public event Action<RealTimeBarMessage> RealTimeBar;
        public event Action<ReceiveFAMessage> ReceiveFA;
        public event Action<RerouteMktDataReqMessage> RerouteMktDataReq;
        public event Action<RerouteMktDepthReqMessage> RerouteMktDepthReq;
        public event Action<ScannerDataMessage> ScannerData;
        public event Action<ScannerDataEndMessage> ScannerDataEnd;
        public event Action<ScannerParametersMessage> ScannerParameters;
        public event Action<SecurityDefinitionOptionParameterMessage> SecurityDefinitionOptionParameter;
        public event Action<SecurityDefinitionOptionParameterEndMessage> SecurityDefinitionOptionParameterEnd;
        public event Action<SmartComponentsMessage> SmartComponents;
        public event Action<SoftDollarTiersMessage> SoftDollarTiers;
        public event Action<SymbolSamplesMessage> SymbolSamples;
        public event Action<TickByTickAllLastMessage> TickByTickAllLast;
        public event Action<TickByTickBidAskMessage> TickByTickBidAsk;
        public event Action<TickByTickMidPointMessage> TickByTickMidPoint;
        public event Action<TickEFPMessage> TickEFP;
        public event Action<TickGenericMessage> TickGeneric;
        public event Action<TickNewsMessage> TickNews;
        public event Action<TickOptionComputationMessage> TickOptionComputation;
        public event Action<TickPriceMessage> TickPrice;
        public event Action<TickReqParamsMessage> TickReqParams;
        public event Action<TickSizeMessage> TickSize;
        public event Action<TickSnapshotEndMessage> TickSnapshotEnd;
        public event Action<TickStringMessage> TickString;
        public event Action<UpdateAccountTimeMessage> UpdateAccountTime;
        public event Action<UpdateAccountValueMessage> UpdateAccountValue;
        public event Action<UpdateMktDepthMessage> UpdateMktDepth;
        public event Action<UpdateMktDepthL2Message> UpdateMktDepthL2;
        public event Action<UpdateNewsBulletinMessage> UpdateNewsBulletin;
        public event Action<UpdatePortfolioMessage> UpdatePortfolio;
        public event Action<VerifyAndAuthCompletedMessage> VerifyAndAuthCompleted;
        public event Action<VerifyAndAuthMessageAPIMessage> VerifyAndAuthMessageAPI;
        public event Action<VerifyCompletedMessage> VerifyCompleted;
        public event Action<VerifyMessageAPIMessage> VerifyMessageAPI;
        public event Action<ReplaceFAEndMessage> ReplaceFAEnd;

        #region Handlers
        public void accountDownloadEnd(string account)
        {
            AccountDownloadEnd?.Invoke(new AccountDownloadEndMessage(account));
        }

        public void accountSummary(int reqId, string account, string tag, string value, string currency)
        {
            AccountSummary?.Invoke(new AccountSummaryMessage(reqId, account, tag, value, currency));
        }

        public void accountSummaryEnd(int reqId)
        {
            AccountSummaryEnd?.Invoke(new AccountSummaryEndMessage(reqId));
        }

        public void accountUpdateMulti(int requestId, string account, string modelCode, string key, string value, string currency)
        {
            AccountUpdateMulti?.Invoke(new AccountUpdateMultiMessage(requestId, account, modelCode, key, value, currency));
        }

        public void accountUpdateMultiEnd(int requestId)
        {
            AccountUpdateMultiEnd?.Invoke(new AccountUpdateMultiEndMessage(requestId));
        }

        public void bondContractDetails(int reqId, ContractDetails contract)
        {
            BondContractDetails?.Invoke(new BondContractDetailsMessage(reqId, contract));
        }

        public void commissionReport(CommissionReport commissionReport)
        {
            CommissionReport?.Invoke(new CommissionReportMessage(commissionReport));
        }

        public void completedOrder(Contract contract, Order order, OrderState orderState)
        {
            CompletedOrder?.Invoke(new CompletedOrderMessage(contract, order, orderState));
        }

        public void completedOrdersEnd()
        {
            CompletedOrdersEnd?.Invoke();
        }

        public void replaceFAEnd(int reqId, string text)
        {
            ReplaceFAEnd?.Invoke(new ReplaceFAEndMessage(reqId, text));
        }

        public void connectAck()
        {
            ConnectAck?.Invoke();
        }

        public void connectionClosed()
        {
            ConnectionClosed?.Invoke();
        }

        public void contractDetails(int reqId, ContractDetails contractDetails)
        {
            ContractDetails?.Invoke(new ContractDetailsMessage(reqId, contractDetails));
        }

        public void contractDetailsEnd(int reqId)
        {
            ContractDetailsEnd?.Invoke(new ContractDetailsEndMessage(reqId));
        }

        public void currentTime(long time)
        {
            CurrentTime?.Invoke(new CurrentTimeMessage(time));
        }

        public void deltaNeutralValidation(int reqId, DeltaNeutralContract deltaNeutralContract)
        {
            DeltaNeutralValidation?.Invoke(new DeltaNeutralValidationMessage(reqId, deltaNeutralContract));
        }

        public void tickOptionComputation(int tickerId, int field, int tickAttrib, double impliedVolatility, double delta,
            double optPrice, double pvDividend, double gamma, double vega, double theta, double undPrice)
        {

            TickOptionComputation?.Invoke(new TickOptionComputationMessage(tickerId, field, tickAttrib, impliedVolatility, delta, optPrice, pvDividend, gamma, vega, theta, undPrice));
        }

        public void displayGroupList(int reqId, string groups)
        {
            DisplayGroupList?.Invoke(new DisplayGroupListMessage(reqId, groups));
        }

        public void displayGroupUpdated(int reqId, string contractInfo)
        {
            DisplayGroupUpdated?.Invoke(new DisplayGroupUpdatedMessage(reqId, contractInfo));
        }

        public void error(Exception e)
        {
            Error?.Invoke(new ErrorMessage(e));
        }

        public void error(string str)
        {
            Error?.Invoke(new ErrorMessage(str));
        }

        public void error(int id, int errorCode, string errorMsg)
        {
            Error?.Invoke(new ErrorMessage(id, errorCode, errorMsg));
        }

        public void execDetails(int reqId, Contract contract, Execution execution)
        {
            ExecDetails?.Invoke(new ExecDetailsMessage(reqId, contract, execution));
        }

        public void execDetailsEnd(int reqId)
        {
            ExecDetailsEnd?.Invoke(new ExecDetailsEndMessage(reqId));
        }

        public void familyCodes(FamilyCode[] familyCodes)
        {
            FamilyCodes?.Invoke(new FamilyCodesMessage(familyCodes));
        }

        public void fundamentalData(int reqId, string data)
        {
            FundamentalData?.Invoke(new FundamentalDataMessage(reqId, data));
        }

        public void headTimestamp(int reqId, string headTimestamp)
        {
            HeadTimestamp?.Invoke(new HeadTimestampMessage(reqId, headTimestamp));
        }

        public void histogramData(int reqId, HistogramEntry[] data)
        {
            HistogramData?.Invoke(new HistogramDataMessage(reqId, data));
        }

        public void historicalData(int reqId, Bar bar)
        {
            HistoricalData?.Invoke(new HistoricalDataMessage(reqId, bar));
        }

        public void historicalDataEnd(int reqId, string start, string end)
        {
            HistoricalDataEnd?.Invoke(new HistoricalDataEndMessage(reqId, start, end));
        }

        public void historicalDataUpdate(int reqId, Bar bar)
        {
            HistoricalDataUpdate?.Invoke(new HistoricalDataUpdateMessage(reqId, bar));
        }

        public void historicalNews(int requestId, string time, string providerCode, string articleId, string headline)
        {
            HistoricalNews?.Invoke(new HistoricalNewsMessage(requestId, time, providerCode, articleId, headline));
        }

        public void historicalNewsEnd(int requestId, bool hasMore)
        {
            HistoricalNewsEnd?.Invoke(new HistoricalNewsEndMessage(requestId, hasMore));
        }

        public void historicalTicks(int reqId, HistoricalTick[] ticks, bool done)
        {
            HistoricalTicks?.Invoke(new HistoricalTicksMessage(reqId, ticks, done));
        }

        public void historicalTicksBidAsk(int reqId, HistoricalTickBidAsk[] ticks, bool done)
        {
            HistoricalTicksBidAsk?.Invoke(new HistoricalTicksBidAskMessage(reqId, ticks, done));
        }

        public void historicalTicksLast(int reqId, HistoricalTickLast[] ticks, bool done)
        {
            HistoricalTicksLast?.Invoke(new HistoricalTicksLastMessage(reqId, ticks, done));
        }

        public void managedAccounts(string accountsList)
        {
            ManagedAccounts?.Invoke(new ManagedAccountsMessage(accountsList));
        }

        public void marketDataType(int reqId, int marketDataType)
        {
            MarketDataType?.Invoke(new MarketDataTypeMessage(reqId, marketDataType));
        }

        public void marketRule(int marketRuleId, PriceIncrement[] priceIncrements)
        {
            MarketRule?.Invoke(new MarketRuleMessage(marketRuleId, priceIncrements));
        }

        public void mktDepthExchanges(DepthMktDataDescription[] depthMktDataDescriptions)
        {
            MktDepthExchanges?.Invoke(new MktDepthExchangesMessage(depthMktDataDescriptions));
        }

        public void newsArticle(int requestId, int articleType, string articleText)
        {
            NewsArticle?.Invoke(new NewsArticleMessage(requestId, articleType, articleText));
        }

        public void newsProviders(NewsProvider[] newsProviders)
        {
            NewsProviders?.Invoke(new NewsProvidersMessage(newsProviders));
        }

        public void nextValidId(int orderId)
        {
            NextValidId?.Invoke(new NextValidIdMessage(orderId));
        }

        public void openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
            OpenOrder?.Invoke(new OpenOrderMessage(orderId, contract, order, orderState));
        }

        public void openOrderEnd()
        {
            OpenOrderEnd?.Invoke();
        }

        public void orderBound(long orderId, int apiClientId, int apiOrderId)
        {
            OrderBound?.Invoke(new OrderBoundMessage(orderId, apiClientId, apiOrderId));
        }

        public void orderStatus(int orderId, string status, double filled, double remaining, double avgFillPrice, int permId, int parentId, double lastFillPrice, int clientId, string whyHeld, double mktCapPrice)
        {
            OrderStatus?.Invoke(new OrderStatusMessage(orderId, status, filled, remaining, avgFillPrice, permId, parentId, lastFillPrice, clientId, whyHeld, mktCapPrice));
        }

        public void pnl(int reqId, double dailyPnL, double unrealizedPnL, double realizedPnL)
        {
            PnL?.Invoke(new PnLMessage(reqId, dailyPnL, unrealizedPnL, realizedPnL));
        }

        public void pnlSingle(int reqId, int pos, double dailyPnL, double unrealizedPnL, double realizedPnL, double value)
        {
            PnLSingle?.Invoke(new PnLSingleMessage(reqId, pos, dailyPnL, unrealizedPnL, realizedPnL, value));
        }

        public void position(string account, Contract contract, double pos, double avgCost)
        {
            Position?.Invoke(new PositionMessage(account, contract, pos, avgCost));
        }

        public void positionEnd()
        {
            PositionEnd?.Invoke();
        }

        public void positionMulti(int requestId, string account, string modelCode, Contract contract, double pos, double avgCost)
        {
            PositionMulti?.Invoke(new PositionMultiMessage(requestId, account, modelCode, contract, pos, avgCost));
        }

        public void positionMultiEnd(int requestId)
        {
            PositionMultiEnd?.Invoke(new PositionMultiEndMessage(requestId));
        }

        public void realtimeBar(int reqId, long date, double open, double high, double low, double close, long volume, double WAP, int count)
        {
            RealTimeBar?.Invoke(new RealTimeBarMessage(reqId, date, open, high, low, close, volume, WAP, count));
        }

        public void receiveFA(int faDataType, string faXmlData)
        {
            ReceiveFA?.Invoke(new ReceiveFAMessage(faDataType, faXmlData));
        }

        public void rerouteMktDataReq(int reqId, int conId, string exchange)
        {
            RerouteMktDataReq?.Invoke(new RerouteMktDataReqMessage(reqId, conId, exchange));
        }

        public void rerouteMktDepthReq(int reqId, int conId, string exchange)
        {
            RerouteMktDepthReq?.Invoke(new RerouteMktDepthReqMessage(reqId, conId, exchange));
        }

        public void scannerData(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark, string projection, string legsStr)
        {
            ScannerData?.Invoke(new ScannerDataMessage(reqId, rank, contractDetails, distance, benchmark, projection, legsStr));
        }

        public void scannerDataEnd(int reqId)
        {
            ScannerDataEnd?.Invoke(new ScannerDataEndMessage(reqId));
        }

        public void scannerParameters(string xml)
        {
            ScannerParameters?.Invoke(new ScannerParametersMessage(xml));
        }

        public void securityDefinitionOptionParameter(int reqId, string exchange, int underlyingConId, string tradingClass, string multiplier, HashSet<string> expirations, HashSet<double> strikes)
        {
            SecurityDefinitionOptionParameter?.Invoke(new SecurityDefinitionOptionParameterMessage(reqId, exchange, underlyingConId, tradingClass, multiplier, expirations, strikes));
        }

        public void securityDefinitionOptionParameterEnd(int reqId)
        {
            SecurityDefinitionOptionParameterEnd?.Invoke(new SecurityDefinitionOptionParameterEndMessage(reqId));
        }

        public void smartComponents(int reqId, Dictionary<int, KeyValuePair<string, char>> theMap)
        {
            SmartComponents?.Invoke(new SmartComponentsMessage(reqId, theMap));
        }

        public void softDollarTiers(int reqId, SoftDollarTier[] tiers)
        {
            SoftDollarTiers?.Invoke(new SoftDollarTiersMessage(reqId, tiers));
        }

        public void symbolSamples(int reqId, ContractDescription[] contractDescriptions)
        {
            SymbolSamples?.Invoke(new SymbolSamplesMessage(reqId, contractDescriptions));
        }

        public void tickByTickAllLast(int reqId, int tickType, long time, double price, int size, TickAttribLast tickAttriblast, string exchange, string specialConditions)
        {
            TickByTickAllLast?.Invoke(new TickByTickAllLastMessage(reqId, tickType, time, price, size, tickAttriblast, exchange, specialConditions));
        }

        public void tickByTickBidAsk(int reqId, long time, double bidPrice, double askPrice, int bidSize, int askSize, TickAttribBidAsk tickAttribBidAsk)
        {
            TickByTickBidAsk?.Invoke(new TickByTickBidAskMessage(reqId, time, bidPrice, askPrice, bidSize, askSize, tickAttribBidAsk));
        }

        public void tickByTickMidPoint(int reqId, long time, double midPoint)
        {
            TickByTickMidPoint?.Invoke(new TickByTickMidPointMessage(reqId, time, midPoint));
        }

        public void tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture, int holdDays, string futureLastTradeDate, double dividendImpact, double dividendsToLastTradeDate)
        {
            TickEFP?.Invoke(new TickEFPMessage(tickerId, tickType, basisPoints, formattedBasisPoints, impliedFuture, holdDays, futureLastTradeDate, dividendImpact, dividendsToLastTradeDate));
        }

        public void tickGeneric(int tickerId, int field, double value)
        {
            TickGeneric?.Invoke(new TickGenericMessage(tickerId, field, value));
        }

        public void tickNews(int tickerId, long timeStamp, string providerCode, string articleId, string headline, string extraData)
        {
            TickNews?.Invoke(new TickNewsMessage(tickerId, timeStamp, providerCode, articleId, headline, extraData));
        }

        public void tickPrice(int tickerId, int field, double price, TickAttrib attribs)
        {
            TickPrice?.Invoke(new TickPriceMessage(tickerId, field, price, attribs));
        }

        public void tickReqParams(int tickerId, double minTick, string bboExchange, int snapshotPermissions)
        {
            TickReqParams?.Invoke(new TickReqParamsMessage(tickerId, minTick, bboExchange, snapshotPermissions));
        }

        public void tickSize(int tickerId, int field, int size)
        {
            TickSize?.Invoke(new TickSizeMessage(tickerId, field, size));
        }

        public void tickSnapshotEnd(int tickerId)
        {
            TickSnapshotEnd?.Invoke(new TickSnapshotEndMessage(tickerId));
        }

        public void tickString(int tickerId, int field, string value)
        {
            TickString?.Invoke(new TickStringMessage(tickerId, field, value));
        }

        public void updateAccountTime(string timestamp)
        {
            UpdateAccountTime?.Invoke(new UpdateAccountTimeMessage(timestamp));
        }

        public void updateAccountValue(string key, string value, string currency, string accountName)
        {
            UpdateAccountValue?.Invoke(new UpdateAccountValueMessage(key, value, currency, accountName));
        }

        public void updateMktDepth(int tickerId, int position, int operation, int side, double price, int size)
        {
            UpdateMktDepth?.Invoke(new UpdateMktDepthMessage(tickerId, position, operation, side, price, size));
        }

        public void updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, double price, int size, bool isSmartDepth)
        {
            UpdateMktDepthL2?.Invoke(new UpdateMktDepthL2Message(tickerId, position, marketMaker, operation, side, price, size, isSmartDepth));
        }

        public void updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            UpdateNewsBulletin?.Invoke(new UpdateNewsBulletinMessage(msgId, msgType, message, origExchange));
        }

        public void updatePortfolio(Contract contract, double position, double marketPrice, double marketValue, double averageCost, double unrealizedPNL, double realizedPNL, string accountName)
        {
            UpdatePortfolio?.Invoke(new UpdatePortfolioMessage(contract, position, marketPrice, marketValue, averageCost, unrealizedPNL, realizedPNL, accountName));
        }

        public void verifyAndAuthCompleted(bool isSuccessful, string errorText)
        {
            VerifyAndAuthCompleted?.Invoke(new VerifyAndAuthCompletedMessage(isSuccessful, errorText));
        }

        public void verifyAndAuthMessageAPI(string apiData, string xyzChallenge)
        {
            VerifyAndAuthMessageAPI?.Invoke(new VerifyAndAuthMessageAPIMessage(apiData, xyzChallenge));
        }

        public void verifyCompleted(bool isSuccessful, string errorText)
        {
            VerifyCompleted?.Invoke(new VerifyCompletedMessage(isSuccessful, errorText));
        }

        public void verifyMessageAPI(string apiData)
        {
            VerifyMessageAPI?.Invoke(new VerifyMessageAPIMessage(apiData));
        } 
        #endregion
    }
}

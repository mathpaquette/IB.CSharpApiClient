using System;
using System.Collections.Generic;
using IB.CSharpApiClient.Events;
using IB.CSharpApiClient.Extensions;
using IBApi;

namespace IB.CSharpApiClient
{
    public class ApiEventDispatcher : IApiEventDispatcher
    {
        public event EventHandler<AccountDownloadEndEventArgs> AccountDownloadEnd;
        public event EventHandler<AccountSummaryEventArgs> AccountSummary;
        public event EventHandler<AccountSummaryEndEventArgs> AccountSummaryEnd;
        public event EventHandler<AccountUpdateMultiEventArgs> AccountUpdateMulti;
        public event EventHandler<AccountUpdateMultiEndEventArgs> AccountUpdateMultiEnd;
        public event EventHandler<AccountValueEventArgs> AccountValue;
        public event EventHandler<AdvisorDataEventArgs> AdvisorData;
        public event EventHandler<BondContractDetailsEventArgs> BondContractDetails;
        public event EventHandler<CommissionReportEventArgs> CommissionReport;
        public event EventHandler ConnectionClosed;
        public event EventHandler<ConnectionStatusEventArgs> ConnectionStatus;
        public event EventHandler<ContractDetailsEventArgs> ContractDetails;
        public event EventHandler<ContractDetailsEndEventArgs> ContractDetailsEnd;
        public event EventHandler<DailyPnLEventArgs> DailyPnL;
        public event EventHandler<DailyPnLSingleEventArgs> DailyPnLSingle;
        public event EventHandler<DeepBookEventArgs> DeepBook;
        public event EventHandler<DeltaNeutralValidationEventArgs> DeltaNeutralValidation;
        public event EventHandler<ErrorEventArgs> Error;
        public event EventHandler<ExecutionEventArgs> Execution;
        public event EventHandler<ExecutionEndEventArgs> ExecutionEnd;
        public event EventHandler<FamilyCodesEventArgs> FamilyCodes;
        public event EventHandler<FundamentalsEventArgs> Fundamentals;
        public event EventHandler<HeadTimestampEventArgs> HeadTimestamp;
        public event EventHandler<HistogramDataEventArgs> HistogramData;
        public event EventHandler<HistoricalDataEventArgs> HistoricalData;
        public event EventHandler<HistoricalDataEndEventArgs> HistoricalDataEnd;
        public event EventHandler<HistoricalDataEventArgs> HistoricalDataUpdate;
        public event EventHandler<HistoricalNewsEventArgs> HistoricalNews;
        public event EventHandler<HistoricalNewsEndEventArgs> HistoricalNewsEnd;
        public event EventHandler<HistoricalTickEventArgs> HistoricalTick;
        public event EventHandler<HistoricalTickBidAskEventArgs> HistoricalTickBidAsk;
        public event EventHandler<HistoricalTickBidAskEndEventArgs> HistoricalTickBidAskEnd;
        public event EventHandler<HistoricalTickEndEventArgs> HistoricalTickEnd;
        public event EventHandler<HistoricalTickLastEventArgs> HistoricalTickLast;
        public event EventHandler<HistoricalTickLastEndEventArgs> HistoricalTickLastEnd;
        public event EventHandler<ManagedAccountsEventArgs> ManagedAccounts;
        public event EventHandler<MarketDataTypeEventArgs> MarketDataType;
        public event EventHandler<MarketRuleEventArgs> MarketRule;
        public event EventHandler<MktDepthExchangesEventArgs> MktDepthExchanges;
        public event EventHandler<NewsArticleEventArgs> NewsArticle;
        public event EventHandler<NewsProvidersEventArgs> NewsProviders;
        public event EventHandler<OpenOrderEventArgs> OpenOrder;
        public event EventHandler OpenOrderEnd;
        public event EventHandler<OrderStatusEventArgs> OrderStatus;
        public event EventHandler<PositionEventArgs> Position;
        public event EventHandler PositionEnd;
        public event EventHandler<PositionMultiEventArgs> PositionMulti;
        public event EventHandler<PositionMultiEndEventArgs> PositionMultiEnd;
        public event EventHandler<RealTimeBarEventArgs> RealTimeBar;
        public event EventHandler<ScannerEventArgs> Scanner;
        public event EventHandler<ScannerEndEventArgs> ScannerEnd;
        public event EventHandler<ScannerParametersEventArgs> ScannerParameters;
        public event EventHandler<SecurityDefinitionOptionParameterEventArgs> SecurityDefinitionOptionParameter;
        public event EventHandler<SecurityDefinitionOptionParameterEndEventArgs> SecurityDefinitionOptionParameterEnd;
        public event EventHandler<SoftDollarTiersEventArgs> SoftDollarTiers;
        public event EventHandler<SymbolSamplesEventArgs> SymbolSamples;
        public event EventHandler<TickByTickAllLastEventArgs> TickByTickAllLast;
        public event EventHandler<TickByTickBidAskEventArgs> TickByTickBidAsk;
        public event EventHandler<TickByTickMidPointEventArgs> TickByTickMidPoint;
        public event EventHandler<TickEfpEventArgs> TickEfp;
        public event EventHandler<TickGenericEventArgs> TickGeneric;
        public event EventHandler<TickNewsEventArgs> TickNews;
        public event EventHandler<TickOptionEventArgs> TickOption;
        public event EventHandler<TickPriceEventArgs> TickPrice;
        public event EventHandler<TickReqParamsEventArgs> TickReqParams;
        public event EventHandler<TickSizeEventArgs> TickSize;
        public event EventHandler<TickSnapshotEndEventArgs> TickSnapshotEnd;
        public event EventHandler<TickStringEventArgs> TickString;
        public event EventHandler<TimeEventArgs> Time;
        public event EventHandler<UpdateAccountTimeEventArgs> UpdateAccountTime;
        public event EventHandler<UpdatePortfolioEventArgs> UpdatePortfolio;
        public event EventHandler ConnectAck;
        public event EventHandler<UpdateNewsBulletin> UpdateNewsBulletin;
        public event EventHandler<VerifyMessageApiEventArgs> VerifyMessageApi;
        public event EventHandler<VerifyCompletedEventArgs> VerifyCompleted;
        public event EventHandler<VerifyAndAuthMessageApiEventArgs> VerifyAndAuthMessageApi;
        public event EventHandler<VerifyAndAuthCompletedEventArgs> VerifyAndAuthCompleted;
        public event EventHandler<DisplayGroupListEventArgs> DisplayGroupList;
        public event EventHandler<DisplayGroupUpdatedEventArgs> DisplayGroupUpdated;
        public event EventHandler<SmartComponentsEventArgs> SmartComponents;
        public event EventHandler<RerouteRequest> RerouteMktDataRequest;
        public event EventHandler<RerouteRequest> RerouteMktDepthRequest;

        #region Callbacks
        public void error(Exception e)
        {
            Error.RaiseEvent(this, new ErrorEventArgs(e));
        }

        public void error(string str)
        {
            Error.RaiseEvent(this, new ErrorEventArgs(str));
        }

        public void error(int id, int errorCode, string errorMsg)
        {
            Error.RaiseEvent(this, new ErrorEventArgs(id, errorCode, errorMsg));
        }

        public void currentTime(long time)
        {
            Time.RaiseEvent(this, new TimeEventArgs(time));
        }

        public void tickPrice(int tickerId, int field, double price, TickAttrib attribs)
        {
            TickPrice.RaiseEvent(this, new TickPriceEventArgs(tickerId, field, price, attribs));
        }

        public void tickSize(int tickerId, int field, int size)
        {
            TickSize.RaiseEvent(this, new TickSizeEventArgs(tickerId, field, size));
        }

        public void tickString(int tickerId, int field, string value)
        {
            TickString.RaiseEvent(this, new TickStringEventArgs(tickerId, field, value));
        }

        public void tickGeneric(int tickerId, int field, double value)
        {
            TickGeneric.RaiseEvent(this, new TickGenericEventArgs(tickerId, field, value));
        }

        public void tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture,
            int holdDays, string futureLastTradeDate, double dividendImpact, double dividendsToLastTradeDate)
        {
            TickEfp.RaiseEvent(this, new TickEfpEventArgs(tickerId, tickType, basisPoints, formattedBasisPoints, impliedFuture, holdDays, futureLastTradeDate, dividendImpact, dividendsToLastTradeDate));
        }

        public void deltaNeutralValidation(int reqId, UnderComp underComp)
        {
            DeltaNeutralValidation.RaiseEvent(this, new DeltaNeutralValidationEventArgs(reqId, underComp));
        }

        public void tickOptionComputation(int tickerId, int field, double impliedVolatility, double delta, double optPrice,
            double pvDividend, double gamma, double vega, double theta, double undPrice)
        {
            TickOption.RaiseEvent(this, new TickOptionEventArgs(tickerId, field, impliedVolatility, delta, optPrice, pvDividend, gamma, vega, theta, undPrice));
        }

        public void tickSnapshotEnd(int tickerId)
        {
            TickSnapshotEnd.RaiseEvent(this, new TickSnapshotEndEventArgs(tickerId));
        }

        public void nextValidId(int orderId)
        {
            ConnectionStatus.RaiseEvent(this, new ConnectionStatusEventArgs(true, orderId));
        }

        public void managedAccounts(string accountsList)
        {
            ManagedAccounts.RaiseEvent(this, new ManagedAccountsEventArgs(accountsList));
        }

        public void connectionClosed()
        {
            ConnectionClosed.RaiseEvent(this, EventArgs.Empty);
        }

        public void accountSummary(int reqId, string account, string tag, string value, string currency)
        {
            AccountSummary.RaiseEvent(this, new AccountSummaryEventArgs(reqId, account, tag, value, currency));
        }

        public void accountSummaryEnd(int reqId)
        {
            AccountSummaryEnd.RaiseEvent(this, new AccountSummaryEndEventArgs(reqId));
        }

        public void bondContractDetails(int reqId, ContractDetails contract)
        {
            BondContractDetails.RaiseEvent(this, new BondContractDetailsEventArgs(reqId, contract));
        }

        public void updateAccountValue(string key, string value, string currency, string accountName)
        {
            AccountValue.RaiseEvent(this, new AccountValueEventArgs(key, value, currency, accountName));
        }

        public void updatePortfolio(Contract contract, double position, double marketPrice, double marketValue, double averageCost,
            double unrealizedPNL, double realizedPNL, string accountName)
        {
            UpdatePortfolio.RaiseEvent(this, new UpdatePortfolioEventArgs(contract, position, marketPrice, marketValue, averageCost, unrealizedPNL, realizedPNL, accountName));
        }

        public void updateAccountTime(string timestamp)
        {
            UpdateAccountTime.RaiseEvent(this, new UpdateAccountTimeEventArgs(timestamp));
        }

        public void accountDownloadEnd(string account)
        {
            AccountDownloadEnd.RaiseEvent(this, new AccountDownloadEndEventArgs(account));
        }

        public void orderStatus(int orderId, string status, double filled, double remaining, double avgFillPrice, int permId,
            int parentId, double lastFillPrice, int clientId, string whyHeld, double mktCapPrice)
        {
            OrderStatus.RaiseEvent(this, new OrderStatusEventArgs(orderId, status, filled, remaining, avgFillPrice, permId, parentId,
            lastFillPrice, clientId, whyHeld, mktCapPrice));
        }

        public void openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
            OpenOrder.RaiseEvent(this, new OpenOrderEventArgs(orderId, contract, order, orderState));
        }

        public void openOrderEnd()
        {
            OpenOrderEnd.RaiseEvent(this, EventArgs.Empty);
        }

        public void contractDetails(int reqId, ContractDetails contractDetails)
        {
            ContractDetails.RaiseEvent(this, new ContractDetailsEventArgs(reqId, contractDetails));
        }

        public void contractDetailsEnd(int reqId)
        {
            ContractDetailsEnd.RaiseEvent(this, new ContractDetailsEndEventArgs(reqId));
        }

        public void execDetails(int reqId, Contract contract, Execution execution)
        {
            Execution.RaiseEvent(this, new ExecutionEventArgs(reqId, contract, execution));
        }

        public void execDetailsEnd(int reqId)
        {
            ExecutionEnd.RaiseEvent(this, new ExecutionEndEventArgs(reqId));
        }

        public void commissionReport(CommissionReport commissionReport)
        {
            CommissionReport.RaiseEvent(this, new CommissionReportEventArgs(commissionReport));
        }

        public void fundamentalData(int reqId, string data)
        {
            Fundamentals.RaiseEvent(this, new FundamentalsEventArgs(reqId, data));
        }

        public void historicalData(int reqId, Bar bar)
        {
            HistoricalData.RaiseEvent(this, new HistoricalDataEventArgs(reqId, bar));
        }

        public void historicalDataUpdate(int reqId, Bar bar)
        {
            HistoricalDataUpdate.RaiseEvent(this, new HistoricalDataEventArgs(reqId, bar));
        }

        public void historicalDataEnd(int reqId, string start, string end)
        {
            HistoricalDataEnd.RaiseEvent(this, new HistoricalDataEndEventArgs(reqId, start, end));
        }

        public void marketDataType(int reqId, int marketDataType)
        {
            MarketDataType.RaiseEvent(this, new MarketDataTypeEventArgs(reqId, marketDataType));
        }

        public void updateMktDepth(int tickerId, int position, int operation, int side, double price, int size)
        {
            DeepBook.RaiseEvent(this, new DeepBookEventArgs(tickerId, position, operation, side, price, size, string.Empty));
        }

        public void updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, double price, int size)
        {
            DeepBook.RaiseEvent(this, new DeepBookEventArgs(tickerId, position, operation, side, price, size, marketMaker));
        }

        public void updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            UpdateNewsBulletin.RaiseEvent(this, new UpdateNewsBulletin(msgId, msgType, message, origExchange));
        }

        public void position(string account, Contract contract, double pos, double avgCost)
        {
            Position.RaiseEvent(this, new PositionEventArgs(account, contract, pos, avgCost));
        }

        public void positionEnd()
        {
            PositionEnd.RaiseEvent(this, EventArgs.Empty);
        }

        public void realtimeBar(int reqId, long time, double open, double high, double low, double close, long volume, double WAP,
            int count)
        {
            RealTimeBar.RaiseEvent(this, new RealTimeBarEventArgs(reqId, time, open, high, low, close, volume, WAP, count));
        }

        public void scannerParameters(string xml)
        {
            ScannerParameters.RaiseEvent(this, new ScannerParametersEventArgs(xml));
        }

        public void scannerData(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark,
            string projection, string legsStr)
        {
            Scanner.RaiseEvent(this, new ScannerEventArgs(reqId, rank, contractDetails, distance, benchmark, projection, legsStr));
        }

        public void scannerDataEnd(int reqId)
        {
            ScannerEnd.RaiseEvent(this, new ScannerEndEventArgs(reqId));
        }

        public void receiveFA(int faDataType, string faXmlData)
        {
            AdvisorData.RaiseEvent(this, new AdvisorDataEventArgs(faDataType, faXmlData));
        }

        public void verifyMessageAPI(string apiData)
        {
            VerifyMessageApi.RaiseEvent(this, new VerifyMessageApiEventArgs(apiData));
        }

        public void verifyCompleted(bool isSuccessful, string errorText)
        {
            VerifyCompleted.RaiseEvent(this, new VerifyCompletedEventArgs(isSuccessful, errorText));
        }

        public void verifyAndAuthMessageAPI(string apiData, string xyzChallenge)
        {
            VerifyAndAuthMessageApi.RaiseEvent(this, new VerifyAndAuthMessageApiEventArgs(apiData, xyzChallenge));
        }

        public void verifyAndAuthCompleted(bool isSuccessful, string errorText)
        {
            VerifyAndAuthCompleted.RaiseEvent(this, new VerifyAndAuthCompletedEventArgs(isSuccessful, errorText));
        }

        public void displayGroupList(int reqId, string groups)
        {
            DisplayGroupList.RaiseEvent(this, new DisplayGroupListEventArgs(reqId, groups));
        }

        public void displayGroupUpdated(int reqId, string contractInfo)
        {
            DisplayGroupUpdated.RaiseEvent(this, new DisplayGroupUpdatedEventArgs(reqId, contractInfo));
        }

        public void connectAck()
        {
            ConnectAck.RaiseEvent(this, EventArgs.Empty);
        }

        public void positionMulti(int requestId, string account, string modelCode, Contract contract, double pos, double avgCost)
        {
            PositionMulti.RaiseEvent(this, new PositionMultiEventArgs(requestId, account, modelCode, contract, pos, avgCost));
        }

        public void positionMultiEnd(int requestId)
        {
            PositionMultiEnd.RaiseEvent(this, new PositionMultiEndEventArgs(requestId));
        }

        public void accountUpdateMulti(int requestId, string account, string modelCode, string key, string value, string currency)
        {
            AccountUpdateMulti.RaiseEvent(this, new AccountUpdateMultiEventArgs(requestId, account, modelCode, key, value, currency));
        }

        public void accountUpdateMultiEnd(int requestId)
        {
            AccountUpdateMultiEnd.RaiseEvent(this, new AccountUpdateMultiEndEventArgs(requestId));
        }

        public void securityDefinitionOptionParameter(int reqId, string exchange, int underlyingConId, string tradingClass,
            string multiplier, HashSet<string> expirations, HashSet<double> strikes)
        {
            SecurityDefinitionOptionParameter.RaiseEvent(this, new SecurityDefinitionOptionParameterEventArgs(reqId, exchange, underlyingConId, tradingClass,
                multiplier, expirations, strikes));
        }

        public void securityDefinitionOptionParameterEnd(int reqId)
        {
            SecurityDefinitionOptionParameterEnd.RaiseEvent(this, new SecurityDefinitionOptionParameterEndEventArgs(reqId));
        }

        public void softDollarTiers(int reqId, SoftDollarTier[] tiers)
        {
            SoftDollarTiers.RaiseEvent(this, new SoftDollarTiersEventArgs(reqId, tiers));
        }

        public void familyCodes(FamilyCode[] familyCodes)
        {
            FamilyCodes.RaiseEvent(this, new FamilyCodesEventArgs(familyCodes));
        }

        public void symbolSamples(int reqId, ContractDescription[] contractDescriptions)
        {
            SymbolSamples.RaiseEvent(this, new SymbolSamplesEventArgs(reqId, contractDescriptions));
        }

        public void mktDepthExchanges(DepthMktDataDescription[] depthMktDataDescriptions)
        {
            MktDepthExchanges.RaiseEvent(this, new MktDepthExchangesEventArgs(depthMktDataDescriptions));
        }

        public void tickNews(int tickerId, long timeStamp, string providerCode, string articleId, string headline, string extraData)
        {
            TickNews.RaiseEvent(this, new TickNewsEventArgs(tickerId, timeStamp, providerCode, articleId, headline, extraData));
        }

        public void smartComponents(int reqId, Dictionary<int, KeyValuePair<string, char>> theMap)
        {
            SmartComponents.RaiseEvent(this, new SmartComponentsEventArgs(reqId, theMap));
        }

        public void tickReqParams(int tickerId, double minTick, string bboExchange, int snapshotPermissions)
        {
            TickReqParams.RaiseEvent(this, new TickReqParamsEventArgs(tickerId, minTick, bboExchange, snapshotPermissions));
        }

        public void newsProviders(NewsProvider[] newsProviders)
        {
            NewsProviders.RaiseEvent(this, new NewsProvidersEventArgs(newsProviders));
        }

        public void newsArticle(int requestId, int articleType, string articleText)
        {
            NewsArticle.RaiseEvent(this, new NewsArticleEventArgs(requestId, articleType, articleText));
        }

        public void historicalNews(int requestId, string time, string providerCode, string articleId, string headline)
        {
            HistoricalNews.RaiseEvent(this, new HistoricalNewsEventArgs(requestId, time, providerCode, articleId, headline));
        }

        public void historicalNewsEnd(int requestId, bool hasMore)
        {
            HistoricalNewsEnd.RaiseEvent(this, new HistoricalNewsEndEventArgs(requestId, hasMore));
        }

        public void headTimestamp(int reqId, string headTimestamp)
        {
            HeadTimestamp.RaiseEvent(this, new HeadTimestampEventArgs(reqId, headTimestamp));
        }

        public void histogramData(int reqId, HistogramEntry[] data)
        {
            HistogramData.RaiseEvent(this, new HistogramDataEventArgs(reqId, data));
        }

        public void rerouteMktDataReq(int reqId, int conId, string exchange)
        {
            RerouteMktDataRequest.RaiseEvent(reqId, new RerouteRequest(reqId, conId, exchange));
        }

        public void rerouteMktDepthReq(int reqId, int conId, string exchange)
        {
            RerouteMktDepthRequest.RaiseEvent(this, new RerouteRequest(reqId, conId, exchange));
        }

        public void marketRule(int marketRuleId, PriceIncrement[] priceIncrements)
        {
            MarketRule.RaiseEvent(this, new MarketRuleEventArgs(marketRuleId, priceIncrements));
        }

        public void pnl(int reqId, double dailyPnL, double unrealizedPnL, double realizedPnL)
        {
            DailyPnL.RaiseEvent(this, new DailyPnLEventArgs(reqId, dailyPnL, unrealizedPnL, realizedPnL));
        }

        public void pnlSingle(int reqId, int pos, double dailyPnL, double unrealizedPnL, double realizedPnL, double value)
        {
            DailyPnLSingle.RaiseEvent(this, new DailyPnLSingleEventArgs(reqId, pos, dailyPnL, unrealizedPnL, realizedPnL, value));
        }

        public void historicalTicks(int reqId, HistoricalTick[] ticks, bool done)
        {
            foreach (var tick in ticks)
            {
                HistoricalTick.RaiseEvent(this, new HistoricalTickEventArgs(reqId, tick.Time, tick.Price, tick.Size));
            }

            if (done)
            {
                HistoricalTickEnd.RaiseEvent(this, new HistoricalTickEndEventArgs(reqId));
            }
        }

        public void historicalTicksBidAsk(int reqId, HistoricalTickBidAsk[] ticks, bool done)
        {
            foreach (var tick in ticks)
            {
                HistoricalTickBidAsk.RaiseEvent(this, new HistoricalTickBidAskEventArgs(reqId, tick.Time, tick.Mask, tick.PriceBid, tick.PriceAsk, tick.SizeBid, tick.SizeAsk));
            }

            if (done)
            {
                HistoricalTickBidAskEnd.RaiseEvent(this, new HistoricalTickBidAskEndEventArgs(reqId));
            }
        }

        public void historicalTicksLast(int reqId, HistoricalTickLast[] ticks, bool done)
        {
            foreach (var tick in ticks)
            {
                HistoricalTickLast.RaiseEvent(this, new HistoricalTickLastEventArgs(reqId, tick.Time, tick.Mask, tick.Price, tick.Size, tick.Exchange, tick.SpecialConditions));
            }

            if (done)
            {
                HistoricalTickLastEnd.RaiseEvent(this, new HistoricalTickLastEndEventArgs(reqId));
            }
        }

        public void tickByTickAllLast(int reqId, int tickType, long time, double price, int size, TickAttrib attribs, string exchange,
            string specialConditions)
        {
            TickByTickAllLast.RaiseEvent(this, new TickByTickAllLastEventArgs(reqId, tickType, time, price, size, attribs, exchange, specialConditions));
        }

        public void tickByTickBidAsk(int reqId, long time, double bidPrice, double askPrice, int bidSize, int askSize,
            TickAttrib attribs)
        {
            TickByTickBidAsk.RaiseEvent(this, new TickByTickBidAskEventArgs(reqId, time, bidPrice, askPrice, bidSize, askSize, attribs));
        }

        public void tickByTickMidPoint(int reqId, long time, double midPoint)
        {
            TickByTickMidPoint.RaiseEvent(this, new TickByTickMidPointEventArgs(reqId, time, midPoint));
        }
        #endregion
    }
}

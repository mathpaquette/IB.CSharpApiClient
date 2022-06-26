using System;
using IB.CSharpApiClient.Messages;

namespace IB.CSharpApiClient
{
    public partial class IBClient: IClientMessage
    {
        public event Action<AccountDownloadEndMessage> AccountDownloadEnd
        {
            add => _clientMessageHandler.AccountDownloadEnd += value;
            remove => _clientMessageHandler.AccountDownloadEnd -= value;
        }

        public event Action<AccountSummaryMessage> AccountSummary
        {
            add => _clientMessageHandler.AccountSummary += value;
            remove => _clientMessageHandler.AccountSummary -= value;
        }

        public event Action<AccountSummaryEndMessage> AccountSummaryEnd
        {
            add => _clientMessageHandler.AccountSummaryEnd += value;
            remove => _clientMessageHandler.AccountSummaryEnd -= value;
        }

        public event Action<AccountUpdateMultiMessage> AccountUpdateMulti
        {
            add => _clientMessageHandler.AccountUpdateMulti += value;
            remove => _clientMessageHandler.AccountUpdateMulti -= value;
        }

        public event Action<AccountUpdateMultiEndMessage> AccountUpdateMultiEnd
        {
            add => _clientMessageHandler.AccountUpdateMultiEnd += value;
            remove => _clientMessageHandler.AccountUpdateMultiEnd -= value;
        }

        public event Action<BondContractDetailsMessage> BondContractDetails
        {
            add => _clientMessageHandler.BondContractDetails += value;
            remove => _clientMessageHandler.BondContractDetails -= value;
        }

        public event Action<CommissionReportMessage> CommissionReport
        {
            add => _clientMessageHandler.CommissionReport += value;
            remove => _clientMessageHandler.CommissionReport -= value;
        }

        public event Action<CompletedOrderMessage> CompletedOrder
        {
            add => _clientMessageHandler.CompletedOrder += value;
            remove => _clientMessageHandler.CompletedOrder -= value;
        }

        public event Action CompletedOrdersEnd
        {
            add => _clientMessageHandler.CompletedOrdersEnd += value;
            remove => _clientMessageHandler.CompletedOrdersEnd -= value;
        }

        public event Action ConnectAck
        {
            add => _clientMessageHandler.ConnectAck += value;
            remove => _clientMessageHandler.ConnectAck -= value;
        }

        public event Action ConnectionClosed
        {
            add => _clientMessageHandler.ConnectionClosed += value;
            remove => _clientMessageHandler.ConnectionClosed -= value;
        }

        public event Action<ContractDetailsMessage> ContractDetails
        {
            add => _clientMessageHandler.ContractDetails += value;
            remove => _clientMessageHandler.ContractDetails -= value;
        }

        public event Action<ContractDetailsEndMessage> ContractDetailsEnd
        {
            add => _clientMessageHandler.ContractDetailsEnd += value;
            remove => _clientMessageHandler.ContractDetailsEnd -= value;
        }

        public event Action<CurrentTimeMessage> CurrentTime
        {
            add => _clientMessageHandler.CurrentTime += value;
            remove => _clientMessageHandler.CurrentTime -= value;
        }

        public event Action<DeltaNeutralValidationMessage> DeltaNeutralValidation
        {
            add => _clientMessageHandler.DeltaNeutralValidation += value;
            remove => _clientMessageHandler.DeltaNeutralValidation -= value;
        }

        public event Action<DisplayGroupListMessage> DisplayGroupList
        {
            add => _clientMessageHandler.DisplayGroupList += value;
            remove => _clientMessageHandler.DisplayGroupList -= value;
        }

        public event Action<DisplayGroupUpdatedMessage> DisplayGroupUpdated
        {
            add => _clientMessageHandler.DisplayGroupUpdated += value;
            remove => _clientMessageHandler.DisplayGroupUpdated -= value;
        }

        public event Action<ErrorMessage> Error
        {
            add => _clientMessageHandler.Error += value;
            remove => _clientMessageHandler.Error -= value;
        }

        public event Action<ExecDetailsMessage> ExecDetails
        {
            add => _clientMessageHandler.ExecDetails += value;
            remove => _clientMessageHandler.ExecDetails -= value;
        }

        public event Action<ExecDetailsEndMessage> ExecDetailsEnd
        {
            add => _clientMessageHandler.ExecDetailsEnd += value;
            remove => _clientMessageHandler.ExecDetailsEnd -= value;
        }

        public event Action<FamilyCodesMessage> FamilyCodes
        {
            add => _clientMessageHandler.FamilyCodes += value;
            remove => _clientMessageHandler.FamilyCodes -= value;
        }

        public event Action<FundamentalDataMessage> FundamentalData
        {
            add => _clientMessageHandler.FundamentalData += value;
            remove => _clientMessageHandler.FundamentalData -= value;
        }

        public event Action<HeadTimestampMessage> HeadTimestamp
        {
            add => _clientMessageHandler.HeadTimestamp += value;
            remove => _clientMessageHandler.HeadTimestamp -= value;
        }

        public event Action<HistogramDataMessage> HistogramData
        {
            add => _clientMessageHandler.HistogramData += value;
            remove => _clientMessageHandler.HistogramData -= value;
        }

        public event Action<HistoricalDataMessage> HistoricalData
        {
            add => _clientMessageHandler.HistoricalData += value;
            remove => _clientMessageHandler.HistoricalData -= value;
        }

        public event Action<HistoricalDataEndMessage> HistoricalDataEnd
        {
            add => _clientMessageHandler.HistoricalDataEnd += value;
            remove => _clientMessageHandler.HistoricalDataEnd -= value;
        }

        public event Action<HistoricalDataUpdateMessage> HistoricalDataUpdate
        {
            add => _clientMessageHandler.HistoricalDataUpdate += value;
            remove => _clientMessageHandler.HistoricalDataUpdate -= value;
        }

        public event Action<HistoricalNewsMessage> HistoricalNews
        {
            add => _clientMessageHandler.HistoricalNews += value;
            remove => _clientMessageHandler.HistoricalNews -= value;
        }

        public event Action<HistoricalNewsEndMessage> HistoricalNewsEnd
        {
            add => _clientMessageHandler.HistoricalNewsEnd += value;
            remove => _clientMessageHandler.HistoricalNewsEnd -= value;
        }

        public event Action<HistoricalTicksMessage> HistoricalTicks
        {
            add => _clientMessageHandler.HistoricalTicks += value;
            remove => _clientMessageHandler.HistoricalTicks -= value;
        }

        public event Action<HistoricalTicksBidAskMessage> HistoricalTicksBidAsk
        {
            add => _clientMessageHandler.HistoricalTicksBidAsk += value;
            remove => _clientMessageHandler.HistoricalTicksBidAsk -= value;
        }

        public event Action<HistoricalTicksLastMessage> HistoricalTicksLast
        {
            add => _clientMessageHandler.HistoricalTicksLast += value;
            remove => _clientMessageHandler.HistoricalTicksLast -= value;
        }

        public event Action<ManagedAccountsMessage> ManagedAccounts
        {
            add => _clientMessageHandler.ManagedAccounts += value;
            remove => _clientMessageHandler.ManagedAccounts -= value;
        }

        public event Action<MarketDataTypeMessage> MarketDataType
        {
            add => _clientMessageHandler.MarketDataType += value;
            remove => _clientMessageHandler.MarketDataType -= value;
        }

        public event Action<MarketRuleMessage> MarketRule
        {
            add => _clientMessageHandler.MarketRule += value;
            remove => _clientMessageHandler.MarketRule -= value;
        }

        public event Action<MktDepthExchangesMessage> MktDepthExchanges
        {
            add => _clientMessageHandler.MktDepthExchanges += value;
            remove => _clientMessageHandler.MktDepthExchanges -= value;
        }

        public event Action<NewsArticleMessage> NewsArticle
        {
            add => _clientMessageHandler.NewsArticle += value;
            remove => _clientMessageHandler.NewsArticle -= value;
        }

        public event Action<NewsProvidersMessage> NewsProviders
        {
            add => _clientMessageHandler.NewsProviders += value;
            remove => _clientMessageHandler.NewsProviders -= value;
        }

        public event Action<NextValidIdMessage> NextValidId
        {
            add => _clientMessageHandler.NextValidId += value;
            remove => _clientMessageHandler.NextValidId -= value;
        }

        public event Action<OpenOrderMessage> OpenOrder
        {
            add => _clientMessageHandler.OpenOrder += value;
            remove => _clientMessageHandler.OpenOrder -= value;
        }

        public event Action OpenOrderEnd
        {
            add => _clientMessageHandler.OpenOrderEnd += value;
            remove => _clientMessageHandler.OpenOrderEnd -= value;
        }

        public event Action<OrderBoundMessage> OrderBound
        {
            add => _clientMessageHandler.OrderBound += value;
            remove => _clientMessageHandler.OrderBound -= value;
        }

        public event Action<OrderStatusMessage> OrderStatus
        {
            add => _clientMessageHandler.OrderStatus += value;
            remove => _clientMessageHandler.OrderStatus -= value;
        }

        public event Action<PnLMessage> PnL
        {
            add => _clientMessageHandler.PnL += value;
            remove => _clientMessageHandler.PnL -= value;
        }

        public event Action<PnLSingleMessage> PnLSingle
        {
            add => _clientMessageHandler.PnLSingle += value;
            remove => _clientMessageHandler.PnLSingle -= value;
        }

        public event Action<PositionMessage> Position
        {
            add => _clientMessageHandler.Position += value;
            remove => _clientMessageHandler.Position -= value;
        }

        public event Action PositionEnd
        {
            add => _clientMessageHandler.PositionEnd += value;
            remove => _clientMessageHandler.PositionEnd -= value;
        }

        public event Action<PositionMultiMessage> PositionMulti
        {
            add => _clientMessageHandler.PositionMulti += value;
            remove => _clientMessageHandler.PositionMulti -= value;
        }

        public event Action<PositionMultiEndMessage> PositionMultiEnd
        {
            add => _clientMessageHandler.PositionMultiEnd += value;
            remove => _clientMessageHandler.PositionMultiEnd -= value;
        }

        public event Action<RealTimeBarMessage> RealTimeBar
        {
            add => _clientMessageHandler.RealTimeBar += value;
            remove => _clientMessageHandler.RealTimeBar -= value;
        }

        public event Action<ReceiveFAMessage> ReceiveFA
        {
            add => _clientMessageHandler.ReceiveFA += value;
            remove => _clientMessageHandler.ReceiveFA -= value;
        }

        public event Action<RerouteMktDataReqMessage> RerouteMktDataReq
        {
            add => _clientMessageHandler.RerouteMktDataReq += value;
            remove => _clientMessageHandler.RerouteMktDataReq -= value;
        }

        public event Action<RerouteMktDepthReqMessage> RerouteMktDepthReq
        {
            add => _clientMessageHandler.RerouteMktDepthReq += value;
            remove => _clientMessageHandler.RerouteMktDepthReq -= value;
        }

        public event Action<ScannerDataMessage> ScannerData
        {
            add => _clientMessageHandler.ScannerData += value;
            remove => _clientMessageHandler.ScannerData -= value;
        }

        public event Action<ScannerDataEndMessage> ScannerDataEnd
        {
            add => _clientMessageHandler.ScannerDataEnd += value;
            remove => _clientMessageHandler.ScannerDataEnd -= value;
        }

        public event Action<ScannerParametersMessage> ScannerParameters
        {
            add => _clientMessageHandler.ScannerParameters += value;
            remove => _clientMessageHandler.ScannerParameters -= value;
        }

        public event Action<SecurityDefinitionOptionParameterMessage> SecurityDefinitionOptionParameter
        {
            add => _clientMessageHandler.SecurityDefinitionOptionParameter += value;
            remove => _clientMessageHandler.SecurityDefinitionOptionParameter -= value;
        }

        public event Action<SecurityDefinitionOptionParameterEndMessage> SecurityDefinitionOptionParameterEnd
        {
            add => _clientMessageHandler.SecurityDefinitionOptionParameterEnd += value;
            remove => _clientMessageHandler.SecurityDefinitionOptionParameterEnd -= value;
        }

        public event Action<SmartComponentsMessage> SmartComponents
        {
            add => _clientMessageHandler.SmartComponents += value;
            remove => _clientMessageHandler.SmartComponents -= value;
        }

        public event Action<SoftDollarTiersMessage> SoftDollarTiers
        {
            add => _clientMessageHandler.SoftDollarTiers += value;
            remove => _clientMessageHandler.SoftDollarTiers -= value;
        }

        public event Action<SymbolSamplesMessage> SymbolSamples
        {
            add => _clientMessageHandler.SymbolSamples += value;
            remove => _clientMessageHandler.SymbolSamples -= value;
        }

        public event Action<TickByTickAllLastMessage> TickByTickAllLast
        {
            add => _clientMessageHandler.TickByTickAllLast += value;
            remove => _clientMessageHandler.TickByTickAllLast -= value;
        }

        public event Action<TickByTickBidAskMessage> TickByTickBidAsk
        {
            add => _clientMessageHandler.TickByTickBidAsk += value;
            remove => _clientMessageHandler.TickByTickBidAsk -= value;
        }

        public event Action<TickByTickMidPointMessage> TickByTickMidPoint
        {
            add => _clientMessageHandler.TickByTickMidPoint += value;
            remove => _clientMessageHandler.TickByTickMidPoint -= value;
        }

        public event Action<TickEFPMessage> TickEFP
        {
            add => _clientMessageHandler.TickEFP += value;
            remove => _clientMessageHandler.TickEFP -= value;
        }

        public event Action<TickGenericMessage> TickGeneric
        {
            add => _clientMessageHandler.TickGeneric += value;
            remove => _clientMessageHandler.TickGeneric -= value;
        }

        public event Action<TickNewsMessage> TickNews
        {
            add => _clientMessageHandler.TickNews += value;
            remove => _clientMessageHandler.TickNews -= value;
        }

        public event Action<TickOptionComputationMessage> TickOptionComputation
        {
            add => _clientMessageHandler.TickOptionComputation += value;
            remove => _clientMessageHandler.TickOptionComputation -= value;
        }

        public event Action<TickPriceMessage> TickPrice
        {
            add => _clientMessageHandler.TickPrice += value;
            remove => _clientMessageHandler.TickPrice -= value;
        }

        public event Action<TickReqParamsMessage> TickReqParams
        {
            add => _clientMessageHandler.TickReqParams += value;
            remove => _clientMessageHandler.TickReqParams -= value;
        }

        public event Action<TickSizeMessage> TickSize
        {
            add => _clientMessageHandler.TickSize += value;
            remove => _clientMessageHandler.TickSize -= value;
        }

        public event Action<TickSnapshotEndMessage> TickSnapshotEnd
        {
            add => _clientMessageHandler.TickSnapshotEnd += value;
            remove => _clientMessageHandler.TickSnapshotEnd -= value;
        }

        public event Action<TickStringMessage> TickString
        {
            add => _clientMessageHandler.TickString += value;
            remove => _clientMessageHandler.TickString -= value;
        }

        public event Action<UpdateAccountTimeMessage> UpdateAccountTime
        {
            add => _clientMessageHandler.UpdateAccountTime += value;
            remove => _clientMessageHandler.UpdateAccountTime -= value;
        }

        public event Action<UpdateAccountValueMessage> UpdateAccountValue
        {
            add => _clientMessageHandler.UpdateAccountValue += value;
            remove => _clientMessageHandler.UpdateAccountValue -= value;
        }

        public event Action<UpdateMktDepthMessage> UpdateMktDepth
        {
            add => _clientMessageHandler.UpdateMktDepth += value;
            remove => _clientMessageHandler.UpdateMktDepth -= value;
        }

        public event Action<UpdateMktDepthL2Message> UpdateMktDepthL2
        {
            add => _clientMessageHandler.UpdateMktDepthL2 += value;
            remove => _clientMessageHandler.UpdateMktDepthL2 -= value;
        }

        public event Action<UpdateNewsBulletinMessage> UpdateNewsBulletin
        {
            add => _clientMessageHandler.UpdateNewsBulletin += value;
            remove => _clientMessageHandler.UpdateNewsBulletin -= value;
        }

        public event Action<UpdatePortfolioMessage> UpdatePortfolio
        {
            add => _clientMessageHandler.UpdatePortfolio += value;
            remove => _clientMessageHandler.UpdatePortfolio -= value;
        }

        public event Action<VerifyAndAuthCompletedMessage> VerifyAndAuthCompleted
        {
            add => _clientMessageHandler.VerifyAndAuthCompleted += value;
            remove => _clientMessageHandler.VerifyAndAuthCompleted -= value;
        }

        public event Action<VerifyAndAuthMessageAPIMessage> VerifyAndAuthMessageAPI
        {
            add => _clientMessageHandler.VerifyAndAuthMessageAPI += value;
            remove => _clientMessageHandler.VerifyAndAuthMessageAPI -= value;
        }

        public event Action<VerifyCompletedMessage> VerifyCompleted
        {
            add => _clientMessageHandler.VerifyCompleted += value;
            remove => _clientMessageHandler.VerifyCompleted -= value;
        }

        public event Action<VerifyMessageAPIMessage> VerifyMessageAPI
        {
            add => _clientMessageHandler.VerifyMessageAPI += value;
            remove => _clientMessageHandler.VerifyMessageAPI -= value;
        }

        public event Action<WshEventDataMessage> WshEventData
        {
            add => _clientMessageHandler.WshEventData += value;
            remove => _clientMessageHandler.WshEventData -= value;
        }

        public event Action<WshMetaDataMessage> WshMetaData
        {
            add => _clientMessageHandler.WshMetaData += value;
            remove => _clientMessageHandler.WshMetaData -= value;
        }

        public event Action<HistoricalScheduleMessage> HistoricalSchedule
        {
            add => _clientMessageHandler.HistoricalSchedule += value;
            remove => _clientMessageHandler.HistoricalSchedule -= value;
        }

        public event Action<UserInfoMessage> UserInfo
        {
            add => _clientMessageHandler.UserInfo += value;
            remove => _clientMessageHandler.UserInfo -= value;
        }

        public event Action<ReplaceFAEndMessage> ReplaceFAEnd
        {
            add => _clientMessageHandler.ReplaceFAEnd += value;
            remove => _clientMessageHandler.ReplaceFAEnd -= value;
        }
    }
}
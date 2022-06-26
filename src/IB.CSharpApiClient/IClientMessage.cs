﻿using System;
using IB.CSharpApiClient.Messages;

namespace IB.CSharpApiClient
{
    public interface IClientMessage
    {
        event Action<AccountDownloadEndMessage> AccountDownloadEnd;
        event Action<AccountSummaryMessage> AccountSummary;
        event Action<AccountSummaryEndMessage> AccountSummaryEnd;
        event Action<AccountUpdateMultiMessage> AccountUpdateMulti;
        event Action<AccountUpdateMultiEndMessage> AccountUpdateMultiEnd;
        event Action<BondContractDetailsMessage> BondContractDetails;
        event Action<CommissionReportMessage> CommissionReport;
        event Action<CompletedOrderMessage> CompletedOrder;
        event Action CompletedOrdersEnd;
        event Action ConnectAck;
        event Action ConnectionClosed;
        event Action<ContractDetailsMessage> ContractDetails;
        event Action<ContractDetailsEndMessage> ContractDetailsEnd;
        event Action<CurrentTimeMessage> CurrentTime;
        event Action<DeltaNeutralValidationMessage> DeltaNeutralValidation;
        event Action<DisplayGroupListMessage> DisplayGroupList;
        event Action<DisplayGroupUpdatedMessage> DisplayGroupUpdated;
        event Action<ErrorMessage> Error;
        event Action<ExecDetailsMessage> ExecDetails;
        event Action<ExecDetailsEndMessage> ExecDetailsEnd;
        event Action<FamilyCodesMessage> FamilyCodes;
        event Action<FundamentalDataMessage> FundamentalData;
        event Action<HeadTimestampMessage> HeadTimestamp;
        event Action<HistogramDataMessage> HistogramData;
        event Action<HistoricalDataMessage> HistoricalData;
        event Action<HistoricalDataEndMessage> HistoricalDataEnd;
        event Action<HistoricalDataUpdateMessage> HistoricalDataUpdate;
        event Action<HistoricalNewsMessage> HistoricalNews;
        event Action<HistoricalNewsEndMessage> HistoricalNewsEnd;
        event Action<HistoricalTicksMessage> HistoricalTicks;
        event Action<HistoricalTicksBidAskMessage> HistoricalTicksBidAsk;
        event Action<HistoricalTicksLastMessage> HistoricalTicksLast;
        event Action<ManagedAccountsMessage> ManagedAccounts;
        event Action<MarketDataTypeMessage> MarketDataType;
        event Action<MarketRuleMessage> MarketRule;
        event Action<MktDepthExchangesMessage> MktDepthExchanges;
        event Action<NewsArticleMessage> NewsArticle;
        event Action<NewsProvidersMessage> NewsProviders;
        event Action<NextValidIdMessage> NextValidId;
        event Action<OpenOrderMessage> OpenOrder;
        event Action OpenOrderEnd;
        event Action<OrderBoundMessage> OrderBound;
        event Action<OrderStatusMessage> OrderStatus;
        event Action<PnLMessage> PnL;
        event Action<PnLSingleMessage> PnLSingle;
        event Action<PositionMessage> Position;
        event Action PositionEnd;
        event Action<PositionMultiMessage> PositionMulti;
        event Action<PositionMultiEndMessage> PositionMultiEnd;
        event Action<RealTimeBarMessage> RealTimeBar;
        event Action<ReceiveFAMessage> ReceiveFA;
        event Action<ReplaceFAEndMessage> ReplaceFAEnd;
        event Action<RerouteMktDataReqMessage> RerouteMktDataReq;
        event Action<RerouteMktDepthReqMessage> RerouteMktDepthReq;
        event Action<ScannerDataMessage> ScannerData;
        event Action<ScannerDataEndMessage> ScannerDataEnd;
        event Action<ScannerParametersMessage> ScannerParameters;
        event Action<SecurityDefinitionOptionParameterMessage> SecurityDefinitionOptionParameter;
        event Action<SecurityDefinitionOptionParameterEndMessage> SecurityDefinitionOptionParameterEnd;
        event Action<SmartComponentsMessage> SmartComponents;
        event Action<SoftDollarTiersMessage> SoftDollarTiers;
        event Action<SymbolSamplesMessage> SymbolSamples;
        event Action<TickByTickAllLastMessage> TickByTickAllLast;
        event Action<TickByTickBidAskMessage> TickByTickBidAsk;
        event Action<TickByTickMidPointMessage> TickByTickMidPoint;
        event Action<TickEFPMessage> TickEFP;
        event Action<TickGenericMessage> TickGeneric;
        event Action<TickNewsMessage> TickNews;
        event Action<TickOptionComputationMessage> TickOptionComputation;
        event Action<TickPriceMessage> TickPrice;
        event Action<TickReqParamsMessage> TickReqParams;
        event Action<TickSizeMessage> TickSize;
        event Action<TickSnapshotEndMessage> TickSnapshotEnd;
        event Action<TickStringMessage> TickString;
        event Action<UpdateAccountTimeMessage> UpdateAccountTime;
        event Action<UpdateAccountValueMessage> UpdateAccountValue;
        event Action<UpdateMktDepthMessage> UpdateMktDepth;
        event Action<UpdateMktDepthL2Message> UpdateMktDepthL2;
        event Action<UpdateNewsBulletinMessage> UpdateNewsBulletin;
        event Action<UpdatePortfolioMessage> UpdatePortfolio;
        event Action<VerifyAndAuthCompletedMessage> VerifyAndAuthCompleted;
        event Action<VerifyAndAuthMessageAPIMessage> VerifyAndAuthMessageAPI;
        event Action<VerifyCompletedMessage> VerifyCompleted;
        event Action<VerifyMessageAPIMessage> VerifyMessageAPI;
        event Action<WshEventDataMessage> WshEventData;
        event Action<WshMetaDataMessage> WshMetaData;
        event Action<HistoricalScheduleMessage> HistoricalSchedule;
        event Action<UserInfoMessage> UserInfo;
    }
}
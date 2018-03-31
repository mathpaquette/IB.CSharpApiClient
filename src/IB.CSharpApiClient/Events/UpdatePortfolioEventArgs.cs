using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class UpdatePortfolioEventArgs : EventArgs
    {
        public UpdatePortfolioEventArgs(Contract contract, double position, double marketPrice, double marketValue,
            double averageCost, double unrealizedPNL, double realizedPNL, string accountName)
        {
            Contract = contract;
            Position = position;
            MarketPrice = marketPrice;
            MarketValue = marketValue;
            AverageCost = averageCost;
            UnrealizedPNL = unrealizedPNL;
            RealizedPNL = realizedPNL;
            AccountName = accountName;
        }

        public Contract Contract { get; }
        public double Position { get; }
        public double MarketPrice { get; }
        public double MarketValue { get; }
        public double AverageCost { get; }
        public double UnrealizedPNL { get; }
        public double RealizedPNL { get; }
        public string AccountName { get; }

        public override string ToString()
        {
            return $"{nameof(AccountName)}: {AccountName}, {nameof(AverageCost)}: {AverageCost}, {nameof(Contract)}: {Contract}, {nameof(MarketPrice)}: {MarketPrice}, {nameof(MarketValue)}: {MarketValue}, {nameof(Position)}: {Position}, {nameof(RealizedPNL)}: {RealizedPNL}, {nameof(UnrealizedPNL)}: {UnrealizedPNL}";
        }
    }
}
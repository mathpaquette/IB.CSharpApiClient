using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class UpdatePortfolioEventArgs : EventArgs
    {
        public UpdatePortfolioEventArgs(Contract contract, double position, double marketPrice, double marketValue, double averageCost, double unrealizedPNL, double realizedPNL, string accountName)
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

        public Contract Contract { get; private set; }

        public double Position { get; private set; }

        public double MarketPrice { get; private set; }

        public double MarketValue { get; private set; }

        public double AverageCost { get; private set; }

        public double UnrealizedPNL { get; private set; }

        public double RealizedPNL { get; private set; }

        public string AccountName { get; private set; }
    }
}

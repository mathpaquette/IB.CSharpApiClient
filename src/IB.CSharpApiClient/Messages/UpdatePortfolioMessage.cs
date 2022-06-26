using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class UpdatePortfolioMessage
    {
        public Contract Contract { get; private set; }
        public decimal Position { get; private set; }
        public double MarketPrice { get; private set; }
        public double MarketValue { get; private set; }
        public double AverageCost { get; private set; }
        public double UnrealizedPNL { get; private set; }
        public double RealizedPNL { get; private set; }
        public string AccountName { get; private set; }

        public UpdatePortfolioMessage(Contract contract, decimal position, double marketPrice, double marketValue, double averageCost, double unrealizedPNL, double realizedPNL, string accountName)
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

        public override string ToString()
        {
            return $"{nameof(Contract)}: {Contract}, {nameof(Position)}: {Position}, {nameof(MarketPrice)}: {MarketPrice}, {nameof(MarketValue)}: {MarketValue}, {nameof(AverageCost)}: {AverageCost}, {nameof(UnrealizedPNL)}: {UnrealizedPNL}, {nameof(RealizedPNL)}: {RealizedPNL}, {nameof(AccountName)}: {AccountName}";
        }
    }
}

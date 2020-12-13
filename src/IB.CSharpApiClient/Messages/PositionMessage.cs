using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class PositionMessage 
    {
        public string Account { get; private set; }
        public Contract Contract { get; private set; }
        public double Position { get; private set; }
        public double AverageCost { get; private set; }

        public PositionMessage(string account, Contract contract, double pos, double avgCost)
        {
            Account = account;
            Contract = contract;
            Position = pos;
            AverageCost = avgCost;
        }

        public override string ToString()
        {
            return $"{nameof(Account)}: {Account}, {nameof(Contract)}: {Contract}, {nameof(Position)}: {Position}, {nameof(AverageCost)}: {AverageCost}";
        }
    }
}

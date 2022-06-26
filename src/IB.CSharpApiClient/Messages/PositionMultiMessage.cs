using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class PositionMultiMessage 
    {
        public int ReqId { get; private set; }
        public string Account { get; private set; }
        public string ModelCode { get; private set; }
        public Contract Contract { get; private set; }
        public decimal Position { get; private set; }
        public double AverageCost { get; private set; }

        public PositionMultiMessage(int reqId, string account, string modelCode, Contract contract, decimal pos, double avgCost)
        {
            ReqId = reqId;
            Account = account;
            ModelCode = modelCode;
            Contract = contract;
            Position = pos;
            AverageCost = avgCost;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Account)}: {Account}, {nameof(ModelCode)}: {ModelCode}, {nameof(Contract)}: {Contract}, {nameof(Position)}: {Position}, {nameof(AverageCost)}: {AverageCost}";
        }
    }
}

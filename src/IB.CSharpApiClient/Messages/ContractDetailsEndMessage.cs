namespace IB.CSharpApiClient.Messages
{
    public class ContractDetailsEndMessage
    {
        public int ReqId { get; private set; }

        public ContractDetailsEndMessage(int reqId)
        {
            ReqId = reqId;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}";
        }
    }
}

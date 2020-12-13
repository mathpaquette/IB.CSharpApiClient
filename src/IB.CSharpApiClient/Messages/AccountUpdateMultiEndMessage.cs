namespace IB.CSharpApiClient.Messages
{
    public class AccountUpdateMultiEndMessage 
    {
        public int ReqId { get; private set; }

        public AccountUpdateMultiEndMessage(int reqId)
        {
            ReqId = ReqId;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}";
        }
    }
}

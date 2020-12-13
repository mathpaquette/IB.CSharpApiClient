namespace IB.CSharpApiClient.Messages
{
    public class AccountSummaryEndMessage 
    {
        public int RequestId { get; private set; }
        
        public AccountSummaryEndMessage(int requestId)
        {
            RequestId = requestId;
        }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}";
        }
    }
}

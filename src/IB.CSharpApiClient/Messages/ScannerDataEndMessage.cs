namespace IB.CSharpApiClient.Messages
{
    public class ScannerDataEndMessage
    {
        public int RequestId { get; private set; }

        public ScannerDataEndMessage(int requestId)
        {
             RequestId = requestId;
        }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}";
        }
    }
}

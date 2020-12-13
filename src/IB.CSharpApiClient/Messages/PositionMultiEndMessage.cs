namespace IB.CSharpApiClient.Messages
{
    public class PositionMultiEndMessage 
    {
        public int ReqId { get; private set; }

        public PositionMultiEndMessage(int reqId)
        {
            ReqId = reqId;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}";
        }
    }
}

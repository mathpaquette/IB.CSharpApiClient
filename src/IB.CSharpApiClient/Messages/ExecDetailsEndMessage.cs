namespace IB.CSharpApiClient.Messages
{
    public class ExecDetailsEndMessage
    {
        public int ReqId { get; private set; }

        public ExecDetailsEndMessage(int reqId)
        {
            ReqId = reqId;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}";
        }
    }
}
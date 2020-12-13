namespace IB.CSharpApiClient.Messages
{
    public class ReplaceFAEndMessage
    {
        public int ReqId { get; private set; }
        public string Text { get; private set; }

        public ReplaceFAEndMessage(int reqId, string text)
        {
            ReqId = reqId;
            Text = text;
        }
    }
}
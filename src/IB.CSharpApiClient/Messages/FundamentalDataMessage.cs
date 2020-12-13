namespace IB.CSharpApiClient.Messages
{
    public class FundamentalDataMessage
    {
        public int ReqId { get; private set; }
        public string Data { get; private set; }

        public FundamentalDataMessage(int reqId, string data)
        {
            ReqId = reqId;
            Data = data;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Data)}: {Data}";
        }
    }
}

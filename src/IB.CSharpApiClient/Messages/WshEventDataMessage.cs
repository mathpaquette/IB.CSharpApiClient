namespace IB.CSharpApiClient.Messages
{
    public class WshEventDataMessage
    {
        public int ReqId { get; private set; }
        public string DataJson { get; private set; }

        public WshEventDataMessage(int reqId, string dataJson)
        {
            ReqId = reqId;
            DataJson = dataJson;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(DataJson)}: {DataJson}";
        }
    }
}
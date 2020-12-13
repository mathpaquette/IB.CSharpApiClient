using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class HistogramDataMessage
    {
        public int ReqId { get; private set; }
        public HistogramEntry[] Data { get; private set; }

        public HistogramDataMessage(int reqId, HistogramEntry[] data)
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

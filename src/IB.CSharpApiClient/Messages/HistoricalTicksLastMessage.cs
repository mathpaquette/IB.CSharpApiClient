using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class HistoricalTicksLastMessage
    {
        public int ReqId { get; private set; }
        public HistoricalTickLast[] Ticks { get; private set; }
        public bool Done { get; private set; }

        public HistoricalTicksLastMessage(int reqId, HistoricalTickLast[] ticks, bool done)
        {
            ReqId = reqId;
            Ticks = ticks;
            Done = done;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Ticks)}: {Ticks}, {nameof(Done)}: {Done}";
        }
    }
}

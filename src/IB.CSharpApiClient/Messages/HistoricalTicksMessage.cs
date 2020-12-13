using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class HistoricalTicksMessage
    {
        public int ReqId { get; private set; }
        public HistoricalTick[] Ticks { get; private set; }
        public bool Done { get; private set; }

        public HistoricalTicksMessage(int reqId, HistoricalTick[] ticks, bool done)
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

using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class HistoricalDataMessage
    {
        public int RequestId { get; private set; }
        public string Date { get; private set; }
        public double Open { get; private set; }
        public double High { get; private set; }
        public double Low { get; private set; }
        public double Close { get; private set; }
        public decimal Volume { get; private set; }
        public int Count { get; private set; }
        public decimal Wap { get; private set; }
        public bool HasGaps { get; private set; }

        public HistoricalDataMessage(int reqId, Bar bar)
        {
            RequestId = reqId;
            Date = bar.Time;
            Open = bar.Open;
            High = bar.High;
            Low = bar.Low;
            Close = bar.Close;
            Volume = bar.Volume;
            Count = bar.Count;
            Wap = bar.WAP;
        }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(Date)}: {Date}, {nameof(Open)}: {Open}, {nameof(High)}: {High}, {nameof(Low)}: {Low}, {nameof(Close)}: {Close}, {nameof(Volume)}: {Volume}, {nameof(Count)}: {Count}, {nameof(Wap)}: {Wap}, {nameof(HasGaps)}: {HasGaps}";
        }
    }
}

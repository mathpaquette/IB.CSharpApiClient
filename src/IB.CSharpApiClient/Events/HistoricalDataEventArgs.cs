using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalDataEventArgs : EventArgs
    {
        public HistoricalDataEventArgs(int reqId, Bar bar)
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

        public int RequestId { get; }
        public string Date { get; }
        public double Open { get; }
        public double High { get; }
        public double Low { get; }
        public double Close { get; }
        public long Volume { get; }
        public int Count { get; }
        public double Wap { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(Date)}: {Date}, {nameof(Open)}: {Open}, {nameof(High)}: {High}, {nameof(Low)}: {Low}, {nameof(Close)}: {Close}, {nameof(Volume)}: {Volume}, {nameof(Count)}: {Count}, {nameof(Wap)}: {Wap}";
        }
    }
}
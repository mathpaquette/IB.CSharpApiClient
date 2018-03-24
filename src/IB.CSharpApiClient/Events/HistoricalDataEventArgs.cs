using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalDataEventArgs : EventArgs
    {
        public int RequestId { get; private set; }

        public string Date { get; private set; }

        public double Open { get; private set; }

        public double High { get; private set; }

        public double Low { get; private set; }

        public double Close { get; private set; }

        public long Volume { get; private set; }

        public int Count { get; private set; }

        public double Wap { get; private set; }

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
    }
}

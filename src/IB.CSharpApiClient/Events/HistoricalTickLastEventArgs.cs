using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalTickLastEventArgs : EventArgs
    {
        public HistoricalTickLastEventArgs(int reqId, long time, int mask, double price, long size, string exchange, string specialConditions)
        {
            ReqId = reqId;
            Time = time;
            Mask = mask;
            Price = price;
            Size = size;
            Exchange = exchange;
            SpecialConditions = specialConditions;
        }

        public int ReqId { get; }
        public long Time { get; }
        public int Mask { get; }
        public double Price { get; }
        public long Size { get; }
        public string Exchange { get; }
        public string SpecialConditions { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Time)}: {Time}, {nameof(Mask)}: {Mask}, {nameof(Price)}: {Price}, {nameof(Size)}: {Size}, {nameof(Exchange)}: {Exchange}, {nameof(SpecialConditions)}: {SpecialConditions}";
        }
    }
}
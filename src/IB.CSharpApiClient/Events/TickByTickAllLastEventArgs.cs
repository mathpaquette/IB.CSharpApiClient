using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class TickByTickAllLastEventArgs : EventArgs
    {
        public TickByTickAllLastEventArgs(int reqId, int tickType, long time, double price, long size, TickAttrib attribs, string exchange, string specialConditions)
        {
            ReqId = reqId;
            TickType = tickType;
            Time = time;
            Price = price;
            Size = size;
            Attribs = attribs;
            Exchange = exchange;
            SpecialConditions = specialConditions;
        }

        public int ReqId { get; }
        public int TickType { get; }
        public long Time { get; }
        public double Price { get; }
        public long Size { get; }
        public TickAttrib Attribs { get; }
        public string Exchange { get; }
        public string SpecialConditions { get; }
    }
}

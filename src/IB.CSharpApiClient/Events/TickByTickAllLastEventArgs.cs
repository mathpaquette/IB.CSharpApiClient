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

        public int ReqId { get; private set; }
        public int TickType { get; private set; }
        public long Time { get; private set; }
        public double Price { get; private set; }
        public long Size { get; private set; }
        public TickAttrib Attribs { get; private set; }
        public string Exchange { get; private set; }
        public string SpecialConditions { get; private set; }
    }
}

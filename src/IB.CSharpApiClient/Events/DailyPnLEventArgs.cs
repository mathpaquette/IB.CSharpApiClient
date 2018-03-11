using System;

namespace IB.CSharpApiClient.Events
{
    public class DailyPnLEventArgs : EventArgs
    {
        public int ReqId { get; private set; }
        public double DailyPnL { get; private set; }
        public double UnrealizedPnL { get; private set; }
        public double RealizedPnL { get; private set; }

        public DailyPnLEventArgs(int reqId, double dailyPnL, double unrealizedPnL, double realizedPnL)
        {
            ReqId = reqId;
            DailyPnL = dailyPnL;
            UnrealizedPnL = unrealizedPnL;
            RealizedPnL = realizedPnL;
        }
    }
}

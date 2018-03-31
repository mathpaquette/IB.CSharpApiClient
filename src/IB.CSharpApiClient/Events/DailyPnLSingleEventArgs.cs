using System;

namespace IB.CSharpApiClient.Events
{
    public class DailyPnLSingleEventArgs : EventArgs
    {
        public DailyPnLSingleEventArgs(int reqId, int pos, double dailyPnL, double unrealizedPnL, double realizedPnL, double value)
        {
            ReqId = reqId;
            Pos = pos;
            DailyPnL = dailyPnL;
            Value = value;
            UnrealizedPnL = unrealizedPnL;
            RealizedPnL = realizedPnL;
        }

        public int ReqId { get; }
        public int Pos { get; }
        public double DailyPnL { get; }
        public double UnrealizedPnL { get; }
        public double RealizedPnL { get; }
        public double Value { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Pos)}: {Pos}, {nameof(DailyPnL)}: {DailyPnL}, {nameof(UnrealizedPnL)}: {UnrealizedPnL}, {nameof(RealizedPnL)}: {RealizedPnL}, {nameof(Value)}: {Value}";
        }
    }
}
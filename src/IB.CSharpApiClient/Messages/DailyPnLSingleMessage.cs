namespace IB.CSharpApiClient.Messages
{
    public class PnLSingleMessage
    {
        public int ReqId { get; private set; }
        public decimal Pos { get; private set; }
        public double DailyPnL { get; private set; }
        public double Value { get; private set; }
        public double UnrealizedPnL { get; private set; }
        public double RealizedPnL { get; private set; }

        public PnLSingleMessage(int reqId, decimal pos, double dailyPnL, double unrealizedPnL, double realizedPnL, double value)
        {
            ReqId = reqId;
            Pos = pos;
            DailyPnL = dailyPnL;
            Value = value;
            UnrealizedPnL = unrealizedPnL;
            RealizedPnL = realizedPnL;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Pos)}: {Pos}, {nameof(DailyPnL)}: {DailyPnL}, {nameof(Value)}: {Value}, {nameof(UnrealizedPnL)}: {UnrealizedPnL}, {nameof(RealizedPnL)}: {RealizedPnL}";
        }
    }
}

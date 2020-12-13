namespace IB.CSharpApiClient.Messages
{
    public class PnLMessage
    {
        public int ReqId { get; private set; }
        public double DailyPnL { get; private set; }
        public double UnrealizedPnL { get; private set; }
        public double RealizedPnL { get; private set; }

        public PnLMessage(int reqId, double dailyPnL, double unrealizedPnL, double realizedPnL)
        {
            ReqId = reqId;
            DailyPnL = dailyPnL;
            UnrealizedPnL = unrealizedPnL;
            RealizedPnL = realizedPnL;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(DailyPnL)}: {DailyPnL}, {nameof(UnrealizedPnL)}: {UnrealizedPnL}, {nameof(RealizedPnL)}: {RealizedPnL}";
        }
    }
}

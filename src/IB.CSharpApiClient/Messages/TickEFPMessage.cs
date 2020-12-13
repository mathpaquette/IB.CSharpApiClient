namespace IB.CSharpApiClient.Messages
{
    public class TickEFPMessage
    {
        public int TickerId { get; private set; }
        public int TickType { get; private set; }
        public double BasisPoints { get; private set; }
        public string FormattedBasisPoints { get; private set; }
        public double ImpliedFuture { get; private set; }
        public int HoldDays { get; private set; }
        public string FutureLastTradeDate { get; private set; }
        public double DividendImpact { get; private set; }
        public double DividendsToLastTradeDate { get; private set; }

        public TickEFPMessage(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture, int holdDays, string futureLastTradeDate, double dividendImpact, double dividendsToLastTradeDate)
        {
            TickerId = tickerId;
            TickType = tickType;
            BasisPoints = basisPoints;
            FormattedBasisPoints = formattedBasisPoints;
            ImpliedFuture = impliedFuture;
            HoldDays = holdDays;
            FutureLastTradeDate = futureLastTradeDate;
            DividendImpact = dividendImpact;
            DividendsToLastTradeDate = dividendsToLastTradeDate;
        }

        public override string ToString()
        {
            return $"{nameof(TickerId)}: {TickerId}, {nameof(TickType)}: {TickType}, {nameof(BasisPoints)}: {BasisPoints}, {nameof(FormattedBasisPoints)}: {FormattedBasisPoints}, {nameof(ImpliedFuture)}: {ImpliedFuture}, {nameof(HoldDays)}: {HoldDays}, {nameof(FutureLastTradeDate)}: {FutureLastTradeDate}, {nameof(DividendImpact)}: {DividendImpact}, {nameof(DividendsToLastTradeDate)}: {DividendsToLastTradeDate}";
        }
    }
}
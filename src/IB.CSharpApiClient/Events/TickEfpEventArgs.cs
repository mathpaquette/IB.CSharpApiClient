using System;

namespace IB.CSharpApiClient.Events
{
    public class TickEfpEventArgs : EventArgs
    {
        public TickEfpEventArgs(int requestId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture,
            int holdDays, string futureLastTradeDate, double dividendImpact, double dividendsToLastTradeDate)
        {
            RequestId = requestId;
            TickType = tickType;
            BasisPoints = basisPoints;
            FormattedBasisPoints = formattedBasisPoints;
            ImpliedFuture = impliedFuture;
            HoldDays = holdDays;
            FutureLastTradeDate = futureLastTradeDate;
            DividendImpact = dividendImpact;
            DividendsToLastTradeDate = dividendsToLastTradeDate;
        }

        public int RequestId { get; }
        public int TickType { get; }
        public double BasisPoints { get; }
        public string FormattedBasisPoints { get; }
        public double ImpliedFuture { get; }
        public int HoldDays { get; }
        public string FutureLastTradeDate { get; }
        public double DividendImpact { get; }
        public double DividendsToLastTradeDate { get; }

        public override string ToString()
        {
            return $"{nameof(BasisPoints)}: {BasisPoints}, {nameof(DividendImpact)}: {DividendImpact}, {nameof(DividendsToLastTradeDate)}: {DividendsToLastTradeDate}, {nameof(FormattedBasisPoints)}: {FormattedBasisPoints}, {nameof(FutureLastTradeDate)}: {FutureLastTradeDate}, {nameof(HoldDays)}: {HoldDays}, {nameof(ImpliedFuture)}: {ImpliedFuture}, {nameof(RequestId)}: {RequestId}, {nameof(TickType)}: {TickType}";
        }
    }
}
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

        public int RequestId { get; private set; }
        public int TickType { get; private set; }
        public double BasisPoints { get; private set; }
        public string FormattedBasisPoints { get; private set; }
        public double ImpliedFuture { get; private set; }
        public int HoldDays { get; private set; }
        public string FutureLastTradeDate { get; private set; }
        public double DividendImpact { get; private set; }
        public double DividendsToLastTradeDate { get; private set; }
    }
}
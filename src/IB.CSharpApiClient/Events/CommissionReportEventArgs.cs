using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class CommissionReportEventArgs : EventArgs
    {
        public CommissionReportEventArgs(CommissionReport commissionReport)
        {
            CommissionReport = commissionReport;
        }

        public CommissionReport CommissionReport { get; }

        public override string ToString()
        {
            return $"{nameof(CommissionReport)}: {CommissionReport}";
        }
    }
}
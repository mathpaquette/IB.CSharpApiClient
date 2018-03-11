using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class CommissionReportEventArgs : EventArgs
    {
        public CommissionReport CommissionReport { get; set; }

        public CommissionReportEventArgs(CommissionReport commissionReport)
        {
            CommissionReport = commissionReport;
        }
    }
}

using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class CommissionReportMessage
    {
        public CommissionReport CommissionReport { get; private set; }

        public CommissionReportMessage(CommissionReport commissionReport)
        {
            CommissionReport = commissionReport;
        }

        public override string ToString()
        {
            return $"{nameof(CommissionReport)}: {CommissionReport}";
        }
    }
}
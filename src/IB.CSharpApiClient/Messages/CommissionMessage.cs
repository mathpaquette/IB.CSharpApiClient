using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class CommissionMessage
    {
        public CommissionReport CommissionReport { get; private set; }

        public CommissionMessage(CommissionReport commissionReport)
        {
            CommissionReport = commissionReport;
        }

        public override string ToString()
        {
            return $"{nameof(CommissionReport)}: {CommissionReport}";
        }
    }
}

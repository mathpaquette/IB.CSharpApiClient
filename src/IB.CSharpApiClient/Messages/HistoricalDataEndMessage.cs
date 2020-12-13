namespace IB.CSharpApiClient.Messages
{
    public class HistoricalDataEndMessage
    {
        public string StartDate { get; private set; }
        public int RequestId { get; private set; }
        public string EndDate { get; private set; }

        public HistoricalDataEndMessage(int requestId, string startDate, string endDate)
        {
            RequestId = requestId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return $"{nameof(StartDate)}: {StartDate}, {nameof(RequestId)}: {RequestId}, {nameof(EndDate)}: {EndDate}";
        }
    }
}

using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalDataEndEventArgs : EventArgs
    {
        public string StartDate { get; private set; }

        public int RequestId { get; private set; }

        public string EndDate { get; private set; }

        public HistoricalDataEndEventArgs(int requestId, string startDate, string endDate)
        {
            RequestId = requestId;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}

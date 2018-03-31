using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalDataEndEventArgs : EventArgs
    {
        public HistoricalDataEndEventArgs(int requestId, string startDate, string endDate)
        {
            RequestId = requestId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int RequestId { get; }
        public string StartDate { get; }
        public string EndDate { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(StartDate)}: {StartDate}, {nameof(EndDate)}: {EndDate}";
        }
    }
}
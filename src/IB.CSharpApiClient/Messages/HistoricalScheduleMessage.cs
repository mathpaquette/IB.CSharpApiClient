using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class HistoricalScheduleMessage
    {
        public int ReqId { get; private set; }
        public string StartDateTime { get; private set; }
        public string EndDateTime { get; private set; }
        public string TimeZone { get; private set; }
        public HistoricalSession[] Sessions { get; private set; }

        public HistoricalScheduleMessage(int reqId, string startDateTime, string endDateTime, string timeZone, HistoricalSession[] sessions)
        {
            ReqId = reqId;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            TimeZone = timeZone;
            Sessions = sessions;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(StartDateTime)}: {StartDateTime}, {nameof(EndDateTime)}: {EndDateTime}, {nameof(TimeZone)}: {TimeZone}, {nameof(Sessions)}: {Sessions}";
        }
    }
}
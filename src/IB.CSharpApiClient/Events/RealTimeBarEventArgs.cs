using System;

namespace IB.CSharpApiClient.Events
{
    public class RealTimeBarEventArgs : HistoricalDataEventArgs
    {
        private long timestamp;
        private long longVolume;

        public long LongVolume
        {
            get { return longVolume; }
            set { longVolume = value; }
        }

        public long Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }

        public RealTimeBarEventArgs(int reqId, long date, double open, double high, double low, double close, long volume, double WAP, int count)
            : base(reqId, new IBApi.Bar(UnixTimestampToDateTime(date).ToString("yyyyMMdd hh:mm:ss"), open, high, low, close, -1, count, WAP))
        {
            Timestamp = date;
            LongVolume = volume;
        }

        static DateTime UnixTimestampToDateTime(long unixTimestamp)
        {
            DateTime unixBaseTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return unixBaseTime.AddSeconds(unixTimestamp);
        }
    }
}

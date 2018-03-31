using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class RealTimeBarEventArgs : HistoricalDataEventArgs
    {
        public RealTimeBarEventArgs(int reqId, long date, double open, double high, double low, double close, long volume, double WAP, int count)
            : base(reqId, new Bar(UnixTimestampToDateTime(date).ToString("yyyyMMdd hh:mm:ss"), open, high, low, close, -1, count, WAP))
        {
            Timestamp = date;
            LongVolume = volume;
        }

        public long Timestamp { get; }
        public long LongVolume { get; }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(LongVolume)}: {LongVolume}, {nameof(Timestamp)}: {Timestamp}";
        }

        private static DateTime UnixTimestampToDateTime(long unixTimestamp)
        {
            var unixBaseTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return unixBaseTime.AddSeconds(unixTimestamp);
        }
    }
}
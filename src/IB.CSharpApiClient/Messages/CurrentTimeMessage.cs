namespace IB.CSharpApiClient.Messages
{
    public class CurrentTimeMessage
    {
        public long Time { get; private set; }

        public CurrentTimeMessage(long time)
        {
            Time = time;
        }

        public override string ToString()
        {
            return $"{nameof(Time)}: {Time}";
        }
    }
}
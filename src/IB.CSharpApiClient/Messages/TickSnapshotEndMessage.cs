namespace IB.CSharpApiClient.Messages
{
    public class TickSnapshotEndMessage
    {
        public int TickerId { get; private set; }

        public TickSnapshotEndMessage(int tickerId)
        {
            TickerId = tickerId;
        }

        public override string ToString()
        {
            return $"{nameof(TickerId)}: {TickerId}";
        }
    }
}
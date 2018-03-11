namespace IB.CSharpApiClient.Example.Domain.ValueObject
{
    public class TickSize
    {
        public int TickId { get; }
        public int Size { get; }

        public TickSize(int tickId, int size)
        {
            TickId = tickId;
            Size = size;
        }
    }
}
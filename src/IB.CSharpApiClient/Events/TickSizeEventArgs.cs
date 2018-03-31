namespace IB.CSharpApiClient.Events
{
    public class TickSizeEventArgs : MarketDataEventArgs
    {
        public TickSizeEventArgs(int requestId, int field, int size) 
            : base(requestId, field)
        {
            Size = size;
        }

        public int Size { get; }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Size)}: {Size}";
        }
    }
}
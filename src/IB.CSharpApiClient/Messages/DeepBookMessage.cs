namespace IB.CSharpApiClient.Messages
{
    public class DeepBookMessage
    {
        public int RequestId { get; private set; }
        public int Position { get; private set; }
        public int Operation { get; private set; }
        public int Side { get; private set; }
        public double Price { get; private set; }
        public int Size { get; private set; }
        public string MarketMaker { get; private set; }
        public bool IsSmartDepth { get; private set; }

        public DeepBookMessage(int tickerId, int position, int operation, int side, double price, int size, string marketMaker, bool isSmartDepth)
        {
            RequestId = tickerId;
            Position = position;
            Operation = operation;
            Side = side;
            Price = price;
            Size = size;
            MarketMaker = marketMaker;
            IsSmartDepth = isSmartDepth;
        }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(Position)}: {Position}, {nameof(Operation)}: {Operation}, {nameof(Side)}: {Side}, {nameof(Price)}: {Price}, {nameof(Size)}: {Size}, {nameof(MarketMaker)}: {MarketMaker}, {nameof(IsSmartDepth)}: {IsSmartDepth}";
        }
    }
}

namespace IB.CSharpApiClient.Messages
{
    public class UpdateMktDepthL2Message
    {
        public int TickerId { get; private set; }
        public int Position { get; private set; }
        public string MarketMaker { get; private set; }
        public int Operation { get; private set; }
        public int Side { get; private set; }
        public double Price { get; private set; }
        public decimal Size { get; private set; }
        public bool IsSmartDepth { get; private set; }

        public UpdateMktDepthL2Message(int tickerId, int position, string marketMaker, int operation, int side, double price, decimal size, bool isSmartDepth)
        {
            TickerId = tickerId;
            Position = position;
            MarketMaker = marketMaker;
            Operation = operation;
            Side = side;
            Price = price;
            Size = size;
            IsSmartDepth = isSmartDepth;
        }

        public override string ToString()
        {
            return $"{nameof(TickerId)}: {TickerId}, {nameof(Position)}: {Position}, {nameof(MarketMaker)}: {MarketMaker}, {nameof(Operation)}: {Operation}, {nameof(Side)}: {Side}, {nameof(Price)}: {Price}, {nameof(Size)}: {Size}, {nameof(IsSmartDepth)}: {IsSmartDepth}";
        }
    }
}
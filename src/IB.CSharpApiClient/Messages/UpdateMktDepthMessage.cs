namespace IB.CSharpApiClient.Messages
{
    public class UpdateMktDepthMessage
    {
        public int TickerId { get; private set; }
        public int Position { get; private set; }
        public int Operation { get; private set; }
        public int Side { get; private set; }
        public double Price { get; private set; }
        public decimal Size { get; private set; }

        public UpdateMktDepthMessage(int tickerId, int position, int operation, int side, double price, decimal size)
        {
            TickerId = tickerId;
            Position = position;
            Operation = operation;
            Side = side;
            Price = price;
            Size = size;
        }

        public override string ToString()
        {
            return $"{nameof(TickerId)}: {TickerId}, {nameof(Position)}: {Position}, {nameof(Operation)}: {Operation}, {nameof(Side)}: {Side}, {nameof(Price)}: {Price}, {nameof(Size)}: {Size}";
        }
    }
}
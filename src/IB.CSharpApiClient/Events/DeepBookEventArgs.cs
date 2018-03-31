using System;

namespace IB.CSharpApiClient.Events
{
    public class DeepBookEventArgs : EventArgs
    {
        public DeepBookEventArgs(int tickerId, int position, int operation, int side, double price, int size, string marketMaker)
        {
            RequestId = tickerId;
            Position = position;
            Operation = operation;
            Side = side;
            Price = price;
            Size = size;
            MarketMaker = marketMaker;
        }

        public int RequestId { get; }
        public int Position { get; }
        public int Operation { get; }
        public int Side { get; }
        public double Price { get; }
        public int Size { get; }
        public string MarketMaker { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(Position)}: {Position}, {nameof(Operation)}: {Operation}, {nameof(Side)}: {Side}, {nameof(Price)}: {Price}, {nameof(Size)}: {Size}, {nameof(MarketMaker)}: {MarketMaker}";
        }
    }
}
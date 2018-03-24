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

        public int RequestId { get; private set; }

        public int Position { get; private set; }

        public int Operation { get; private set; }

        public int Side { get; private set; }

        public double Price { get; private set; }

        public int Size { get; private set; }

        public string MarketMaker { get; private set; }
    }
}

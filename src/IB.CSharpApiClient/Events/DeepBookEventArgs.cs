using System;

namespace IB.CSharpApiClient.Events
{
    public class DeepBookEventArgs : EventArgs
    {
        private int requestId;
        private int position;
        private int operation;
        private int side;
        private double price;
        private int size;
        private string marketMaker;

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

        public int RequestId
        {
            get { return requestId; }
            set { requestId = value; }
        }
        
        public int Position
        {
            get { return position; }
            set { position = value; }
        }
        
        public int Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        public int Side
        {
            get { return side; }
            set { side = value; }
        }
       
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public string MarketMaker
        {
            get { return marketMaker; }
            set { marketMaker = value; }
        }
        
    }
}

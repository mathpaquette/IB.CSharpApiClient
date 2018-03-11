using System;
using IBApi;

namespace IB.CSharpApiClient.Example.Domain.ValueObject
{
    public class Level1MarketData : EventArgs
    {
        public int BidSize { get; private set; }
        public double Bid { get; private set; }
        public int AskSize { get; private set; }
        public double Ask { get; private set; }

        public int LastSize { get; private set; }
        public double Last { get; private set; }

        public double Open { get; private set; }
        public double High { get; private set; }
        public double Low { get; private set; }
        public double Close { get; private set; }

        public int Volume { get; private set; }

        public Level1MarketData()
        {
            BidSize = AskSize = LastSize = Volume = -1;
            Bid = Ask = Open = High = Low = Close = -1;
        }

        public Level1MarketData ShallowCopy()
        {
            return (Level1MarketData)this.MemberwiseClone();
        }

        public void UpdateValues(int field, double price)
        {
            switch (field)
            {
                case TickType.BID:
                    Bid = price;
                    break;
                case TickType.ASK:
                    Ask = price;
                    break;
                case TickType.LAST:
                    Last = price;
                    break;
                case TickType.OPEN:
                    Open = price;
                    break;
                case TickType.HIGH:
                    High = price;
                    break;
                case TickType.LOW:
                    Low = price;
                    break;
                case TickType.CLOSE:
                    Close = price;
                    break;
            }
        }

        public void UpdateValues(int field, int size)
        {
            switch (field)
            {
                case TickType.BID_SIZE:
                    BidSize = size;
                    break;
                case TickType.ASK_SIZE:
                    AskSize = size;
                    break;
                case TickType.LAST_SIZE:
                    LastSize = size;
                    break;
                case TickType.VOLUME:
                    Volume = size;
                    break;
            }
        }

        public override string ToString()
        {
            return $"{nameof(BidSize)}: {BidSize}, {nameof(Bid)}: {Bid}, {nameof(AskSize)}: {AskSize}, {nameof(Ask)}: {Ask}, {nameof(LastSize)}: {LastSize}, {nameof(Last)}: {Last}, {nameof(Open)}: {Open}, {nameof(High)}: {High}, {nameof(Low)}: {Low}, {nameof(Close)}: {Close}, {nameof(Volume)}: {Volume}";
        }
    }
}
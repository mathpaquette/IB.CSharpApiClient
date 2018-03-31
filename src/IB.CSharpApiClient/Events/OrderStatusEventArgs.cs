namespace IB.CSharpApiClient.Events
{
    public class OrderStatusEventArgs : OrderEventArgs
    {
        public OrderStatusEventArgs(int orderId, string status, double filled, double remaining, double avgFillPrice,
            int permId, int parentId, double lastFillPrice, int clientId, string whyHeld, double mktCapPrice)
            : base(orderId)
        {
            Status = status;
            Filled = filled;
            Remaining = remaining;
            AvgFillPrice = avgFillPrice;
            PermId = permId;
            ParentId = parentId;
            LastFillPrice = lastFillPrice;
            ClientId = clientId;
            WhyHeld = whyHeld;
            MktCapPrice = mktCapPrice;
        }

        public string Status { get; }
        public double Filled { get; }
        public double Remaining { get; }
        public double AvgFillPrice { get; }
        public int PermId { get; }
        public int ParentId { get; }
        public double LastFillPrice { get; }
        public int ClientId { get; }
        public string WhyHeld { get; }
        public double MktCapPrice { get; }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(AvgFillPrice)}: {AvgFillPrice}, {nameof(ClientId)}: {ClientId}, {nameof(Filled)}: {Filled}, {nameof(LastFillPrice)}: {LastFillPrice}, {nameof(MktCapPrice)}: {MktCapPrice}, {nameof(ParentId)}: {ParentId}, {nameof(PermId)}: {PermId}, {nameof(Remaining)}: {Remaining}, {nameof(Status)}: {Status}, {nameof(WhyHeld)}: {WhyHeld}";
        }
    }
}
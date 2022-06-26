namespace IB.CSharpApiClient.Messages
{
    public class OrderStatusMessage : OrderMessage
    {
        public string Status { get; private set; }
        public decimal Filled { get; private set; }
        public decimal Remaining { get; private set; }
        public double AvgFillPrice { get; private set; }
        public int PermId { get; private set; }
        public int ParentId { get; private set; }
        public double LastFillPrice { get; private set; }
        public int ClientId { get; private set; }
        public string WhyHeld { get; private set; }
        public double MktCapPrice { get; private set; }

        public OrderStatusMessage(int orderId, string status, decimal filled, decimal remaining, double avgFillPrice,
           int permId, int parentId, double lastFillPrice, int clientId, string whyHeld, double mktCapPrice)
        {
            OrderId = orderId;
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

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Status)}: {Status}, {nameof(Filled)}: {Filled}, {nameof(Remaining)}: {Remaining}, {nameof(AvgFillPrice)}: {AvgFillPrice}, {nameof(PermId)}: {PermId}, {nameof(ParentId)}: {ParentId}, {nameof(LastFillPrice)}: {LastFillPrice}, {nameof(ClientId)}: {ClientId}, {nameof(WhyHeld)}: {WhyHeld}, {nameof(MktCapPrice)}: {MktCapPrice}";
        }
    }
}

namespace IB.CSharpApiClient.Messages
{
    public abstract class OrderMessage
    {
        public int OrderId { get; protected set; }

        public override string ToString()
        {
            return $"{nameof(OrderId)}: {OrderId}";
        }
    }
}

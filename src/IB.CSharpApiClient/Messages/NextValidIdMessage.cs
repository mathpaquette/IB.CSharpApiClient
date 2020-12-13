namespace IB.CSharpApiClient.Messages
{
    public class NextValidIdMessage
    {
        public int OrderId { get; private set; }

        public NextValidIdMessage(int orderId)
        {
            OrderId = orderId;
        }

        public override string ToString()
        {
            return $"{nameof(OrderId)}: {OrderId}";
        }
    }
}
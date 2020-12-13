namespace IB.CSharpApiClient.Messages
{
    public class OrderBoundMessage
    {
        public long OrderId { get; private set; }
        public int ApiClientId { get; private set; }
        public int ApiOrderId { get; private set; }

        public OrderBoundMessage(long orderId, int apiClientId, int apiOrderId)
        {
            OrderId = orderId;
            ApiClientId = apiClientId;
            ApiOrderId = apiOrderId;
        }

        public override string ToString()
        {
            return $"{nameof(OrderId)}: {OrderId}, {nameof(ApiClientId)}: {ApiClientId}, {nameof(ApiOrderId)}: {ApiOrderId}";
        }
    }
}

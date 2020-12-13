using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class OpenOrderMessage : OrderMessage
    {
        public Contract Contract { get; private set; }
        public Order Order { get; private set; }
        public OrderState OrderState { get; private set; }

        public OpenOrderMessage(int orderId, Contract contract, Order order, OrderState orderState)
        {
            OrderId = orderId;
            Contract = contract;
            Order = order;
            OrderState = orderState;
        }

        public override string ToString()
        {
            return $"{nameof(Contract)}: {Contract}, {nameof(Order)}: {Order}, {nameof(OrderState)}: {OrderState}";
        }
    }
}

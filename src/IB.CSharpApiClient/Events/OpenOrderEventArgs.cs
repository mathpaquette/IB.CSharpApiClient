using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class OpenOrderEventArgs : OrderEventArgs
    {
        public OpenOrderEventArgs(int orderId, Contract contract, Order order, OrderState orderState): 
            base(orderId)
        {
            Contract = contract;
            Order = order;
            OrderState = orderState;
        }
        
        public Contract Contract { get; private set; }

        public Order Order { get; private set; }

        public OrderState OrderState { get; private set; }
    }
}

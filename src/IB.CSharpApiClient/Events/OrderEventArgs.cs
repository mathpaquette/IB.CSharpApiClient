using System;

namespace IB.CSharpApiClient.Events
{
    public abstract class OrderEventArgs : EventArgs
    {
        protected OrderEventArgs(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; }

        public override string ToString()
        {
            return $"{nameof(OrderId)}: {OrderId}";
        }
    }
}
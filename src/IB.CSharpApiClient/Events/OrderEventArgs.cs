using System;

namespace IB.CSharpApiClient.Events
{
    public abstract class OrderEventArgs : EventArgs
    {
        public int OrderId { get; private set; }

        protected OrderEventArgs(int orderId)
        {
            OrderId = orderId;
        }
    }
}

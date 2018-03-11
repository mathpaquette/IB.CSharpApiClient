/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class OpenOrderEventArgs : OrderEventArgs
    {
        private Contract contract;
        private Order order;
        private OrderState orderState;

        public OpenOrderEventArgs(int orderId, Contract contract, Order order, OrderState orderState)
        {
            OrderId = orderId;
            Contract = contract;
            Order = order;
            OrderState = orderState;
        }
        
        public Contract Contract
        {
            get { return contract; }
            set { contract = value; }
        }
        
        public Order Order
        {
            get { return order; }
            set { order = value; }
        }
        
        public OrderState OrderState
        {
            get { return orderState; }
            set { orderState = value; }
        }
        
    }
}

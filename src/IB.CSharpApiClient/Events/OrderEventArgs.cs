/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace IB.CSharpApiClient.Events
{
    public abstract class OrderEventArgs : EventArgs
    {
        protected int orderId;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
    }
}

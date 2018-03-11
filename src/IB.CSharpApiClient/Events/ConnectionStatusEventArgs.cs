using System;

namespace IB.CSharpApiClient.Events
{
    public class ConnectionStatusEventArgs : EventArgs
    {
        public bool IsConnected { get; }
        public int NextValidOrderId { get; }

        public ConnectionStatusEventArgs(bool isConnected, int orderId)
        {
            IsConnected = isConnected;
            NextValidOrderId = orderId;
        }
    }
}

using System;

namespace IB.CSharpApiClient.Events
{
    public class ConnectionStatusEventArgs : EventArgs
    {
        public ConnectionStatusEventArgs(bool isConnected, int orderId)
        {
            IsConnected = isConnected;
            NextValidOrderId = orderId;
        }

        public bool IsConnected { get; }
        public int NextValidOrderId { get; }

        public override string ToString()
        {
            return $"{nameof(IsConnected)}: {IsConnected}, {nameof(NextValidOrderId)}: {NextValidOrderId}";
        }
    }
}
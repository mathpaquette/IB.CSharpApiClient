namespace IB.CSharpApiClient.Messages
{
    public class ConnectionStatusMessage
    {
        public bool IsConnected { get; private set; }

        public ConnectionStatusMessage(bool isConnected)
        {
            IsConnected = isConnected;
        }

        public override string ToString()
        {
            return $"{nameof(IsConnected)}: {IsConnected}";
        }
    }
}

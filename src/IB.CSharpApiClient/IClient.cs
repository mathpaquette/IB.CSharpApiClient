namespace IB.CSharpApiClient
{
    public interface IClient
    {
        void Connect(string host, int port, int clientId);
        void Connect(string host, int port, int clientId, bool extraAuth);
        void Disconnect();
        void Disconnect(bool resetState);
    }
}
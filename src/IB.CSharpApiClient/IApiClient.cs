using System.Threading.Tasks;

namespace IB.CSharpApiClient
{
    public interface IApiClient
    {
        void Connect(string host, int port, int clientId);
        Task ConnectAsync(string host, int port, int clientId);
        void Disconnect();
    }
}
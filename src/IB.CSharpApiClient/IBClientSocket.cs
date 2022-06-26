using IBApi;

namespace IB.CSharpApiClient
{
    public class IBClientSocket : EClientSocket, IEClientSocket
    {
        public IBClientSocket(EWrapper wrapper, EReaderSignal eReaderSignal) : base(wrapper, eReaderSignal)
        {
        }
    }
}
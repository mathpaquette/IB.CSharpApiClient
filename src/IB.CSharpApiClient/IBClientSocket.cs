using IBApi;

namespace IB.CSharpApiClient
{
    public class IBClientSocket : EClientSocket, IEClientSocket
    {
        public IBClientSocket(EWrapper wrapper, EReaderSignal eReaderSignal) : base(wrapper, eReaderSignal)
        {
        }

        public void exerciseOptions(int tickerId, Contract contract, int exerciseAction, int exerciseQuantity, string account, int ovrd)
        {
            throw new System.Exception("Not implemented");
        }
    }
}

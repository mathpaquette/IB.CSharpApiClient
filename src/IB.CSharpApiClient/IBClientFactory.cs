using System;
using System.Threading;
using IBApi;

namespace IB.CSharpApiClient
{
    public static class IBClientFactory
    {
        public static IBClient CreateNew()
        {
            return CreateNew(TimeSpan.FromSeconds(5));
        }

        public static IBClient CreateNew(TimeSpan timeout)
        {
            var signal = new EReaderMonitorSignal();
            var messageHandler = new ClientMessageHandler();
            var clientSocket = new IBClientSocket(messageHandler, signal);
            var manualResetEventSlim = new ManualResetEventSlim();

            return new IBClient(signal, clientSocket, messageHandler, manualResetEventSlim, timeout);
        }
    }
}

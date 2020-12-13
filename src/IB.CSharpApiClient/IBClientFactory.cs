using System;
using System.Threading;
using IBApi;

namespace IB.CSharpApiClient
{
    public static class IBClientFactory
    {
        public static IBClient CreateNew()
        {
            return CreateNew(IBClientDefault.Timeout);
        }

        public static IBClient CreateNew(int timeoutMs)
        {
            return CreateNew(TimeSpan.FromMilliseconds(timeoutMs));
        }

        public static IBClient CreateNew(TimeSpan timeout)
        {
            var signal = new EReaderMonitorSignal();
            var messageHandler = new MessageHandler();
            var clientSocket = new EClientSocket(messageHandler, signal);
            var clientCommandAsync = new ClientCommandAsync(clientSocket, messageHandler, timeout);
            var manualResetEventSlim = new ManualResetEventSlim();

            return new IBClient(signal, clientSocket, clientCommandAsync, messageHandler, manualResetEventSlim);
        }
    }
}

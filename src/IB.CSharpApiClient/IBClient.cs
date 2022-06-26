using System;
using System.Threading;
using IB.CSharpApiClient.Messages;
using IBApi;

namespace IB.CSharpApiClient
{
    public partial class IBClient : IClient
    {
        private readonly EReaderSignal _readerSignal;
        private readonly IEClientSocket _clientSocket;

        private readonly IClientMessageHandler _clientMessageHandler;
        private readonly ManualResetEventSlim _manualResetEventSlim;
        private readonly TimeSpan _timeout;

        public IBClient(
            EReaderSignal readerSignal,
            IEClientSocket clientSocket,
            IClientMessageHandler clientMessageHandler,
            ManualResetEventSlim manualResetEventSlim,
            TimeSpan timeout)
        {
            _readerSignal = readerSignal;
            _clientSocket = clientSocket;
            _clientMessageHandler = clientMessageHandler;
            _manualResetEventSlim = manualResetEventSlim;
            _timeout = timeout;
        }

        public void Connect(string host, int port, int clientId)
        {
            if (IsConnected())
                return;

            _clientSocket.eConnect(host, port, clientId);
            WaitForServerConnected();
        }

        public void Connect(string host, int port, int clientId, bool extraAuth)
        {
            if (IsConnected())
                return;

            _clientSocket.eConnect(host, port, clientId, extraAuth);
            WaitForServerConnected();
        }

        public void Disconnect()
        {
            if (!IsConnected())
                return;

            _clientSocket.eDisconnect();
        }

        public void Disconnect(bool resetState)
        {
            if (!IsConnected())
                return;

            _clientSocket.eDisconnect(resetState);
        }

        private void CreateReaderThread()
        {
            try
            {
                var reader = new EReader(_clientSocket as EClientSocket, _readerSignal);
                reader.Start();

                new Thread(() =>
                    {
                        while (_clientSocket.IsConnected())
                        {
                            _readerSignal.waitForSignal();
                            reader.processMsgs();
                        }
                    })
                { IsBackground = true }.Start();
            }
            catch (Exception)
            {
                _clientMessageHandler.error(-1, -1, "Please check your connection attributes.", "");
            }
        }

        private void WaitForServerConnected()
        {
            _manualResetEventSlim.Reset();
            _clientMessageHandler.NextValidId += MessageHandlerOnNextValidId;

            CreateReaderThread();

            _manualResetEventSlim.Wait();
            _clientMessageHandler.NextValidId -= MessageHandlerOnNextValidId;

            void MessageHandlerOnNextValidId(NextValidIdMessage obj)
            {
                _manualResetEventSlim.Set();
            }
        }
    }
}

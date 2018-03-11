using System;
using System.Threading;
using System.Threading.Tasks;
using IB.CSharpApiClient.Events;
using IBApi;

namespace IB.CSharpApiClient
{
    public abstract class ApiClient : IApiClient
    {
        private readonly EReaderMonitorSignal _readerMonitorSignal;

        protected readonly IApiEvent EventDispatcher;
        protected readonly EClientSocket ClientSocket;
        protected const int DefaultTimeoutMs = 30000;

        private volatile int _nextValidOrderId = 0;

        protected int NextValidOrderId
        {
            get => _nextValidOrderId;
            set => _nextValidOrderId = value;
        }

        protected ApiClient()
        {
            var eventDispatcher = new ApiEventDispatcher();
            _readerMonitorSignal = new EReaderMonitorSignal();
            ClientSocket = new EClientSocket(eventDispatcher, _readerMonitorSignal);

            EventDispatcher = eventDispatcher;
            EventDispatcher.ConnectAck += EventDispatcherOnConnectAck;
            EventDispatcher.ConnectionStatus += EventDispatcherOnConnectionStatus;
        }

        public void Connect(string host, int port, int clientId)
        {
            try
            {
                ClientSocket.eConnect(host, port, clientId);

                var reader = new EReader(ClientSocket, _readerMonitorSignal);

                reader.Start();

                new Thread(() =>
                {
                    while (ClientSocket.IsConnected())
                    {
                        _readerMonitorSignal.waitForSignal();
                        reader.processMsgs();
                    }
                })
                { IsBackground = true }.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Task ConnectAsync(string host, int port, int clientId)
        {
            var ct = new CancellationTokenSource(DefaultTimeoutMs);
            var res = new TaskCompletionSource<object>();
            ct.Token.Register(() => res.TrySetCanceled(), useSynchronizationContext: false);

            EventHandler connectAck = (sender, args) =>
            {
                res.SetResult(new object());
            };

            EventDispatcher.ConnectAck += connectAck;

            Connect(host, port, clientId);

            res.Task.ContinueWith(x =>
            {
                EventDispatcher.ConnectAck -= connectAck;

            }, TaskContinuationOptions.None);

            return res.Task;
        }

        public void Disconnect()
        {
            try
            {
                ClientSocket.eDisconnect();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void EventDispatcherOnConnectAck(object sender, EventArgs eventArgs)
        {
            if (ClientSocket.AsyncEConnect)
                ClientSocket.startApi();
        }

        private void EventDispatcherOnConnectionStatus(object sender, ConnectionStatusEventArgs connectionStatusEventArgs)
        {
            _nextValidOrderId = connectionStatusEventArgs.NextValidOrderId;
        }
    }
}
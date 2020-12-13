using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using IB.CSharpApiClient.Messages;
using IBApi;

namespace IB.CSharpApiClient
{
    public class ClientCommandAsync : IClientCommandAsync
    {
        private readonly EClientSocket _clientSocket;
        private readonly IClientMessage _clientMessage;
        private readonly TimeSpan _timeout;

        public ClientCommandAsync(EClientSocket clientSocket, IClientMessage clientMessage, TimeSpan timeout)
        {
            _timeout = timeout;
            _clientSocket = clientSocket;
            _clientMessage = clientMessage;
        }

        public Task<IEnumerable<ScannerDataMessage>> GetScannerDataAsync(ScannerSubscription subscription, List<TagValue> scannerSubscriptionOptions, List<TagValue> scannerSubscriptionFilterOptions)
        {
            var reqId = GetUniqueRequestId();
            var reqScannerSubscription = new Action(() => _clientSocket.reqScannerSubscription(reqId, subscription, scannerSubscriptionOptions, scannerSubscriptionFilterOptions));
            return GetScannerDataAsync(reqId, reqScannerSubscription);
        }

        public Task<IEnumerable<ScannerDataMessage>> GetScannerDataAsync(ScannerSubscription subscription, string scannerSubscriptionOptions, string scannerSubscriptionFilterOptions)
        {
            var reqId = GetUniqueRequestId();
            var reqScannerSubscription = new Action(() => _clientSocket.reqScannerSubscription(reqId, subscription, scannerSubscriptionOptions, scannerSubscriptionFilterOptions));
            return GetScannerDataAsync(reqId, reqScannerSubscription);
        }

        private async Task<IEnumerable<ScannerDataMessage>> GetScannerDataAsync(int reqId, Action reqScannerSubscription)
        {
            var messages = new List<ScannerDataMessage>();
            var ct = new CancellationTokenSource(_timeout);
            var res = new TaskCompletionSource<IEnumerable<ScannerDataMessage>>();

            ct.Token.Register(() =>
            {
                res.TrySetCanceled();
            }, false);


            void OnScannerData(ScannerDataMessage msg)
            {
                if (msg.RequestId != reqId)
                    return;

                messages.Add(msg);
            }

            void OnScannerDataEnd(ScannerDataEndMessage msg)
            {
                if (msg.RequestId != reqId)
                    return;

                res.TrySetResult(messages);
            }

            _clientMessage.ScannerData += OnScannerData;
            _clientMessage.ScannerDataEnd += OnScannerDataEnd;

            reqScannerSubscription();

            await res.Task.ContinueWith(x =>
            {
                _clientSocket.cancelScannerSubscription(reqId);
                _clientMessage.ScannerData -= OnScannerData;
                _clientMessage.ScannerDataEnd -= OnScannerDataEnd;
                ct.Dispose();
            }, TaskContinuationOptions.None).ConfigureAwait(false);

            return await res.Task.ConfigureAwait(false);
        }

        private int GetUniqueRequestId()
        {
            return new Random(DateTime.Now.Millisecond).Next();
        }
    }
}
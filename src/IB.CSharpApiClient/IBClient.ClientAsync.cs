using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using IB.CSharpApiClient.Messages;
using IBApi;

namespace IB.CSharpApiClient
{
    public partial class IBClient : IClientAsync
    {
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
            var data = new List<ScannerDataMessage>();
            var ct = new CancellationTokenSource(_timeout);
            var res = new TaskCompletionSource<IEnumerable<ScannerDataMessage>>();

            ct.Token.Register(() =>
            {
                res.TrySetCanceled();
            }, false);

            void OnError(ErrorMessage msg)
            {
                if (msg.RequestId == reqId)
                    res.SetException(new IBClientException(msg.RequestId, msg.ErrorCode, msg.Message, msg.AdvancedOrderRejectJson));
            }

            void OnScannerData(ScannerDataMessage msg)
            {
                if (msg.RequestId == reqId)
                    data.Add(msg);
            }

            void OnScannerDataEnd(ScannerDataEndMessage msg)
            {
                if (msg.RequestId == reqId)
                    res.TrySetResult(data);
            }

            Error += OnError;
            ScannerData += OnScannerData;
            ScannerDataEnd += OnScannerDataEnd;

            reqScannerSubscription();

            await res.Task.ContinueWith(x =>
            {
                _clientSocket.cancelScannerSubscription(reqId);
                Error -= OnError;
                ScannerData -= OnScannerData;
                ScannerDataEnd -= OnScannerDataEnd;
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
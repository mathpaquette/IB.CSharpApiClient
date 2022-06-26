using System.Collections.Generic;
using System.Threading.Tasks;
using IB.CSharpApiClient.Messages;
using IBApi;

namespace IB.CSharpApiClient
{
    public interface IClientAsync
    {
        // TODO: implement missing Async methods

        Task<IEnumerable<ScannerDataMessage>> GetScannerDataAsync(ScannerSubscription subscription, List<TagValue> scannerSubscriptionOptions, List<TagValue> scannerSubscriptionFilterOptions);
        Task<IEnumerable<ScannerDataMessage>> GetScannerDataAsync(ScannerSubscription subscription, string scannerSubscriptionOptions, string scannerSubscriptionFilterOptions);
    }
}
using System.Threading.Tasks;

namespace IB.CSharpApiClient
{
    public interface IApiClientAsync
    {
        Task GetAccountDownloadAsync();
        Task GetAccountSummaryAsync();
        Task GetAccountUpdateMultiAsync();
        Task GetContractDetailsAsync();
        Task GetExecutionAsync();
        Task GetHistoricalDataAsync();
        Task GetHistoricalNewsAsync();
        Task GetHistoricalTickBidAskAsync();
        Task GetHistoricalTickAsync();
        Task GetHistoricalTickLastAsync();
        Task GetOpenOrderAsync();
        Task GetPositionAsync();
        Task GetPositionMultiAsync();
        Task GetScannerAsync();
        Task GetSecurityDefinitionOptionParameterAsync();
        Task GetTickSnapshotAsync();
    }
}
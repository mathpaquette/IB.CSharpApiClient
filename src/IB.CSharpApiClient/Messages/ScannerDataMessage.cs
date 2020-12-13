using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class ScannerDataMessage
    {
        public int RequestId { get; private set; }
        public int Rank { get; private set; }
        public ContractDetails ContractDetails { get; private set; }
        public string Distance { get; private set; }
        public string Benchmark { get; private set; }
        public string Projection { get; private set; }
        public string LegsStr { get; private set; }

        public ScannerDataMessage(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark, string projection, string legsStr)
        {
            RequestId = reqId;
            Rank = rank;
            ContractDetails = contractDetails;
            Distance = distance;
            Benchmark = benchmark;
            Projection = projection;
            LegsStr = legsStr;
        }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(Rank)}: {Rank}, {nameof(ContractDetails)}: {ContractDetails}, {nameof(Distance)}: {Distance}, {nameof(Benchmark)}: {Benchmark}, {nameof(Projection)}: {Projection}, {nameof(LegsStr)}: {LegsStr}";
        }
    }
}

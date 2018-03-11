using IBApi;

namespace IB.CSharpApiClient.Example.Domain.ValueObject
{
    public class Scanner
    {
        public int Rank { get; }
        public ContractDetails ContractDetails { get; }
        public string Distance { get; }
        public string Benchmark { get; }
        public string Projection { get; }
        public string LegsStr { get; }

        public Scanner(int rank, ContractDetails contractDetails, string distance, string benchmark, string projection, string legsStr)
        {
            Rank = rank;
            ContractDetails = contractDetails;
            Distance = distance;
            Benchmark = benchmark;
            Projection = projection;
            LegsStr = legsStr;
        }
    }
}
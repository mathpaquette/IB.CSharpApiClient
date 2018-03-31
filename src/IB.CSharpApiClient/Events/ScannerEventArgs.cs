using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class ScannerEventArgs : EventArgs
    {
        public ScannerEventArgs(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark, string projection, string legsStr)
        {
            RequestId = reqId;
            Rank = rank;
            ContractDetails = contractDetails;
            Distance = distance;
            Benchmark = benchmark;
            Projection = projection;
            LegsStr = legsStr;
        }

        public int RequestId { get; }
        public int Rank { get; }
        public ContractDetails ContractDetails { get; }
        public string Distance { get; }
        public string Benchmark { get; }
        public string Projection { get; }
        public string LegsStr { get; }

        public override string ToString()
        {
            return $"{nameof(Benchmark)}: {Benchmark}, {nameof(ContractDetails)}: {ContractDetails}, {nameof(Distance)}: {Distance}, {nameof(LegsStr)}: {LegsStr}, {nameof(Projection)}: {Projection}, {nameof(Rank)}: {Rank}, {nameof(RequestId)}: {RequestId}";
        }
    }
}
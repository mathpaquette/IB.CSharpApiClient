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

        public int RequestId { get; private set; }

        public int Rank { get; private set; }

        public ContractDetails ContractDetails { get; private set; }

        public string Distance { get; private set; }

        public string Benchmark { get; private set; }


        public string Projection { get; private set; }


        public string LegsStr { get; private set; }
    }
}

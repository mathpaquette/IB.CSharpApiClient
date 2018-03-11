using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class ScannerEventArgs : EventArgs
    {
        private int requestId;
        private int rank;
        private IBApi.ContractDetails contractDetails;
        private string distance;
        private string benchmark;
        private string projection;
        private string legsStr;

        public ScannerEventArgs(int reqId, int rank, IBApi.ContractDetails contractDetails, string distance, string benchmark, string projection, string legsStr)
        {
            RequestId = reqId;
            Rank = rank;
            ContractDetails = contractDetails;
            Distance = distance;
            Benchmark = benchmark;
            Projection = projection;
            LegsStr = legsStr;
        }

        public int RequestId
        {
            get { return requestId; }
            set { requestId = value; }
        }

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public ContractDetails ContractDetails
        {
            get { return contractDetails; }
            set { contractDetails = value; }
        }

        public string Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public string Benchmark
        {
            get { return benchmark; }
            set { benchmark = value; }
        }
        

        public string Projection
        {
            get { return projection; }
            set { projection = value; }
        }
        

        public string LegsStr
        {
            get { return legsStr; }
            set { legsStr = value; }
        }

    }
}

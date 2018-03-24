using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class PositionMultiEventArgs : EventArgs
    {
        public PositionMultiEventArgs(int reqId, string account, string modelCode, Contract contract, double pos, double avgCost)
        {
            ReqId = reqId;
            Account = account;
            ModelCode = modelCode;
            Contract = contract;
            Position = pos;
            AverageCost = avgCost;
        }

        public int ReqId { get; private set; }

        public string Account { get; private set; }

        public string ModelCode { get; private set; }

        public Contract Contract { get; private set; }

        public double Position { get; private set; }

        public double AverageCost { get; private set; }
    }
}

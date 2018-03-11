using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class PositionMultiEventArgs : EventArgs
    {
        private int reqId;
        private string account;
        private string modelCode;
        private Contract contract;
        private double position;
        private double averageCost;
        
        public PositionMultiEventArgs(int reqId, string account, string modelCode, Contract contract, double pos, double avgCost)
        {
            ReqId = reqId;
            Account = account;
            ModelCode = modelCode;
            Contract = contract;
            Position = pos;
            AverageCost = avgCost;
        }

        public int ReqId
        {
            get { return reqId; }
            set { reqId = value; }
        }

        public string Account
        {
            get { return account; }
            set { account = value; }
        }

        public string ModelCode
        {
            get { return modelCode; }
            set { modelCode = value; }
        }

        public Contract Contract
        {
            get { return contract; }
            set { contract = value; }
        }

        public double Position
        {
            get { return position; }
            set { position = value; }
        }
        
        public double AverageCost
        {
            get { return averageCost; }
            set { averageCost = value; }
        }
    }
}

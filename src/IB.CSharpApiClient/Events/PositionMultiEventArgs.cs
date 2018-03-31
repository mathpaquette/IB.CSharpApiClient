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

        public int ReqId { get; }
        public string Account { get; }
        public string ModelCode { get; }
        public Contract Contract { get; }
        public double Position { get; }
        public double AverageCost { get; }

        public override string ToString()
        {
            return $"{nameof(Account)}: {Account}, {nameof(AverageCost)}: {AverageCost}, {nameof(Contract)}: {Contract}, {nameof(ModelCode)}: {ModelCode}, {nameof(Position)}: {Position}, {nameof(ReqId)}: {ReqId}";
        }
    }
}
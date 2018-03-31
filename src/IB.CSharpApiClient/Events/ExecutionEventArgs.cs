using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class ExecutionEventArgs : EventArgs
    {
        public ExecutionEventArgs(int reqId, Contract contract, Execution execution)
        {
            ReqId = reqId;
            Contract = contract;
            Execution = execution;
        }

        public Contract Contract { get; }
        public Execution Execution { get; }
        public int ReqId { get; }

        public override string ToString()
        {
            return $"{nameof(Contract)}: {Contract}, {nameof(Execution)}: {Execution}, {nameof(ReqId)}: {ReqId}";
        }
    }
}
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

        public Contract Contract { get; private set; }

        public Execution Execution { get; private set; }

        public int ReqId { get; private set; }
    }
}

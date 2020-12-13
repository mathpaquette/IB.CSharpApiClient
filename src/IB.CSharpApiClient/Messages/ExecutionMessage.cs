using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class ExecutionMessage
    {
        public Contract Contract { get; private set; }
        public Execution Execution { get; private set; }
        public int ReqId { get; private set; }

        public ExecutionMessage(int reqId, Contract contract, Execution execution)
        {
            ReqId = reqId;
            Contract = contract;
            Execution = execution;
        }

        public override string ToString()
        {
            return $"{nameof(Contract)}: {Contract}, {nameof(Execution)}: {Execution}, {nameof(ReqId)}: {ReqId}";
        }
    }
}

using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class ExecDetailsMessage
    {
        public int ReqId { get; private set; }
        public Contract Contract { get; private set; }
        public Execution Execution { get; private set; }

        public ExecDetailsMessage(int reqId, Contract contract, Execution execution)
        {
            ReqId = reqId;
            Contract = contract;
            Execution = execution;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Contract)}: {Contract}, {nameof(Execution)}: {Execution}";
        }
    }
}
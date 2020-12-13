using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class DeltaNeutralValidationMessage
    {
        public int ReqId { get; private set; }
        public DeltaNeutralContract DeltaNeutralContract { get; private set; }

        public DeltaNeutralValidationMessage(int reqId, DeltaNeutralContract deltaNeutralContract)
        {
            ReqId = reqId;
            DeltaNeutralContract = deltaNeutralContract;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(DeltaNeutralContract)}: {DeltaNeutralContract}";
        }
    }
}
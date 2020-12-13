using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class BondContractDetailsMessage
    {
        public ContractDetails ContractDetails { get; private set; }
        public int RequestId { get; private set; }

        public BondContractDetailsMessage(int requestId, ContractDetails contractDetails)
        {
            RequestId = requestId;
            ContractDetails = contractDetails;
        }

        public override string ToString()
        {
            return $"{nameof(ContractDetails)}: {ContractDetails}, {nameof(RequestId)}: {RequestId}";
        }
    }
}

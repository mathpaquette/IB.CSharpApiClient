using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class SymbolSamplesMessage
    {
        public int ReqId { get; private set; }
        public ContractDescription[] ContractDescriptions { get; private set; }

        public SymbolSamplesMessage(int reqId, ContractDescription[] contractDescriptions)
        {
            ReqId = reqId;
            ContractDescriptions = contractDescriptions;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(ContractDescriptions)}: {ContractDescriptions}";
        }
    }
}

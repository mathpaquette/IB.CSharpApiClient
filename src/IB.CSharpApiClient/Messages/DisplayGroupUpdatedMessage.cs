namespace IB.CSharpApiClient.Messages
{
    public class DisplayGroupUpdatedMessage
    {
        public int ReqId { get; private set; }
        public string ContractInfo { get; private set; }

        public DisplayGroupUpdatedMessage(int reqId, string contractInfo)
        {
            ReqId = reqId;
            ContractInfo = contractInfo;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(ContractInfo)}: {ContractInfo}";
        }
    }
}
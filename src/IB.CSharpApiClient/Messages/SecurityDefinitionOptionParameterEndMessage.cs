namespace IB.CSharpApiClient.Messages
{
    public class SecurityDefinitionOptionParameterEndMessage
    {
        public int ReqId { get; private set; }

        public SecurityDefinitionOptionParameterEndMessage(int reqId)
        {
            ReqId = reqId;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}";
        }
    }
}

namespace IB.CSharpApiClient.Messages
{
    public class SoftDollarTiersMessage
    {
        public int ReqId { get; private set; }
        public IBApi.SoftDollarTier[] Tiers { get; private set; }

        public SoftDollarTiersMessage(int reqId, IBApi.SoftDollarTier[] tiers)
        {
            ReqId = reqId;
            Tiers = tiers;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Tiers)}: {Tiers}";
        }
    }
}

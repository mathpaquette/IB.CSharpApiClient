using System;

namespace IB.CSharpApiClient.Events
{
    public class SoftDollarTiersEventArgs : EventArgs
    {
        public int ReqId { get; private set; }
        public IBApi.SoftDollarTier[] Tiers { get; private set; }

        public SoftDollarTiersEventArgs(int reqId, IBApi.SoftDollarTier[] tiers)
        {
            this.ReqId = reqId;
            this.Tiers = tiers;
        }
    }
}

using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class SoftDollarTiersEventArgs : EventArgs
    {
        public int ReqId { get; private set; }
        public SoftDollarTier[] Tiers { get; private set; }

        public SoftDollarTiersEventArgs(int reqId, SoftDollarTier[] tiers)
        {
            this.ReqId = reqId;
            this.Tiers = tiers;
        }
    }
}

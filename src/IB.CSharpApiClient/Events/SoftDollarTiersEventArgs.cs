using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class SoftDollarTiersEventArgs : EventArgs
    {
        public SoftDollarTiersEventArgs(int reqId, SoftDollarTier[] tiers)
        {
            ReqId = reqId;
            Tiers = tiers;
        }

        public int ReqId { get; }
        public SoftDollarTier[] Tiers { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Tiers)}: {Tiers}";
        }
    }
}
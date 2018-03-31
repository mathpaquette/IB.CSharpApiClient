using System;

namespace IB.CSharpApiClient.Events
{
    public class AccountUpdateMultiEndEventArgs : EventArgs
    {
        public AccountUpdateMultiEndEventArgs(int reqId)
        {
            ReqId = ReqId;
        }

        public int ReqId { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}";
        }
    }
}
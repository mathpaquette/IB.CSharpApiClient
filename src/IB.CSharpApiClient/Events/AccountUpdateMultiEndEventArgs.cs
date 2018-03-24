using System;

namespace IB.CSharpApiClient.Events
{
    public class AccountUpdateMultiEndEventArgs : EventArgs
    {
        public AccountUpdateMultiEndEventArgs(int reqId)
        {
            ReqId = ReqId;
        }

        public int ReqId { get; private set; }
    }
}

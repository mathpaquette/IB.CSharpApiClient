using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class DeltaNeutralValidationEventArgs : EventArgs
    {
        public DeltaNeutralValidationEventArgs(int reqId, UnderComp underComp)
        {
            ReqId = reqId;
            UnderComp = underComp;
        }

        public int ReqId { get; private set; }
        public UnderComp UnderComp { get; private set; }
    }
}
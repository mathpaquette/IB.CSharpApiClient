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

        public int ReqId { get; }
        public UnderComp UnderComp { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(UnderComp)}: {UnderComp}";
        }
    }
}
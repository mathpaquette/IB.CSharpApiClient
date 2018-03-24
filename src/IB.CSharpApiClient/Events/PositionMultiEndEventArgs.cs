using System;

namespace IB.CSharpApiClient.Events
{
    public class PositionMultiEndEventArgs : EventArgs
    {
        public PositionMultiEndEventArgs(int reqId)
        {
            ReqId = reqId;
        }

        public int ReqId { get; private set; }
    }
}
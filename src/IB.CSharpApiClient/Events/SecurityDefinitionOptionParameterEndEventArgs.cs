using System;

namespace IB.CSharpApiClient.Events
{
    public class SecurityDefinitionOptionParameterEndEventArgs : EventArgs
    {
        public int RequestId { get; private set; }

        public SecurityDefinitionOptionParameterEndEventArgs(int reqId)
        {
            RequestId = reqId;
        }
    }
}

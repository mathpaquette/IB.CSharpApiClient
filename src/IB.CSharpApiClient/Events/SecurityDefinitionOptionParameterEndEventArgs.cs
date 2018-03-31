using System;

namespace IB.CSharpApiClient.Events
{
    public class SecurityDefinitionOptionParameterEndEventArgs : EventArgs
    {
        public SecurityDefinitionOptionParameterEndEventArgs(int reqId)
        {
            RequestId = reqId;
        }

        public int RequestId { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}";
        }
    }
}
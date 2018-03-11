using System;

namespace IB.CSharpApiClient.Events
{
    public class SecurityDefinitionOptionParameterEndEventArgs : EventArgs
    {
        private int reqId;

        public SecurityDefinitionOptionParameterEndEventArgs(int reqId)
        {
            this.reqId = reqId;
        }
    }
}

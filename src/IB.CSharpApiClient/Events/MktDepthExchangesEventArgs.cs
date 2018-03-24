using System;

namespace IB.CSharpApiClient.Events
{
    public class MktDepthExchangesEventArgs : EventArgs
    {
        public IBApi.DepthMktDataDescription[] Descriptions { get; private set; }

        public MktDepthExchangesEventArgs(IBApi.DepthMktDataDescription[] descriptions)
        {
            this.Descriptions = descriptions;
        }
    }
}

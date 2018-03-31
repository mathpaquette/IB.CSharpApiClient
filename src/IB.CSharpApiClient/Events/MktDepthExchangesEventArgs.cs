using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class MktDepthExchangesEventArgs : EventArgs
    {
        public MktDepthExchangesEventArgs(DepthMktDataDescription[] descriptions)
        {
            Descriptions = descriptions;
        }

        public DepthMktDataDescription[] Descriptions { get; }

        public override string ToString()
        {
            return $"{nameof(Descriptions)}: {Descriptions}";
        }
    }
}
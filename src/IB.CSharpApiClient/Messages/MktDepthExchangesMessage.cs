using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class MktDepthExchangesMessage
    {
        public DepthMktDataDescription[] Descriptions { get; private set; }

        public MktDepthExchangesMessage(DepthMktDataDescription[] descriptions)
        {
            Descriptions = descriptions;
        }

        public override string ToString()
        {
            return $"{nameof(Descriptions)}: {Descriptions}";
        }
    }
}

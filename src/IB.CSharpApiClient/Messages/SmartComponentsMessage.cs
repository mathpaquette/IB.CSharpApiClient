using System.Collections.Generic;

namespace IB.CSharpApiClient.Messages
{
    public class SmartComponentsMessage
    {
        public int ReqId { get; private set; }
        public Dictionary<int, KeyValuePair<string, char>> TheMap { get; private set; }

        public SmartComponentsMessage(int reqId, Dictionary<int, KeyValuePair<string, char>> theMap)
        {
            ReqId = reqId;
            TheMap = theMap;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(TheMap)}: {TheMap}";
        }
    }
}
using System;
using System.Collections.Generic;

namespace IB.CSharpApiClient.Events
{
    public class SmartComponentsEventArgs : EventArgs
    {
        public SmartComponentsEventArgs(int requestId, Dictionary<int, KeyValuePair<string, char>> values)
        {
            RequestId = requestId;
            Values = values;
        }

        public int RequestId { get; }
        public Dictionary<int, KeyValuePair<string, char>> Values { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(Values)}: {Values}";
        }
    }
}
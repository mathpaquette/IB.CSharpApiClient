using System;
using System.Collections.Generic;

namespace IB.CSharpApiClient.Events
{
    public class SmartComponentsEventArgs : EventArgs
    {
        public int RequestId { get; }
        public Dictionary<int, KeyValuePair<string, char>> Values { get; }

        public SmartComponentsEventArgs(int requestId, Dictionary<int, KeyValuePair<string, char>> values)
        {
            RequestId = requestId;
            Values = values;
        }   
    }
}
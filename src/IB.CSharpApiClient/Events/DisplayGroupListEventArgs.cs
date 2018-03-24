using System;

namespace IB.CSharpApiClient.Events
{
    public class DisplayGroupListEventArgs : EventArgs
    {
        public int ReqId { get; private set; }
        public string Groups { get; private set; }

        public DisplayGroupListEventArgs(int reqId, string groups)
        {
            ReqId = reqId;
            Groups = groups;
        }
    }
}
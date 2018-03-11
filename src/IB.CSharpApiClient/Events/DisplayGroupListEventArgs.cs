using System;

namespace IB.CSharpApiClient.Events
{
    public class DisplayGroupListEventArgs : EventArgs
    {
        public int ReqId { get; }
        public string Groups { get; }

        public DisplayGroupListEventArgs(int reqId, string groups)
        {
            ReqId = reqId;
            Groups = groups;
        }
    }
}
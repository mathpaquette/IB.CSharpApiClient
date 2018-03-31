using System;

namespace IB.CSharpApiClient.Events
{
    public class DisplayGroupListEventArgs : EventArgs
    {
        public DisplayGroupListEventArgs(int reqId, string groups)
        {
            ReqId = reqId;
            Groups = groups;
        }

        public int ReqId { get; }
        public string Groups { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Groups)}: {Groups}";
        }
    }
}
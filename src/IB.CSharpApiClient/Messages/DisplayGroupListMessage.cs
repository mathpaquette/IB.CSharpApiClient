namespace IB.CSharpApiClient.Messages
{
    public class DisplayGroupListMessage
    {
        public int ReqId { get; private set; }
        public string Groups { get; private set; }

        public DisplayGroupListMessage(int reqId, string groups)
        {
            ReqId = reqId;
            Groups = groups;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Groups)}: {Groups}";
        }
    }
}
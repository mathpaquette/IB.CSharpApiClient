namespace IB.CSharpApiClient.Messages
{
    public class UserInfoMessage
    {
        public int ReqId { get; private set; }
        public string WhiteBrandingId { get; private set; }

        public UserInfoMessage(int reqId, string whiteBrandingId)
        {
            ReqId = reqId;
            WhiteBrandingId = whiteBrandingId;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(WhiteBrandingId)}: {WhiteBrandingId}";
        }
    }
}
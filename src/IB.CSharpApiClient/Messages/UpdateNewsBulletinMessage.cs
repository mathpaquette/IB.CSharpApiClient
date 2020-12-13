namespace IB.CSharpApiClient.Messages
{
    public class UpdateNewsBulletinMessage
    {
        public int MsgId { get; private set; }
        public int MsgType { get; private set; }
        public string Message { get; private set; }
        public string OrigExchange { get; private set; }

        public UpdateNewsBulletinMessage(int msgId, int msgType, string message, string origExchange)
        {
            MsgId = msgId;
            MsgType = msgType;
            Message = message;
            OrigExchange = origExchange;
        }

        public override string ToString()
        {
            return $"{nameof(MsgId)}: {MsgId}, {nameof(MsgType)}: {MsgType}, {nameof(Message)}: {Message}, {nameof(OrigExchange)}: {OrigExchange}";
        }
    }
}
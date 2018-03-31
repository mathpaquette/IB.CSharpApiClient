using System;

namespace IB.CSharpApiClient.Events
{
    public class UpdateNewsBulletin : EventArgs
    {
        public UpdateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            MsgId = msgId;
            MsgType = msgType;
            Message = message;
            OrigExchange = origExchange;
        }

        public int MsgId { get; }
        public int MsgType { get; }
        public string Message { get; }
        public string OrigExchange { get; }

        public override string ToString()
        {
            return $"{nameof(Message)}: {Message}, {nameof(MsgId)}: {MsgId}, {nameof(MsgType)}: {MsgType}, {nameof(OrigExchange)}: {OrigExchange}";
        }
    }
}
using System;
using System.Reflection;

namespace IB.CSharpApiClient.Events
{
    public class UpdateNewsBulletin : EventArgs
    {
        public int MsgId { get; }
        public int MsgType { get; }
        public string Message { get; }
        public string OrigExchange { get; }

        public UpdateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            MsgId = msgId;
            MsgType = msgType;
            Message = message;
            OrigExchange = origExchange;
        }
    }
}
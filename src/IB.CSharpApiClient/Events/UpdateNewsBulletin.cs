using System;
using System.Reflection;

namespace IB.CSharpApiClient.Events
{
    public class UpdateNewsBulletin : EventArgs
    {
        public int MsgId { get; private set; }
        public int MsgType { get; private set; }
        public string Message { get; private set; }
        public string OrigExchange { get; private set; }

        public UpdateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            MsgId = msgId;
            MsgType = msgType;
            Message = message;
            OrigExchange = origExchange;
        }
    }
}
using System;
using System.Collections.Generic;

namespace IB.CSharpApiClient.Events
{
    public class SecurityDefinitionOptionParameterEventArgs : EventArgs
    {
        public int ReqId { get; private set; }
        public string Exchange { get; private set; }
        public int UnderlyingConId { get; private set; }
        public string TradingClass { get; private set; }
        public string Multiplier { get; private set; }
        public HashSet<string> Expirations { get; private set; }
        public HashSet<double> Strikes { get; private set; }

        public SecurityDefinitionOptionParameterEventArgs(int reqId, string exchange, int underlyingConId, string tradingClass, string multiplier, HashSet<string> expirations, HashSet<double> strikes)
        {
            this.ReqId = reqId;
            this.Exchange = exchange;
            this.UnderlyingConId = underlyingConId;
            this.TradingClass = tradingClass;
            this.Multiplier = multiplier;
            this.Expirations = expirations;
            this.Strikes = strikes;
        }
    }
}

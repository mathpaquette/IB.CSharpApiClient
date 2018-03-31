using System;
using System.Collections.Generic;

namespace IB.CSharpApiClient.Events
{
    public class SecurityDefinitionOptionParameterEventArgs : EventArgs
    {
        public SecurityDefinitionOptionParameterEventArgs(int reqId, string exchange, int underlyingConId,
            string tradingClass, string multiplier, HashSet<string> expirations, HashSet<double> strikes)
        {
            ReqId = reqId;
            Exchange = exchange;
            UnderlyingConId = underlyingConId;
            TradingClass = tradingClass;
            Multiplier = multiplier;
            Expirations = expirations;
            Strikes = strikes;
        }

        public int ReqId { get; }
        public string Exchange { get; }
        public int UnderlyingConId { get; }
        public string TradingClass { get; }
        public string Multiplier { get; }
        public HashSet<string> Expirations { get; }
        public HashSet<double> Strikes { get; }

        public override string ToString()
        {
            return $"{nameof(Exchange)}: {Exchange}, {nameof(Expirations)}: {Expirations}, {nameof(Multiplier)}: {Multiplier}, {nameof(ReqId)}: {ReqId}, {nameof(Strikes)}: {Strikes}, {nameof(TradingClass)}: {TradingClass}, {nameof(UnderlyingConId)}: {UnderlyingConId}";
        }
    }
}
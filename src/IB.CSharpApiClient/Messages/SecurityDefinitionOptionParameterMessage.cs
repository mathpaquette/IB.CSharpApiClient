using System.Collections.Generic;

namespace IB.CSharpApiClient.Messages
{
    public class SecurityDefinitionOptionParameterMessage
    {
        public int ReqId { get; private set; }
        public string Exchange { get; private set; }
        public int UnderlyingConId { get; private set; }
        public string TradingClass { get; private set; }
        public string Multiplier { get; private set; }
        public HashSet<string> Expirations { get; private set; }
        public HashSet<double> Strikes { get; private set; }

        public SecurityDefinitionOptionParameterMessage(int reqId, string exchange, int underlyingConId, string tradingClass, string multiplier, HashSet<string> expirations, HashSet<double> strikes)
        {
            ReqId = reqId;
            Exchange = exchange;
            UnderlyingConId = underlyingConId;
            TradingClass = tradingClass;
            Multiplier = multiplier;
            Expirations = expirations;
            Strikes = strikes;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Exchange)}: {Exchange}, {nameof(UnderlyingConId)}: {UnderlyingConId}, {nameof(TradingClass)}: {TradingClass}, {nameof(Multiplier)}: {Multiplier}, {nameof(Expirations)}: {Expirations}, {nameof(Strikes)}: {Strikes}";
        }
    }
}

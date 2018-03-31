namespace IB.CSharpApiClient.Events
{
    public class TickOptionEventArgs : MarketDataEventArgs
    {
        public TickOptionEventArgs(int requestId, int field, double impliedVolatility, double delta, double optPrice,
            double pvDividend, double gamma, double vega, double theta, double undPrice)
            : base(requestId, field)
        {
            ImpliedVolatility = impliedVolatility;
            Delta = delta;
            OptPrice = optPrice;
            PvDividend = pvDividend;
            Gamma = gamma;
            Vega = vega;
            Theta = theta;
            UndPrice = undPrice;
        }

        public double ImpliedVolatility { get; }
        public double Delta { get; }
        public double OptPrice { get; }
        public double PvDividend { get; }
        public double Gamma { get; }
        public double Vega { get; }
        public double Theta { get; }
        public double UndPrice { get; }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Delta)}: {Delta}, {nameof(Gamma)}: {Gamma}, {nameof(ImpliedVolatility)}: {ImpliedVolatility}, {nameof(OptPrice)}: {OptPrice}, {nameof(PvDividend)}: {PvDividend}, {nameof(Theta)}: {Theta}, {nameof(UndPrice)}: {UndPrice}, {nameof(Vega)}: {Vega}";
        }
    }
}
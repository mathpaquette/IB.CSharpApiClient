namespace IB.CSharpApiClient.Events
{
    public class TickOptionEventArgs : MarketDataEventArgs
    {
        public TickOptionEventArgs(int requestId, int field, double impliedVolatility, double delta, double optPrice, double pvDividend, double gamma, double vega, double theta, double undPrice)
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

        public double ImpliedVolatility { get; private set; }
        public double Delta { get; private set; }
        public double OptPrice { get; private set; }
        public double PvDividend { get; private set; }
        public double Gamma { get; private set; }
        public double Vega { get; private set; }
        public double Theta { get; private set; }
        public double UndPrice { get; private set; }
    }
}

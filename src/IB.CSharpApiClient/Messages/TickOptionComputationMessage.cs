namespace IB.CSharpApiClient.Messages
{
    public class TickOptionComputationMessage
    {
        public int TickerId { get; private set; }
        public int Field { get; private set; }
        public double ImpliedVolatility { get; private set; }
        public double Delta { get; private set; }
        public double OptPrice { get; private set; }
        public double PvDividend { get; private set; }
        public double Gamma { get; private set; }
        public double Vega { get; private set; }
        public double Theta { get; private set; }
        public double UndPrice { get; private set; }

        public TickOptionComputationMessage(int tickerId, int field, double impliedVolatility, double delta, double optPrice, double pvDividend, double gamma, double vega, double theta, double undPrice)
        {
            TickerId = tickerId;
            Field = field;
            ImpliedVolatility = impliedVolatility;
            Delta = delta;
            OptPrice = optPrice;
            PvDividend = pvDividend;
            Gamma = gamma;
            Vega = vega;
            Theta = theta;
            UndPrice = undPrice;
        }

        public override string ToString()
        {
            return $"{nameof(TickerId)}: {TickerId}, {nameof(Field)}: {Field}, {nameof(ImpliedVolatility)}: {ImpliedVolatility}, {nameof(Delta)}: {Delta}, {nameof(OptPrice)}: {OptPrice}, {nameof(PvDividend)}: {PvDividend}, {nameof(Gamma)}: {Gamma}, {nameof(Vega)}: {Vega}, {nameof(Theta)}: {Theta}, {nameof(UndPrice)}: {UndPrice}";
        }
    }
}
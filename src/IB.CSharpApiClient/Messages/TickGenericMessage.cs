namespace IB.CSharpApiClient.Messages
{
    public class TickGenericMessage
    {
        public int TickerId { get; private set; }
        public int Field { get; private set; }
        public double Value { get; private set; }

        public TickGenericMessage(int tickerId, int field, double value)
        {
            TickerId = tickerId;
            Field = field;
            Value = value;
        }

        public override string ToString()
        {
            return $"{nameof(TickerId)}: {TickerId}, {nameof(Field)}: {Field}, {nameof(Value)}: {Value}";
        }
    }
}
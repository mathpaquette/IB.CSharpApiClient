namespace IB.CSharpApiClient.Messages
{
    public class TickStringMessage
    {
        public int TickerId { get; private set; }
        public int Field { get; private set; }
        public string Value { get; private set; }

        public TickStringMessage(int tickerId, int field, string value)
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
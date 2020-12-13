namespace IB.CSharpApiClient.Messages
{
    public class UpdateAccountTimeMessage
    {
        public string Timestamp { get; private set; }

        public UpdateAccountTimeMessage(string timestamp)
        {
            Timestamp = timestamp;
        }

        public override string ToString()
        {
            return $"{nameof(Timestamp)}: {Timestamp}";
        }
    }
}

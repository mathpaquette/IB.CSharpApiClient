using System;

namespace IB.CSharpApiClient.Events
{
    public class UpdateAccountTimeEventArgs : EventArgs
    {
        public UpdateAccountTimeEventArgs(string timestamp)
        {
            Timestamp = timestamp;
        }

        public string Timestamp { get; }

        public override string ToString()
        {
            return $"{nameof(Timestamp)}: {Timestamp}";
        }
    }
}
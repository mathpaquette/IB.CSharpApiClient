using System;

namespace IB.CSharpApiClient.Events
{
    public class UpdateAccountTimeEventArgs : EventArgs
    {
        private string timestamp;
        
        public UpdateAccountTimeEventArgs(string timestamp)
        {
            Timestamp = timestamp;
        }

        public string Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
    }
}

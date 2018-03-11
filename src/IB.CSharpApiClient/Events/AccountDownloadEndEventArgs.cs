using System;

namespace IB.CSharpApiClient.Events
{
    public class AccountDownloadEndEventArgs : EventArgs
    {
        private string account;
        
        public AccountDownloadEndEventArgs(string account)
        {
            Account = account;
        }

        public string Account
        {
            get { return account; }
            set { account = value; }
        }
    }
}

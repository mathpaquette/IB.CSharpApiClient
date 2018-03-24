using System;

namespace IB.CSharpApiClient.Events
{
    public class AccountDownloadEndEventArgs : EventArgs
    {
        public AccountDownloadEndEventArgs(string account)
        {
            Account = account;
        }

        public string Account { get; private set; }
    }
}

using System;
using System.Collections.Generic;

namespace IB.CSharpApiClient.Events
{
    public class ManagedAccountsEventArgs : EventArgs
    {
        public ManagedAccountsEventArgs(string managedAccounts)
        {
            ManagedAccounts = new List<string>(managedAccounts.Split(','));
        }

        public IList<string> ManagedAccounts { get; }

        public override string ToString()
        {
            return $"{nameof(ManagedAccounts)}: {ManagedAccounts}";
        }
    }
}
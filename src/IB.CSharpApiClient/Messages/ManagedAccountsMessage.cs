using System.Collections.Generic;

namespace IB.CSharpApiClient.Messages
{
    public class ManagedAccountsMessage
    {
        public List<string> ManagedAccounts { get; private set; }

        public ManagedAccountsMessage(string managedAccounts)
        {
            ManagedAccounts = new List<string>(managedAccounts.Split(','));
        }

        public override string ToString()
        {
            return $"{nameof(ManagedAccounts)}: {ManagedAccounts}";
        }
    }
}

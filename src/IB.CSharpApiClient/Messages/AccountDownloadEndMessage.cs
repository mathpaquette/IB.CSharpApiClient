namespace IB.CSharpApiClient.Messages
{
    public class AccountDownloadEndMessage
    {
        public string Account { get; private set; }

        public AccountDownloadEndMessage(string account)
        {
            Account = account;
        }

        public override string ToString()
        {
            return $"{nameof(Account)}: {Account}";
        }
    }
}

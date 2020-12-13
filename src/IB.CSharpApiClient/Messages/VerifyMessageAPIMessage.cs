namespace IB.CSharpApiClient.Messages
{
    public class VerifyMessageAPIMessage
    {
        public string ApiData { get; private set; }

        public VerifyMessageAPIMessage(string apiData)
        {
            ApiData = apiData;
        }

        public override string ToString()
        {
            return $"{nameof(ApiData)}: {ApiData}";
        }
    }
}
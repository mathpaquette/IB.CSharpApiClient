namespace IB.CSharpApiClient.Messages
{
    public class VerifyAndAuthMessageAPIMessage
    {
        public string ApiData { get; private set; }
        public string XyzChallenge { get; private set; }

        public VerifyAndAuthMessageAPIMessage(string apiData, string xyzChallenge)
        {
            ApiData = apiData;
            XyzChallenge = xyzChallenge;
        }

        public override string ToString()
        {
            return $"{nameof(ApiData)}: {ApiData}, {nameof(XyzChallenge)}: {XyzChallenge}";
        }
    }
}
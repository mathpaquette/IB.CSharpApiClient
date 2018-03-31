using System;

namespace IB.CSharpApiClient.Events
{
    public class VerifyAndAuthMessageApiEventArgs : EventArgs
    {
        public VerifyAndAuthMessageApiEventArgs(string apiData, string xyzChallenge)
        {
            ApiData = apiData;
            XyzChallenge = xyzChallenge;
        }

        public string ApiData { get; }
        public string XyzChallenge { get; }

        public override string ToString()
        {
            return $"{nameof(ApiData)}: {ApiData}, {nameof(XyzChallenge)}: {XyzChallenge}";
        }
    }
}
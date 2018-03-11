using System;

namespace IB.CSharpApiClient.Events
{
    public class VerifyAndAuthMessageApiEventArgs : EventArgs
    {
        public string ApiData { get; }
        public string XyzChallenge { get; }

        public VerifyAndAuthMessageApiEventArgs(string apiData, string xyzChallenge)
        {
            ApiData = apiData;
            XyzChallenge = xyzChallenge;
        }
    }
}
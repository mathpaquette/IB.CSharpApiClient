using System;

namespace IB.CSharpApiClient.Events
{
    public class VerifyAndAuthMessageApiEventArgs : EventArgs
    {
        public string ApiData { get; private set; }
        public string XyzChallenge { get; private set; }

        public VerifyAndAuthMessageApiEventArgs(string apiData, string xyzChallenge)
        {
            ApiData = apiData;
            XyzChallenge = xyzChallenge;
        }
    }
}
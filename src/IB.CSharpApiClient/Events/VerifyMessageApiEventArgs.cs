using System;

namespace IB.CSharpApiClient.Events
{
    public class VerifyMessageApiEventArgs : EventArgs
    {
        public string ApiData { get; private set; }

        public VerifyMessageApiEventArgs(string apiData)
        {
            ApiData = apiData;
        }
    }
}
using System;

namespace IB.CSharpApiClient.Events
{
    public class VerifyMessageApiEventArgs : EventArgs
    {
        public string ApiData { get; }

        public VerifyMessageApiEventArgs(string apiData)
        {
            ApiData = apiData;
        }
    }
}
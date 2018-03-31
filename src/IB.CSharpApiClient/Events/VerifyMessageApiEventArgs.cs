using System;

namespace IB.CSharpApiClient.Events
{
    public class VerifyMessageApiEventArgs : EventArgs
    {
        public VerifyMessageApiEventArgs(string apiData)
        {
            ApiData = apiData;
        }

        public string ApiData { get; }

        public override string ToString()
        {
            return $"{nameof(ApiData)}: {ApiData}";
        }
    }
}
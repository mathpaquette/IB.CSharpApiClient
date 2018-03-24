using System;

namespace IB.CSharpApiClient.Events
{
    public class AdvisorDataEventArgs : EventArgs
    {
        public AdvisorDataEventArgs(int faDataType, string data)
        {
            FaDataType = faDataType;
            Data = data;
        }

        public int FaDataType { get; private set; }

        public string Data { get; private set; }
    }
}

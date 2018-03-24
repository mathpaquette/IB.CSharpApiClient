using System;

namespace IB.CSharpApiClient.Events
{
    public class ScannerParametersEventArgs : EventArgs
    {
        public ScannerParametersEventArgs(string data)
        {
            XmlData = data;
        }

        public string XmlData { get; private set; }
    }
}

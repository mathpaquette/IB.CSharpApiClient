using System;

namespace IB.CSharpApiClient.Events
{
    public class ScannerParametersEventArgs : EventArgs
    {
        public ScannerParametersEventArgs(string data)
        {
            XmlData = data;
        }

        public string XmlData { get; }

        public override string ToString()
        {
            return $"{nameof(XmlData)}: {XmlData}";
        }
    }
}
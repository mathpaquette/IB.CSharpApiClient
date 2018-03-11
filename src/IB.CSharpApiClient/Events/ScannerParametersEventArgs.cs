using System;

namespace IB.CSharpApiClient.Events
{
    public class ScannerParametersEventArgs : EventArgs
    {
        private string xmlData;
        
        public ScannerParametersEventArgs(string data)
        {
            XmlData = data;
        }

        public string XmlData
        {
            get { return xmlData; }
            set { xmlData = value; }
        }
    }
}

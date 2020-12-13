namespace IB.CSharpApiClient.Messages
{
    public class ScannerParametersMessage
    {
        public string XmlData { get; private set; }

        public ScannerParametersMessage(string data)
        {
            XmlData = data;
        }

        public override string ToString()
        {
            return $"{nameof(XmlData)}: {XmlData}";
        }
    }
}

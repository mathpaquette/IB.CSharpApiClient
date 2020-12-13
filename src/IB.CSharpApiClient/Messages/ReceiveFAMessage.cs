namespace IB.CSharpApiClient.Messages
{
    public class ReceiveFAMessage
    {
        public int FaDataType { get; private set; }
        public string FaXmlData { get; private set; }

        public ReceiveFAMessage(int faDataType, string faXmlData)
        {
            FaDataType = faDataType;
            FaXmlData = faXmlData;
        }

        public override string ToString()
        {
            return $"{nameof(FaDataType)}: {FaDataType}, {nameof(FaXmlData)}: {FaXmlData}";
        }
    }
}
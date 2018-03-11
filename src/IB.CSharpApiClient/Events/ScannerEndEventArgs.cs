using System;

namespace IB.CSharpApiClient.Events
{
    public class ScannerEndEventArgs : EventArgs
    {
        private int requestId;

        public ScannerEndEventArgs(int requestId)
        {
             RequestId = requestId;
        }

        public int RequestId
        {
            get { return requestId; }
            set { requestId = value; }
        }
    }
}

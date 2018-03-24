using System;

namespace IB.CSharpApiClient.Events
{
    public class ScannerEndEventArgs : EventArgs
    {
        public ScannerEndEventArgs(int requestId)
        {
             RequestId = requestId;
        }

        public int RequestId { get; private set; }
    }
}

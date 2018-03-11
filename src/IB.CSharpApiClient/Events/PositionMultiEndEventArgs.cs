/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace IB.CSharpApiClient.Events
{
    public class PositionMultiEndEventArgs : EventArgs
    {
        private int reqId;
        
        public PositionMultiEndEventArgs(int reqId)
        {
            ReqId = reqId;
        }

        public int ReqId
        {
            get { return reqId; }
            set { reqId = value; }
        }
    }
}

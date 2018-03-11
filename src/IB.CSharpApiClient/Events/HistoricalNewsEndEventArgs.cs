/* Copyright (C) 2017 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalNewsEndEventArgs : EventArgs
    {
        public int RequestId { get; private set; }
        public bool HasMore { get; private set; }

        public HistoricalNewsEndEventArgs(int requestId, bool hasMore)
        {
            this.RequestId = requestId;
            this.HasMore = hasMore;
        }
    }
}

/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalDataEndEventArgs : EventArgs
    {
        private int requestId;
        private string startDate;
        private string endDate;

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public int RequestId
        {
            get { return requestId; }
            set { requestId = value; }
        }
        
        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public HistoricalDataEndEventArgs(int requestId, string startDate, string endDate)
        {
            RequestId = requestId;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}

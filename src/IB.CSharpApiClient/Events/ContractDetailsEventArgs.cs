/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class ContractDetailsEventArgs : EventArgs
    {
        private int requestId;
        private IBApi.ContractDetails contractDetails;
        
        public ContractDetailsEventArgs(int requestId, IBApi.ContractDetails contractDetails)
        {
            RequestId = requestId;
            ContractDetails = contractDetails;
        }

        public ContractDetails ContractDetails
        {
            get { return contractDetails; }
            set { contractDetails = value; }
        }

        public int RequestId
        {
            get { return requestId; }
            set { requestId = value; }
        }
    }
}

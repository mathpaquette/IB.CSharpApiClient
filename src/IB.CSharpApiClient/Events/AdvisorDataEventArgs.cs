/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace IB.CSharpApiClient.Events
{
    public class AdvisorDataEventArgs : EventArgs
    {
        private int faDataType;
        private string data;
        
        public AdvisorDataEventArgs(int faDataType, string data)
        {
            FaDataType = faDataType;
            Data = data;
        }

        public int FaDataType
        {
            get { return faDataType; }
            set { faDataType = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}

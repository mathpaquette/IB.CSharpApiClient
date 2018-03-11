/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class FamilyCodesEventArgs : EventArgs
    {
        public FamilyCode[] FamilyCodes { get; private set; }

        public FamilyCodesEventArgs(FamilyCode[] familyCodes)
        {
            this.FamilyCodes = familyCodes;
        }
    }
}

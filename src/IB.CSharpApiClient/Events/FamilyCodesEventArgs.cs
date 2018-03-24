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

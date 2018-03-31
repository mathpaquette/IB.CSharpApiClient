using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class FamilyCodesEventArgs : EventArgs
    {
        public FamilyCodesEventArgs(FamilyCode[] familyCodes)
        {
            FamilyCodes = familyCodes;
        }

        public FamilyCode[] FamilyCodes { get; }

        public override string ToString()
        {
            return $"{nameof(FamilyCodes)}: {FamilyCodes}";
        }
    }
}
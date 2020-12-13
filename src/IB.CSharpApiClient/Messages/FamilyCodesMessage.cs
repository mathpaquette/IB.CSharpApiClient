using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class FamilyCodesMessage
    {
        public FamilyCode[] FamilyCodes { get; private set; }

        public FamilyCodesMessage(FamilyCode[] familyCodes)
        {
            FamilyCodes = familyCodes;
        }

        public override string ToString()
        {
            return $"{nameof(FamilyCodes)}: {FamilyCodes}";
        }
    }
}

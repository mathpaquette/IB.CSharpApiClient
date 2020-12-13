using System;

namespace IB.CSharpApiClient
{
    public class IBClientDefault
    {
        public static TimeSpan Timeout { get; } = TimeSpan.FromSeconds(2);
    }
}
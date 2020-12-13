using System;

namespace CSharpAPIClient
{
    public class IBClientDefault
    {
        public static TimeSpan Timeout { get; } = TimeSpan.FromSeconds(2);
    }
}
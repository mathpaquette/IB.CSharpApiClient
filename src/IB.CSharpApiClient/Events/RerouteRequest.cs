using System;

namespace IB.CSharpApiClient.Events
{
    public class RerouteRequest : EventArgs

    {
    public int RequestId { get; }
    public int ConditionId { get; }
    public string Exchange { get; }

    public RerouteRequest(int requestId, int conditionId, string exchange)
    {
        RequestId = requestId;
        ConditionId = conditionId;
        Exchange = exchange;
    }
    }
}
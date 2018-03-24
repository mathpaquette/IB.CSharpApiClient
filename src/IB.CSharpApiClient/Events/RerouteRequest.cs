using System;

namespace IB.CSharpApiClient.Events
{
    public class RerouteRequest : EventArgs

    {
    public int RequestId { get; private set; }
    public int ConditionId { get; private set; }
    public string Exchange { get; private set; }

    public RerouteRequest(int requestId, int conditionId, string exchange)
    {
        RequestId = requestId;
        ConditionId = conditionId;
        Exchange = exchange;
    }
    }
}
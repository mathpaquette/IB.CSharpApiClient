using System;

namespace IB.CSharpApiClient.Events
{
    public class TickReqParamsEventArgs : EventArgs
    {
        public TickReqParamsEventArgs(int tickerId, double minTick, string bboExchange, int snapshotPermissions)
        {
            TickerId = tickerId;
            MinTick = minTick;
            BboExchange = bboExchange;
            SnapshotPermissions = snapshotPermissions;
        }

        public int TickerId { get; }
        public double MinTick { get; }
        public string BboExchange { get; }
        public int SnapshotPermissions { get; }

        public override string ToString()
        {
            return $"{nameof(BboExchange)}: {BboExchange}, {nameof(MinTick)}: {MinTick}, {nameof(SnapshotPermissions)}: {SnapshotPermissions}, {nameof(TickerId)}: {TickerId}";
        }
    }
}
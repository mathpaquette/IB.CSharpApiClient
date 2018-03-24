using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class PositionEventArgs : EventArgs
    {
        public PositionEventArgs(string account, Contract contract, double pos, double avgCost)
        {
            Account = account;
            Contract = contract;
            Position = pos;
            AverageCost = avgCost;
        }

        public string Account { get; private set; }

        public Contract Contract { get; private set; }

        public double Position { get; private set; }

        public double AverageCost { get; private set; }
    }
}

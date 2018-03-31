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

        public string Account { get; }
        public Contract Contract { get; }
        public double Position { get; }
        public double AverageCost { get; }

        public override string ToString()
        {
            return $"{nameof(Account)}: {Account}, {nameof(AverageCost)}: {AverageCost}, {nameof(Contract)}: {Contract}, {nameof(Position)}: {Position}";
        }
    }
}
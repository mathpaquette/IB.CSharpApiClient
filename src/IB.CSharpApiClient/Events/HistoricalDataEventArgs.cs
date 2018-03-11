/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalDataEventArgs : EventArgs
    {
        protected int requestId;
        protected string date;
        protected double open;
        protected double high;
        protected double low;
        protected double close;
        protected long volume;
        protected int count;
        protected double wap;
        protected bool hasGaps;

        public int RequestId
        {
            get { return requestId; }
            set { requestId = value; }
        }
        
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        
        public double Open
        {
            get { return open; }
            set { open = value; }
        }
        

        public double High
        {
            get { return high; }
            set { high = value; }
        }
        
        public double Low
        {
            get { return low; }
            set { low = value; }
        }
        
        public double Close
        {
            get { return close; }
            set { close = value; }
        }
        
        public long Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public double Wap
        {
            get { return wap; }
            set { wap = value; }
        }

        public bool HasGaps
        {
            get { return hasGaps; }
            set { hasGaps = value; }
        }

        public HistoricalDataEventArgs(int reqId, IBApi.Bar bar)
        {
            RequestId = reqId;
            Date = bar.Time;
            Open = bar.Open;
            High = bar.High;
            Low = bar.Low;
            Close = bar.Close;
            Volume = bar.Volume;
            Count = bar.Count;
            Wap = bar.WAP;
        }
    }
}

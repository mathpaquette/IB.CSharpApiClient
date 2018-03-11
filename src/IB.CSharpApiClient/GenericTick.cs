namespace IB.CSharpApiClient
{
    public class GenericTick
    {
        /// <summary>
        /// Option Volume (currently for stocks)
        /// </summary>
        public const int OPTION_VOLUME = 100;

        /// <summary>
        /// Option Open Interest (currently for stocks)
        /// </summary>
        public const int OPTION_OPEN_INTEREST = 101;

        /// <summary>
        /// Historical Volatility (currently for stocks)
        /// </summary>
        public const int HISTORICAL_VOLATILITY = 104;

        /// <summary>
        /// Average Option Volume (currently for stocks)
        /// </summary>
        public const int AVERAGE_OPTION_VOLUME = 105;

        /// <summary>
        /// Option Implied Volatility (currently for stocks)
        /// </summary>
        public const int OPTION_IMPLIED_VOLATILITY = 106;

        /// <summary>
        /// Index Future Premium
        /// </summary>
        public const int INDEX_FUTURE_PREMIUM = 162;

        /// <summary>
        /// Miscellaneous Stats
        /// </summary>
        public const int MISCELLANEOUS_STATS = 165;

        /// <summary>
        /// Mark Price (used in TWS P&L computations)
        /// </summary>
        public const int MARK_PRICE = 221;

        /// <summary>
        /// Auction values (volume, price and imbalance)
        /// </summary>
        public const int AUCTION_VALUES = 225;

        /// <summary>
        /// RTVolume - contains the last trade price, last trade size, last trade time, total volume, VWAP, and single trade flag.
        /// </summary>
        public const int RTVOLUME = 233;

        /// <summary>
        /// Shortable
        /// </summary>
        public const int SHORTABLE = 236;

        /// <summary>
        /// Inventory
        /// </summary>
        public const int INVENTORY = 256;

        /// <summary>
        /// Fundamental Ratios
        /// </summary>
        public const int FUNDAMENTAL_RATIOS = 258;

        /// <summary>
        /// Realtime Historical Volatility
        /// </summary>
        public const int REALTIME_HISTORICAL_VOLATILITY = 411;

        /// <summary>
        /// IBDividends
        /// </summary>
        public const int IBDIVIDENDS = 456;
    }
}
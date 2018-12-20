using System;
using System.Collections.Generic;

namespace AddPositionEvents.Event
{
    public class Const
    {
        public static Guid BrokerId => Guid.Parse(""); //TODO
        public static Guid AggregateId => Guid.Parse(""); //TODO
        public static int ShardKey => 0; //TODO
        public static string IpAddress => ""; //TODO

        public static Dictionary<string, Guid> Symbols = new Dictionary<string, Guid>() {
            ["FB"] = Guid.Parse(""),
            ["AMZN"] = Guid.Parse(""),
            ["AAPL"] = Guid.Parse(""),
            ["NSDQ"] = Guid.Parse(""),
            ["FTSE"] = Guid.Parse(""),
            ["DAX"] = Guid.Parse(""),
            ["Microsoft"] = Guid.Parse(""),
            ["IBM"] = Guid.Parse(""),
            ["Netflix"] = Guid.Parse(""),
            ["TSLA"] = Guid.Parse("")
        };

        public static Dictionary<string, Guid> Instruments = new Dictionary<string, Guid>()
        {
            ["FB"] = Guid.Parse(""),
            ["AMZN"] = Guid.Parse(""),
            ["AAPL"] = Guid.Parse(""),
            ["NSDQ"] = Guid.Parse(""),
            ["FTSE"] = Guid.Parse(""),
            ["DAX"] = Guid.Parse(""),
            ["Microsoft"] = Guid.Parse(""),
            ["IBM"] = Guid.Parse(""),
            ["Netflix"] = Guid.Parse(""),
            ["TSLA"] = Guid.Parse("")
        };
    }
}

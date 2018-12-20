using AddPositionEvents.Event.Enums;
using System;

namespace AddPositionEvents.Event
{
    public class ForexPositionOpened
    {
        public Guid BrokerId { get; set; }
        public Guid PositionId { get; set; }
        public Guid SymbolId { get; set; }
        public string Instrument { get; set; }
        public Guid InstrumentId { get; set; }
        public double Units { get; set; }
        public ForexPositionDirection Direction { get; set; }
        public DateTime OpenTime { get; set; }
        public double OpenPrice { get; set; }
        public double ConvertedOpenRate { get; set; }
        public CommandSource Source { get; set; }
        public double? StopLoss { get; set; }
        public double? TakeProfit { get; set; }
        public DateTime? ExpireTime { get; set; }
        public int Leverage { get; set; }
        public double OpenVolume { get; set; }
        public double OpenMidPrice { get; set; }
        public bool IsDemo { get; set; }
        public Guid AggregateId { get; set; }
        public int Version { get; set; }
        public int ShardKey { get; set; }
        public double OpenUsdConversionRate { get; set; }
        public string IPAddress { get; set; }
    }
}

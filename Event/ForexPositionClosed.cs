using AddPositionEvents.Event.Enums;
using System;

namespace AddPositionEvents.Event
{
    public class ForexPositionClosed
    {
        public Guid AggregateId { get; set; }
        public int Version { get; set; }
        public int ShardKey { get; set; }
        public Guid BrokerId { get; set; }
        public Guid PositionId { get; set; }
        public string Instrument { get; set; }
        public Guid InstrumentId { get; set; }
        public double Units { get; set; }
        public double ClosePrice { get; set; }
        public double CloseMidPrice { get; set; }
        public double ConvertedClosePrice { get; set; }
        public DateTime CloseTime { get; set; }
        public ForexPositionCloseTrigger CloseTrigger { get; set; }
        public double Pnl { get; set; }
        public double CloseVolume { get; set; }
        public double ConversionRate { get; set; }
        public Guid SymbolId { get; set; }
        public int Leverage { get; set; }
    }
}

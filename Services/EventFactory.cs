using AddPositionEvents.Entities;
using AddPositionEvents.Event;
using AddPositionEvents.Event.Enums;
using System;
using System.Collections.Generic;

namespace AddPositionEvents.Services
{
    public class EventFactory
    {
        public List<ForexPositionOpened> FxOpened { get; set; } = new List<ForexPositionOpened>();
        public List<ForexPositionClosed> FxClosed { get; set; } = new List<ForexPositionClosed>();

        public void CreateFxOpenPosition(IEnumerable<CsvRecord> records, int version)
        {
            foreach(var r in records)
            {
                var posId = Guid.NewGuid();

                FxOpened.Add(new ForexPositionOpened() {
                    BrokerId = Const.BrokerId,
                    PositionId = Guid.NewGuid(),
                    SymbolId = Const.Symbols[r.InstrumentName],
                    Instrument = r.InstrumentName,
                    InstrumentId = Const.Symbols[r.InstrumentName],
                    Units = r.Units,
                    Direction = r.Direction,
                    OpenTime = r.EntryDate,
                    OpenPrice = r.OpenPrice,
                    ConvertedOpenRate = 1, //TODO
                    Source = CommandSource.Trader,
                    StopLoss = r.Sl,
                    TakeProfit = r.Tp,
                    ExpireTime = r.ExpireDate,
                    Leverage = 1, //todo
                    OpenVolume = 1, //todo
                    OpenMidPrice = r.OpenPrice,
                    IsDemo = false,
                    AggregateId = Const.AggregateId,
                    Version = ++version, //todo to check...
                    ShardKey = Const.ShardKey,
                    OpenUsdConversionRate = 1, //todo to check
                    IPAddress = Const.IpAddress
                });

                FxClosed.Add(new ForexPositionClosed() {
                    AggregateId = Const.AggregateId,
                    Version = ++version,
                    ShardKey = Const.ShardKey,
                    BrokerId = Const.BrokerId,
                    PositionId = posId,
                    Instrument = r.InstrumentName,
                    InstrumentId = Const.Symbols[r.InstrumentName],
                    Units = r.Units,
                    ClosePrice = r.ClosePrice,
                    CloseMidPrice = r.ClosePrice, //todo check
                    ConvertedClosePrice = 1, //todo check
                    CloseTime = r.EndDate,
                    CloseTrigger = ForexPositionCloseTrigger.Trader, //TODO 
                    Pnl = r.PnL,
                    CloseVolume = 1, //investm * leverate
                    ConversionRate = 1, //todo check
                    SymbolId = Const.Symbols[r.InstrumentName],
                    Leverage = 1 //todo check
                });
            }
        }
    }
}

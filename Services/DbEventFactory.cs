using AddPositionEvents.Entities;
using AddPositionEvents.Event;
using Newtonsoft.Json;
using System;

namespace AddPositionEvents.Services
{
    public class DbEventFactory
    {
        public DbShardEvent Convert(ForexPositionOpened p)
        {
            return new DbShardEvent()
            {
                AggregateId = p.AggregateId,
                ShardKey = p.ShardKey,
                AggregateType = "Account",
                EventType = "ForexPositionOpened", //todo check
                Data = JsonConvert.SerializeObject(p),
                Version = p.Version,
                CreationTime = DateTime.Now
            };
        }

        public DbShardEvent Convert(ForexPositionClosed p)
        {
            return new DbShardEvent()
            {
                AggregateId = p.AggregateId,
                ShardKey = p.ShardKey,
                AggregateType = "Account",
                EventType = "ForexPositionClosed", //todo check
                Data = JsonConvert.SerializeObject(p),
                Version = p.Version,
                CreationTime = DateTime.Now
            };
        }
    }
}

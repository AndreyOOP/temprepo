using System;

namespace AddPositionEvents.Entities
{
    public class DbShardEvent : IDbRecord
    {
        public Guid AggregateId { get; set; }
        public int ShardKey { get; set; }
        public string AggregateType { get; set; }
        public string EventType { get; set; }
        public string Data { get; set; }
        public int Version { get; set; }
        public DateTime CreationTime { get; set; }
    }
}

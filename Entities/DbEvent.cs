using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddPositionEvents.Entities
{
    public class DbEvent : IDbRecord
    {
        public Guid AggregateId { get; set; }

        public string AggregateType { get; set; }

        public string EventType { get; set; }

        public string Data { get; set; }

        public int Version { get; set; }

        public DateTime CreationTime { get; set; }
    }
}

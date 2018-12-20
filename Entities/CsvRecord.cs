using AddPositionEvents.Event.Enums;
using System;

namespace AddPositionEvents.Entities
{
    public class CsvRecord
    {
        public string Position { get; set; }

        public string Status { get; set; }

        public string InstrumentName { get; set; }

        public ForexPositionDirection Direction { get; set; }

        public double Investment { get; set; }

        public double Units { get; set; }

        public double OpenPrice { get; set; }

        public double PnL { get; set; }

        public double ClosePrice { get; set; }

        public string WonLost { get; set; }

        public DateTime EntryDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime ExpireDate { get; set; }

        public double SlAmount { get; set; }

        public double Sl { get; set; }

        public double Tp { get; set; }
    }
}

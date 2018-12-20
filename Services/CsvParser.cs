using AddPositionEvents.Entities;
using AddPositionEvents.Event.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AddPositionEvents.Services
{
    public class CsvParser
    {
        public IEnumerable<CsvRecord> Parse(string path)
        {
            var result = new List<CsvRecord>();

            foreach(var line in File.ReadAllLines(path).Skip(1))
            {
                var columns = line.Split('\t');

                result.Add(new CsvRecord() {
                    Position = columns[0],
                    Status = columns[1],
                    InstrumentName = columns[2],
                    Direction = GetDirection(columns[3]),
                    Investment = double.Parse(columns[4]),
                    Units = double.Parse(columns[5]),
                    OpenPrice = double.Parse(columns[6]),
                    PnL = double.Parse(columns[7].Replace(" ", "")),
                    ClosePrice = double.Parse(columns[8]),
                    WonLost = columns[9],
                    EntryDate = DateTime.Parse(columns[10]),
                    EndDate = DateTime.Parse(columns[11]),
                    ExpireDate = DateTime.Parse(columns[12]),
                    SlAmount = double.Parse(columns[13]),
                    Sl = double.Parse(columns[14]),
                    Tp = double.Parse(columns[15])
                });
            }

            return result;
        }

        private ForexPositionDirection GetDirection(string direction)
        {
            ForexPositionDirection value;
            Enum.TryParse(direction, true, out value);

            return value;
        }
    }
}

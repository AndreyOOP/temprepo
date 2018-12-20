using AddPositionEvents.DataProvider;
using AddPositionEvents.Entities;
using AddPositionEvents.Services;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace AddPositionEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvPath = @"D:\3. Repositories\PositionProject\positions.tsv";
            var csvParser = new CsvParser();
            var eventFactory = new EventFactory();
            var dbFactory = new DbEventFactory();
            var dataP = new DataProviderx();

            var csvRecords = csvParser.Parse(csvPath);

            int v = dataP.GetVersion();
            eventFactory.CreateFxOpenPosition(csvRecords, v); //todo set version via query

            var open = eventFactory.FxOpened.Select(p => dbFactory.Convert(p));
            var close = eventFactory.FxClosed.Select(p => dbFactory.Convert(p));

            //todo add monetary transactions

            dataP.Save(open);
            dataP.Save(close);
        }
    }
}

using AddPositionEvents.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using Dapper;

namespace AddPositionEvents.DataProvider
{
    public class DataProviderx
    {
        private static string _insertShardEventCommand 
            = @"";

        public void Save(IEnumerable<IDbRecord> records)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["EventStoreConnection"].ConnectionString;

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(_insertShardEventCommand, records);
            }
        }

        public int GetVersion()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["EventStoreConnection"].ConnectionString;

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<int>("").First();
            }
        }
    }
}

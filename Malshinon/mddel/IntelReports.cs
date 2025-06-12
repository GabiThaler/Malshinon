using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Malshinon.mddel
{
    public class IntelReports
    {
        public int Id;

        public int ReporterId;

        public int TargetId;

        public string Text;

        public DateTime Timestamp;


        public IntelReports CreatFromRedere(MySqlDataReader reder)
        {
            reder.Read();
            IntelReports Intel = new IntelReports
            {
                Id = reder.GetInt32("id"),
                ReporterId = reder.GetInt32("reporter_id"),
                TargetId = reder.GetInt32("target_id"),
                Text = reder.GetString("text"),
                Timestamp = reder.GetDateTime("TIMESTAMP")
            };
            return Intel;
        }
    }
    }

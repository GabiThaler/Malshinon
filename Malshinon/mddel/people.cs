using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Malshinon.mddel
{
    public class People
    {
        public int Id;
        public string FristName;
        public string LastName;
        public string SecretCode;
        public string Type;
        public int NumReports;
        public int NumMentions;


        public People CreatFromRedere(MySqlDataReader reder)
        {
            reder.Read();
            People people = new People
            {
                FristName = reder.GetString("frist_name"),
                LastName = reder.GetString("last_name"),
                SecretCode = reder.GetString("secert_cod"),
                Type = reder.GetString("type"),
                NumReports = reder.GetInt32("num_reports"),
                NumMentions = reder.GetInt32("um_mentions")
            };
            return people;

        }

        public void IncReports()
        {
            NumReports += 1;
        }

        public void IncMentions()
        {

            NumMentions += 1;
        }


    }
}

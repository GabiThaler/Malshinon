using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Malshinon.DataBase;
using Malshinon.mddel;
using MySql.Data.MySqlClient;

namespace Malshinon.DAL
{

    internal class PeopleDal
    {
        private MySqlData _msd;
        public PeopleDal(MySqlData MSD)
        {
            _msd = MSD;
        }



        public List<People> GetPeoples()
        {
            List<People> AllPeople = new List<People>();
            try
            {
                
                var connect = _msd.GetConnect();
                string query = "SELECT * FROM people";
                var cmd = new MySqlCommand(query, connect);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AllPeople.Add(new People 
                    {
                        SecretCode = reader.GetString("secert_cod"),
                        FristName = reader.GetString("frist_name"),
                        LastName = reader.GetString("last_name"),
                        NumReports = reader.GetInt32("num_reports"),
                        NumMentions = reader.GetInt32("um_mentions"),
                        Type = reader.GetString("type")

                    }
                    );
                    return AllPeople;

                }

                _msd.CloseConnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR by geting all: {ex.Message}");
            }
            return AllPeople;
        }


        public void AddPeople(People newPerson)
        {
            try
            {
                var connect = _msd.GetConnect();
                string qury = @"INSERT INTO people 
                            (frist_name,last_name,num_reports,secert_cod,type,um_mentions)
                            VALUES(@frist_name,@last_name,@num_reports,@secert_cod,type,@um_mentions)";
                MySqlCommand cmd = new MySqlCommand(qury, connect);
                cmd.Parameters.AddWithValue("@frist_name", newPerson.FristName);
                //cmd.Parameters.AddWithValue("@id", newPerson.Id);
                cmd.Parameters.AddWithValue("@last_name", newPerson.LastName);
                cmd.Parameters.AddWithValue("@num_reports", newPerson.NumReports);
                cmd.Parameters.AddWithValue("@secert_cod", newPerson.SecretCode);
                cmd.Parameters.AddWithValue("@type", newPerson.Type);
                cmd.Parameters.AddWithValue("@um_mentions", newPerson.NumMentions);
                cmd.ExecuteReader();
                connect.Close();
            }
            
            catch(Exception ex)
            {
                Console.WriteLine($"didnt mange to insert. {ex.Message}");
            }
        }
    }
}

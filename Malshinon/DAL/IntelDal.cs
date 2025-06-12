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
    public class IntelDal
    {
        private MySqlData _msd;
        public IntelDal(MySqlData MSD)
        {
            _msd = MSD;
        }
        public void InsertIntel(IntelReports report)
        {
            try
            {
                var conn = _msd.GetConnect();
                string query = @"INSERT INTO intelreports
                        (reporter_id,target_id,text,TIMESTAMP) 
                        VALUES(@reporter_id,@target_id,@text,@TIMESTAMP)";
                var SqlCommend = new MySqlCommand(query, conn);
                SqlCommend.Parameters.AddWithValue("@reporter_id", report.ReporterId);
                SqlCommend.Parameters.AddWithValue("@target_id", report.TargetId);
                SqlCommend.Parameters.AddWithValue("@text", report.Text);
                SqlCommend.Parameters.AddWithValue("@TIMESTAMP", report.Timestamp);
                var reader = SqlCommend.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR in INTEL{ex.Message}");
            }
            finally
            {
                _msd.CloseConnect();
            }
        }

        public IntelReports getReportById(int id)
        {
            IntelReports TheIntel = new IntelReports();
            try
            {
                var conn = _msd.GetConnect();
                string qury = $"SELECT * FROM intelreports WHERE ID ='{id}'";
                var cmd = new MySqlCommand(qury, conn);
                var reder = cmd.ExecuteReader();
                TheIntel = TheIntel.CreatFromRedere(reder);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"ERROR by geting intel {ex.Message}");
            }finally
            {
                _msd.CloseConnect();
            }
            return TheIntel;
        }
    }
}

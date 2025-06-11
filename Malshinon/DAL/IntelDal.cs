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
                        (reporter_id,target_id,texr,TIMESTAMP) 
                        VALUES(@reporter_id,@target_id,@text,@TIMESTAMP)";
                var SqlCommend = new MySqlCommand(query, conn);
                SqlCommend.Parameters.AddWithValue("@ReporterId", report.ReporterId);
                SqlCommend.Parameters.AddWithValue("@TargatId", report.TargetId);
                SqlCommend.Parameters.AddWithValue("@Text", report.Text);
                SqlCommend.Parameters.AddWithValue("@TIMESTAMP", report.Timestamp);
                var reader = SqlCommend.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

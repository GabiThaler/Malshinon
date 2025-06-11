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
    internal class IntelDal
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
                        (ReporterId, TargatId, Text) 
                        VALUES(@ReporterId, @TargatId, @Text)";
                var SqlCommend = new MySqlCommand(query, conn);
                SqlCommend.Parameters.AddWithValue("@ReporterId", report.ReporterId);
                SqlCommend.Parameters.AddWithValue("@TargatId", report.TargetId);
                SqlCommend.Parameters.AddWithValue("@Text", report.Text);
                var reader = SqlCommend.ExecuteReader();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

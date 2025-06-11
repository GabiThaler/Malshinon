using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Malshinon.mddel;
using Malshinon.DataBase;
using Malshinon.DAL;


namespace Malshinon.menu
{
    public class HelpMenu
    {

        static MySqlData ms = new MySqlData();
        private PeopleDal pd = new PeopleDal(ms);
        public IntelDal ID = new IntelDal(ms);
        public void InsertReport()
        {
            Console.WriteLine("Plese enter youer secert cod");
            string CodName = Console.ReadLine();
            People reporte = pd.FindBySecertCod(CodName);
            Console.WriteLine("please enter the secret cod of Target");
            string TcodName = Console.ReadLine();
            People Target = pd.FindBySecertCod(TcodName);
            Console.WriteLine("Enter the REPORT");
            IntelReports intel = new IntelReports
            {
                ReporterId = CodName,
                TargetId = TcodName,
                Text = Console.ReadLine(),
                Timestamp = DateTime.Now
            };
            ID.InsertIntel(intel);
            reporte.IncReports();
            Target.IncMentions();




        }
    }
}

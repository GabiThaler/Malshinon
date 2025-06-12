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
            if (reporte == null)
            {
                reporte = creatPerson(CodName);
                pd.AddPeople(reporte);
                reporte = pd.FindBySecertCod(CodName);
            }
            Console.WriteLine("please enter the secret cod of Target");
            string TcodName = Console.ReadLine();
            People Target = pd.FindBySecertCod(TcodName);
            if (Target == null)
            {
                Target = creatPerson(TcodName);
                pd.AddPeople(Target);
                Target = pd.FindBySecertCod(TcodName);
            }
            Console.WriteLine("Enter the REPORT");
            IntelReports intel = new IntelReports
            {
                ReporterId = reporte.Id,
                TargetId = Target.Id,
                Text = Console.ReadLine(),
                Timestamp = DateTime.Now
            };
            ID.InsertIntel(intel);
            reporte.IncReports();
            Target.IncMentions();
            pd.UpdateToSql(reporte);
            pd.UpdateToSql(Target);
        }
        public void PrintToConsokeAllPeople()
        {
            List<People> AllPeople = new List<People>();
            AllPeople = pd.GetPeoples();
            foreach (People p in AllPeople)
            {
                Console.WriteLine($"frist name:{p.FristName}. last name:{p.LastName}. secret cod:{p.SecretCode}. type:{p.Type} num of reports:{p.NumReports}. num of mintions:{p.NumMentions}");

            }
        }
        public People creatPerson(string cod)
        {
            People person = new People();
            Console.WriteLine("enter the firsr name:");
            string FName = Console.ReadLine();
            Console.WriteLine("enter the Last name:");
            string LName = Console.ReadLine();
            Console.WriteLine("enter youer type:");
            string type = Console.ReadLine();
            person = new People
            {
                FristName = FName,
                LastName = LName,
                Type = type,
                SecretCode = cod

            };
            return person;
        }
        public void PrintIntel(int id)
        {
            IntelReports report = ID.getReportById(id);
            Console.WriteLine($"id:{report.Id}. reporter id:{report.ReporterId}. target id:{report.TargetId}. the report:{report.Text}. time of report:{report.Timestamp}");
        }

        public void PrintToConsoleRepoters()
        {
            List<People> AllPeople = new List<People>();
            Console.WriteLine("Enter type to serch:");
            string tts = Console.ReadLine();
            AllPeople = pd.GetAllREporters(tts);
            foreach (People p in AllPeople)
            {
                Console.WriteLine($"frist name:{p.FristName}. last name:{p.LastName}. secret cod:{p.SecretCode}. type:{p.Type} num of reports:{p.NumReports}. num of mintions:{p.NumMentions}");

            }
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malshinon.menu
{
    public class Manu
    {

        public void Manager()
        {
            
            HelpMenu hp = new HelpMenu();
            bool flag = true;
            while (flag)
            {
                VewMenu();
                string coice = Console.ReadLine();

                switch (coice)
                {
                    case "1":
                        {
                            hp.PrintToConsokeAllPeople();
                            break;
                        }
                    case "2":
                        {
                            hp.PrintToConsoleRepoters();
                            break;
                        }
                    case "3":
                        {
                            hp.InsertReport();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("enter id of report:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            hp.PrintIntel(id);
                            break; 
                        }
                    case "0":
                        {
                            flag = false;
                            break;
                        }

                }
            }
        }

        public void VewMenu()
        {
            Console.WriteLine("click 1 to get all people:");
            Console.WriteLine("click 2 to get  all people by type:");
            Console.WriteLine("click 3 to Enter a report:");
            Console.WriteLine("click 4 to get a report by id:");
            Console.WriteLine("click 0 to exit:");

        }
    }
}

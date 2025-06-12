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
                            hp.InsertReport();
                            break;
                        }
                    case "3":
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
            Console.WriteLine("click 2 to Enter a report:");
            Console.WriteLine("click 3 to get a report by id:");
            Console.WriteLine("click 0 to exit:");

        }
    }
}

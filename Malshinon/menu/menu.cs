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

                            break;
                        }
                    case "2":
                        {
                            hp.InsertReport();
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
            Console.WriteLine("Price 1 to get all people:");
            Console.WriteLine("price 2 to Enter a report:");
            Console.WriteLine("price 0 to exit:");

        }
    }
}

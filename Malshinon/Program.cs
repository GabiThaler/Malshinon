using System;
using  Malshinon.mddel;
using  Malshinon.DataBase;

namespace Malshinon;
class program
{
    static void Main(string[] arcs)
    {
        MySqlData ms = new MySqlData();
        ms.connect();
    }
}
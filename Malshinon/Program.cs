using System;
using Malshinon.mddel;
using Malshinon.DataBase;
using Malshinon.DAL;

namespace Malshinon;
class program
{
    static void Main(string[] arcs)
    {

        MySqlData ms = new MySqlData();
        //ms.CloseConnect();
        PeopleDal pd = new PeopleDal(ms);
        People pe =new People
        {
        FristName="Gabi",
        LastName ="Thaler",
        SecretCode="G6g49w",
        Type= "reporter",
        NumReports=1,
        NumMentions=0
        };
        //Console.WriteLine( pd.FindBySecertCod("sdqwas").NumMentions);
        //pd.AddPeople(pe);
        Console.WriteLine(pd.GetPeoples().Count);
        Console.WriteLine(pd.GetPeoples()[1].SecretCode);
        Console.WriteLine(pd.GetPeoples()[2].SecretCode);
        Console.WriteLine(pd.GetPeoples()[0].SecretCode);
        Console.WriteLine(pd.GetPeoples()[3].SecretCode);
        Console.WriteLine(pd.GetPeoples()[4].SecretCode);
        Console.WriteLine(pd.GetPeoples()[5].SecretCode);

        //ms.connect();
        //ms.GetConnect();
        //ms.CloseConnect();
        //ms.CloseConnect();
    }
}
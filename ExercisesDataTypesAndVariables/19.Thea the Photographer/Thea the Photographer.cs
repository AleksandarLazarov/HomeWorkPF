using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            int snimki = int.Parse(Console.ReadLine());
            int secFilter = int.Parse(Console.ReadLine());
            int procentDobriSnimki = int.Parse(Console.ReadLine());
            int vremeKachvanePic = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());

            if ((snimki >= 0 && snimki <= 1000000) &&
               (secFilter >= 0 && secFilter <= 100000) &&
               (procentDobriSnimki >= 0 && procentDobriSnimki <= 100) &&
               (vremeKachvanePic >= 0 && vremeKachvanePic <= 100000))
            {

                double secFilterObshto = snimki * secFilter;
                double snimkiZaKachvane = Math.Ceiling(snimki * (procentDobriSnimki / 100.0));

                double secObshtoDec = secFilterObshto + snimkiZaKachvane * vremeKachvanePic;
                double secObshto = secObshtoDec;
                double day = secObshto / 86400;
                double chas = (secObshto % 86400) / 3600;
                double min = ((secObshto % 86400) % 3600) / 60;
                double ostavashtiSec = (((secObshto % 86400) % 3600) % 60) % 60;
                Console.WriteLine("{0}:{1:00}:{2:00}:{3:00}", Math.Floor(day), Math.Floor(chas), Math.Floor(min), Math.Ceiling(ostavashtiSec));
            }

        }
    }

}
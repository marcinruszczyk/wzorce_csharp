using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadStrategyChoice
{

    class Program
    {
        static void Main(string[] args)
        {

             NumerekFlow nf1 = new NumerekFlow(new Fromlocaldisk());  // [strategia 1]  - otwieram z lokalnego dysku 
             Console.WriteLine(nf1.Strategy.GetData(2));              // pliki mają numery  od 0 do 3 
            //  NumerekFlow nf2 = new NumerekFlow(new ViaNetStrategy());  // [strategia 2] - ściągam ze strony miasta gdańsk 
            //  Console.WriteLine(nf2.Strategy.GetData(0));

        }
    }
}

using System.Net.Http;

namespace DownloadStrategyChoice
{
    public class ViaNetStrategy : IDownloadStrategy
    {
       public string GetData(int numzom)
        {
            var client = new HttpClient();
            var xml = client.GetStringAsync("http://www.gdansk.pl/files/xml/qmatic-zom"+numzom+".xml").Result;
            System.Console.WriteLine("Dane pobrane z sieci");
            System.Console.WriteLine("*********************************");

            return xml;
        }
    }
}

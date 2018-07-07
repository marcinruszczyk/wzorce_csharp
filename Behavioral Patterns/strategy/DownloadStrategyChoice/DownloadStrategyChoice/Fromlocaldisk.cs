using System.IO;
using System.Xml;
using System.Text;

namespace DownloadStrategyChoice
{
    public class Fromlocaldisk : IDownloadStrategy
    {
        public string GetData(int numzom)
        {
            // var test = System.Environment.CurrentDirectory;
            // System.Console.WriteLine(test);

            using (XmlReader reader = XmlReader.Create(@"..\\..\\XML\\qmatic-zom" + numzom + ".xml"))
            //using (XmlReader reader = XmlReader.Create(@"C:\\XMLE\\qmatic-zom"+numzom+".xml"))
            {
                StringBuilder builder = new StringBuilder();

                builder.AppendLine("Dane pobrane z lokalnego pliku");

                while (reader.Read())

                {
                    if (reader.IsStartElement())

                    {
                    
                        switch (reader.Name.ToString())

                        {

                            case "LP":
                                builder.AppendLine("**********************************");
                                builder.AppendLine(reader.Value);
                                builder.AppendLine("Kolejny numer Lp : " + reader.ReadString());
                                break;

                            case "LITERAGRUPY":
                                builder.AppendLine(reader.Value);
                                builder.AppendLine("Litera Grupy : " + reader.ReadString());
                               break;

                            case "NAZWAGRUPY":
                                builder.Append(reader.Value);
                                builder.AppendLine("Nazwa Grupy : " + reader.ReadString());
                                break;

                            case "LICZBAKLWKOLEJCE":
                                 builder.Append(reader.Value);
                                 builder.AppendLine("Liczba osób w kolejce : " + reader.ReadString());
                                break;
                          }

                    }
               }
                return builder.ToString();
            }




        }
    }
}

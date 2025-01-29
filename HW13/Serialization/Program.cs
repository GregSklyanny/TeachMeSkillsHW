using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputDirectory = Directory.GetCurrentDirectory() + "/inputdata";
            var jsonFiles = Directory.GetFiles(inputDirectory, "*.json");
            Squad squad = null;
            foreach (string file in jsonFiles)
            {
                try
                {
                    using (FileStream fs = new FileStream(jsonFiles[0], FileMode.Open))
                    {
                        squad = JsonSerializer.Deserialize<Squad>(fs);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Squad));
                    string outputXMLFile = inputDirectory + $"/{squad.SquadName}.xml";
                    using (FileStream fs = new FileStream(outputXMLFile, FileMode.OpenOrCreate))
                    {
                        xmlSerializer.Serialize(fs, squad);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }               
        }
    }
}

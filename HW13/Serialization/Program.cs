using System.Diagnostics;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputDirectory = Utils.CheckOrCreateDirectory(Directory.GetCurrentDirectory() + "\\inputdata\\");
            string outputDirectory = Utils.CheckOrCreateDirectory(Directory.GetCurrentDirectory() + "\\outputdata\\");
            var jsonFiles = Directory.GetFiles(inputDirectory, "*.json");
            Squad squad;

            foreach (string file in jsonFiles)
            {
                squad = Utils.DeserializeJSON<Squad>(file);
                if (squad != null) Utils.SerializeXML<Squad>(outputDirectory + $"{squad.SquadName}.xml", squad);
            }               
        }
    }
}

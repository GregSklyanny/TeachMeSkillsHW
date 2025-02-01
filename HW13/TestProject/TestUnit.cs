using Serialization;
using System.Runtime.CompilerServices;

namespace TestProject
{
    [CollectionDefinition("Non-parallel", DisableParallelization = true)]

    [Collection("Non-parallel")]
    public class TestUnit
    {
        
        [Fact]
        public void TestJSONDeserialization()
        {
            string inputDirectory = Utils.CheckOrCreateDirectory(@"C:\Users\user\source\repos\TeachMeSkillsHW\HW13\Serialization\bin\Debug\net8.0\inputdata");
            var jsonFiles = Directory.GetFiles(inputDirectory, "*.json");
            Squad squad = Utils.DeserializeJSON<Squad>(jsonFiles[0]);
            Assert.NotNull(squad);
            Assert.Equal(squad.HomeTown, "Metro City");
            Assert.Equal(squad.Formed, 2016);
            Assert.Equal(squad.Members.Count, 3);           
        }
    }

    [Collection("Non-parallel")]
    public class XMLSerializer
    {
        [Fact]
        public void TestXMLSerialization()
        {
            string inputDirectory = Utils.CheckOrCreateDirectory(@"C:\Users\user\source\repos\TeachMeSkillsHW\HW13\Serialization\bin\Debug\net8.0\inputdata");
            var jsonFiles = Directory.GetFiles(inputDirectory, "*.json");
            Squad squad = Utils.DeserializeJSON<Squad>(jsonFiles[0]);
            string outputDirectory = Utils.CheckOrCreateDirectory(Directory.GetCurrentDirectory() + "\\outputdata\\");
            Assert.True(Utils.SerializeXML<Squad>(outputDirectory + "Super hero squad.xml", squad));
            Assert.Equal(File.ReadAllText(Directory.GetFiles(outputDirectory, "*.xml")[0]), File.ReadAllText(Directory.GetCurrentDirectory() + "\\examples\\Super hero squad.xml"));
        }
    }
}
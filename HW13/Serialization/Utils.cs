using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    public class Utils
    {
        public static T DeserializeJSON<T>(string path)
        {
            T output = default(T);
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    output = JsonSerializer.Deserialize<T>(fs);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return output;
        }

        public static bool SerializeXML<T>(string path, T data)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, data);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static string CheckOrCreateDirectory(string path)
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            return path;
        }
        public static string GetProjectDirectory() => Directory.GetCurrentDirectory();
    }
}

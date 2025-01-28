using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Serialization
{
    public class Squad
    {
        [JsonPropertyName("squadName")]
        public string SquadName { get; set; }
        [JsonPropertyName("homeTown")]
        public string HomeTown { get; set; }
        [JsonPropertyName("formed")]
        public int Formed {  get; set; }
        [JsonPropertyName("secretBase")]
        public string SecretBase { get; set; }
        [JsonPropertyName("active")]
        public bool Active { get; set; }
        [JsonPropertyName("members")]
        public List<Member> Members { get; set; }

    }
    public class Member
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("age")]
        public int Age { get; set; }
        [JsonPropertyName("secretIdentity")]
        public string SecretIdentity { get; set; }
        [JsonPropertyName("powers")]
        public List<string> Powers { get; set; }
    }
    
}

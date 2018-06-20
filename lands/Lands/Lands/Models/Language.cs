using Newtonsoft.Json;

namespace Lands.Models
{
    class Language
    {
        [JsonProperty(PropertyName = "code")]
        public string iso639_1 { get; set; }
        public string iso639_2 { get; set; }
        public string name { get; set; }
        public string nativeName { get; set; }
    }
}

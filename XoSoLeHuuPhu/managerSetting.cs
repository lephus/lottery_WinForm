using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace XoSoLeHuuPhu
{
    public class managerSetting
    {
        [JsonProperty("Hour")]
        public string Hour { get; set; }

        [JsonProperty("Minute")]
        public string Minute { get; set; }

        [JsonProperty("Second")]
        public string Second { get; set; }
        public string ToJson()
        {
            return "{" +
                "'Hour':'" + Hour + "'," +
                 "'Minute':'" + Minute + "'," +
                 "'Second':'" + Second + "'," +
               "},";
        }
    }
}

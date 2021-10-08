using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace XoSoLeHuuPhu
{
    public partial class objLottery
    {
        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("DateTime")]
        public string DateTime { get; set; }

        [JsonProperty("Rank8")]
        public string Rank8 { get; set; }

        [JsonProperty("Rank7")]
        public string Rank7 { get; set; }

        [JsonProperty("Rank6")]
        public string Rank6 { get; set; }

        [JsonProperty("Rank5")]
        public string Rank5 { get; set; }

        [JsonProperty("Rank4")]
        public string Rank4 { get; set; }

        [JsonProperty("Rank3")]
        public string Rank3 { get; set; }

        [JsonProperty("Rank2")]
        public string Rank2 { get; set; }

        [JsonProperty("Rank1")]
        public string Rank1 { get; set; }

        [JsonProperty("RankDB")]
        public string RankDb { get; set; }

        [JsonProperty("Core")]
        public long Core { get; set; }

        public String ToJson()
        {
            return "{" +
                 "'City':'"+City+"',"+
                  "'DateTime':'" +DateTime+ "'," +
                  "'Rank8':'" +Rank8+ "'," +
                  "'Rank7':'" + Rank7 + "'," +
                  "'Rank6':'" + Rank6 + "'," +
                  "'Rank5':'" + Rank5 + "'," +
                  "'Rank4':'" + Rank4 + "'," +
                  "'Rank3':'" + Rank3 + "'," +
                  "'Rank2':'" + Rank2 + "'," +
                  "'Rank1':'" + Rank1 + "'," +
                  "'RankDB':'" + RankDb + "'," +
                  "'Core':'" + Core + "'," +
                "},";
        }
    }
}

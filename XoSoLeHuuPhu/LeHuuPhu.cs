using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoSoLeHuuPhu
{
    class LeHuuPhu
    {
        string fileName = @"E:\databaseLottery.json";
        public String baseTitle = "XSMT » XSDNG » Xổ số";
        public List<objLottery> DaNangs = new List<objLottery>();
        public List<objLottery> QuangNams = new List<objLottery>();
        public String dataJson = "";
        public int timeDelayDaNang = 5000;
        public int timeDelayDaNangCount = 0;
        public int autoNextRankDaNang = 8;
        public int timeDelayQuangNam = 5000;
        public int timeDelayQuangNamCount = 0;
        public int autoNextRankQuangNam = 8;
        public bool DaNangIsRunNow = false;
        public bool QuangNamIsRunNow = false;
        public bool ActionLogin(String s1, String s2)
        {
            if (s1.Equals("admin") && s2.Equals("123")) return true;
            return false;
        }

        
        public void readDataJson()
        {
            try
            {    
                if (File.Exists(fileName))
                {
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        String s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                            dataJson += s;
                        }
                    }
                }
                else
                {
                    FileStream fs = File.Create(fileName);

                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            try
            {
                JArray json = JArray.Parse(dataJson);
                foreach (JObject element in json)
                {
                    objLottery tmp = new objLottery();
                    tmp.City = (string)element["City"];
                    tmp.DateTime = (String)element["DateTime"];
                    tmp.Rank8 = (string)element["Rank8"];
                    tmp.Rank7 = (string)element["Rank7"];
                    tmp.Rank6 = (string)element["Rank6"];
                    tmp.Rank5 = (string)element["Rank5"];
                    tmp.Rank4 = (string)element["Rank4"];
                    tmp.Rank3 = (string)element["Rank3"];
                    tmp.Rank2 = (string)element["Rank2"];
                    tmp.Rank1 = (string)element["Rank1"];
                    tmp.RankDb = (string)element["RankDB"];
                    tmp.Core = (long)element["Core"];
                    if (tmp.City.Equals("DaNang"))
                    {
                        DaNangs.Add(tmp);
                    }
                    else
                    {
                        QuangNams.Add(tmp);
                    }
                }
            } catch (Exception)
            {
                Console.WriteLine("No data");
            }
            
        }
        public void writeDataJson()
        {
            String s = "[";
            foreach (objLottery element in DaNangs)
            {
                s+=(element.ToJson());
            }
            foreach (objLottery element in QuangNams)
            {
                s += (element.ToJson());
            }
            s += "]";
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(s);
                }
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
            }
        }
    }
}

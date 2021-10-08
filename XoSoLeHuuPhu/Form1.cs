using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XoSoLeHuuPhu
{
    public partial class Form1 : Form
    {
        Random _random = new Random();
        LeHuuPhu clsLeHuuPhu = new LeHuuPhu();
        FormManager formManager = new FormManager();
        DateTime dateTime = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
            comboBoxAddItem();
            clsLeHuuPhu.readDataJson();
            SetDataWithDateTime(dateTime);
            formManager.Show(this);
            RealTimeDaNang.Start();
            RealTimeQuangNam.Start();
            timer1.Start();
        }

        void comboBoxAddItem()
        {
            comboBox1.Items.Add("ĐÀ NẴNG");
            comboBox1.Items.Add("QUẢNG NAM");
        }
        private void buttonQuangNam_Click(object sender, EventArgs e)
        {
            int change = 0 + flowLayoutPanel1.VerticalScroll.Maximum;
            flowLayoutPanel1.AutoScrollPosition = new Point(0, change);
            clsLeHuuPhu.writeDataJson();
        }

        private void buttonDaNang_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScrollPosition = new Point(0, 0);
        }

        public void SetDataWithDateTime(DateTime time)
        {
            Console.WriteLine(time);
            bool checkDN = true;
            foreach(objLottery element in clsLeHuuPhu.DaNangs)
            {
                String[] myDataTime = element.DateTime.Split('/');
                if (time.Year == int.Parse(myDataTime[2]) && time.Month == int.Parse(myDataTime[1]) && time.Day == int.Parse(myDataTime[0]))
                {
                    checkDN = false;
                    SetTextLabelDaNang(element, element.DateTime);
                    break;
                }
            }
            bool checkQN = true;
            foreach (objLottery element in clsLeHuuPhu.QuangNams)
            {
                String[] myDataTime = element.DateTime.Split('/');
                if (time.Year == int.Parse(myDataTime[2]) && time.Month == int.Parse(myDataTime[1]) && time.Day == int.Parse(myDataTime[0]))
                {
                    checkQN = false;
                    SetTextLabelQuangNam(element, element.DateTime);
                    break;
                }
            }
            objLottery tmp = new objLottery();
            tmp.City = "ĐÀ NẴNG";
            tmp.DateTime = time.ToString("dd/MM/yyyy");
            tmp.Rank8 = "XX";
            tmp.Rank7 = "XXX";
            tmp.Rank6 = "XXXX-XXXX-XXXX";
            tmp.Rank5 = "XXXX";
            tmp.Rank4 = "XXXXX-XXXXX-XXXXX-XXXXX-XXXXX-XXXXX-XXXXX";
            tmp.Rank3 = "XXXXX-XXXXXX";
            tmp.Rank2 = "XXXXX";
            tmp.Rank1 = "XXXXX";
            tmp.RankDb = "XXXXXX";
            tmp.Core = 10000;
            if(checkDN) SetTextLabelDaNang(tmp, tmp.DateTime);
            if(checkQN) SetTextLabelQuangNam(tmp, tmp.DateTime);

        }
        public void SetTextLabelDaNang(objLottery element, String time)
        {
            String[] rank6 = element.Rank6.Split('-');
            String[] rank4 = element.Rank4.Split('-');
            String[] rank3 = element.Rank3.Split('-');
            labelGiai8DaNang.Text = element.Rank8;
            llabelGiai7DaNang.Text = element.Rank7;
            labelGiai6_1DaNang.Text = rank6[0];
            labelGiai6_2DaNang.Text = rank6[1];
            labelGiai6_3DaNang.Text = rank6[2];
            labelGiai5DaNang.Text = element.Rank5;
            labelGiai4_1DaNang.Text = rank4[0];
            labelGiai4_2DaNang.Text = rank4[1];
            labelGiai4_3DaNang.Text = rank4[2];
            labelGiai4_4DaNang.Text = rank4[3];
            labelGiai4_5DaNang.Text = rank4[4];
            labelGiai4_6DaNang.Text = rank4[5];
            labelGiai4_7DaNang.Text = rank4[6];
            labelGiai3_1DaNang.Text = rank3[0];
            labelGiai3_2DaNang.Text = rank3[1];
            labelGiai2DaNang.Text = element.Rank2;
            labelGiai1DaNang.Text = element.Rank1;
            labelGiaiDBDaNang.Text = element.RankDb;
            labelTitleDaNang.Text = clsLeHuuPhu.baseTitle + " ĐÀ NẴNG " + time;
        }
        public void SetTextLabelQuangNam(objLottery element, String time)
        {
            String[] rank6 = element.Rank6.Split('-');
            String[] rank4 = element.Rank4.Split('-');
            String[] rank3 = element.Rank3.Split('-');
            labelGiai8QuangNam.Text = element.Rank8;
            labelGiai7QuangNam.Text = element.Rank7;
            labelGiai6_1QuangNam.Text = rank6[0];
            labelGiai6_2QuangNam.Text = rank6[1];
            labelGiai6_3QuangNam.Text = rank6[2];
            labelGiai5QuangNam.Text = element.Rank5;
            labelGiai4_1QuangNam.Text = rank4[0];
            labelGiai4_2QuangNam.Text = rank4[1];
            labelGiai4_3QuangNam.Text = rank4[2];
            labelGiai4_4QuangNam.Text = rank4[3];
            labelGiai4_5QuangNam.Text = rank4[4];
            labelGiai4_6QuangNam.Text = rank4[5];
            labelGiai4_7QuangNam.Text = rank4[6];
            labelGiai3_1QuangNam.Text = rank3[0];
            labelGiai3_2QuangNam.Text = rank3[1];
            labelGiai2QuangNam.Text = element.Rank2;
            labelGiai1QuangNam.Text = element.Rank1;
            labelGiaiDBQuangNam.Text = element.RankDb;
            labelTitleQuangNam.Text = clsLeHuuPhu.baseTitle + " QUẢNG NAM " + time;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(formManager.DaNangIsRunNow == false && formManager.QuangNamIsRunNow == false)
            {
                SetDataWithDateTime(dateTimePicker2.Value);
            }
            else
            {
                string message = "Hệ thông đang quay số!";
                string title = "THÔNG BÁO";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }


        private void RealTime_Tick(object sender, EventArgs e)
        {
            if (formManager.DaNangIsClick)
            {
                formManager.DaNangIsClick = false;
                SetDataWithDateTime(formManager.dateTimeDN);
            }
            if (formManager.QuangNamIsClick)
            {
                formManager.QuangNamIsClick = false;
                SetDataWithDateTime(formManager.dateTimeQN);
            }
            clsLeHuuPhu.timeDelayDaNang = (int.Parse(formManager.managers[0].Second) * 1000);
            if (formManager.DaNangIsRunNow)
            {
                if (checkDNIsExit(formManager.dateTimeDN) == true)
                {
                    formManager.DaNangIsRunNow = false;
                    string message = "Ngày "+ formManager.dateTimeDN.ToString("dd/MM/yyyy")+ " đài Đà Nẵng đã được quay số!";
                    string title = "THÔNG BÁO";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                }
                else
                {
                    buttonDaNang.BackColor = Color.FromArgb(_random.Next(0, 256), _random.Next(0, 256), 0);
                    RunRanDomLotteryDaNang();
                }
            }
            else
            {
                formManager.DaNangIsRunNow = false;
                buttonDaNang.BackColor = Color.DarkCyan;
            }
        }
        public bool checkDNIsExit(DateTime time)
        {
            foreach (objLottery element in clsLeHuuPhu.DaNangs)
            {
                String[] myDataTime = element.DateTime.Split('/');
                if (time.Year == int.Parse(myDataTime[2]) && time.Month == int.Parse(myDataTime[1]) && time.Day == int.Parse(myDataTime[0]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool checkQNIsExit(DateTime time)
        {
            foreach (objLottery element in clsLeHuuPhu.QuangNams)
            {
                String[] myDataTime = element.DateTime.Split('/');
                if (time.Year == int.Parse(myDataTime[2]) && time.Month == int.Parse(myDataTime[1]) && time.Day == int.Parse(myDataTime[0]))
                {
                    return true;
                }
            }
            return false;
        }
        public void RunRanDomLotteryDaNang()
        {
            clsLeHuuPhu.timeDelayDaNangCount += 100;
            if (clsLeHuuPhu.autoNextRankDaNang == 8)
            {
                labelGiai8DaNang.Text = _random.Next(10, 99).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 7;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 7)
            {
                llabelGiai7DaNang.Text = _random.Next(100, 999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 61;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 61)
            {
                labelGiai6_1DaNang.Text = _random.Next(1000, 9999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 62;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 62)
            {
                labelGiai6_2DaNang.Text = _random.Next(1000, 9999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 63;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 63)
            {
                labelGiai6_3DaNang.Text = _random.Next(1000, 9999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 5;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 5)
            {
                labelGiai5DaNang.Text = _random.Next(1000, 9999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 41;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 41)
            {
                labelGiai4_1DaNang.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 42;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 42)
            {
                labelGiai4_2DaNang.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 43;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 43)
            {
                labelGiai4_3DaNang.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 44;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 44)
            {
                labelGiai4_4DaNang.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 45;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 45)
            {
                labelGiai4_5DaNang.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 46;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 46)
            {
                labelGiai4_6DaNang.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 47;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 47)
            {
                labelGiai4_7DaNang.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 31;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 31)
            {
                labelGiai3_1DaNang.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 32;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 32)
            {
                labelGiai3_2DaNang.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 2;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 2)
            {
                labelGiai2DaNang.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 1;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 1)
            {
                labelGiai1DaNang.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 0;
                }
            }
            if (clsLeHuuPhu.autoNextRankDaNang == 0)
            {
                labelGiaiDBDaNang.Text = _random.Next(100000, 999999).ToString();
                if (clsLeHuuPhu.timeDelayDaNangCount >= clsLeHuuPhu.timeDelayDaNang)
                {
                    clsLeHuuPhu.timeDelayDaNangCount = 0;
                    clsLeHuuPhu.autoNextRankDaNang = 8;
                    formManager.DaNangIsRunNow = false;
                    objLottery tmp = new objLottery();
                    tmp.DateTime = formManager.dateTimeDN.ToString("dd/MM/yyyy");
                    tmp.Rank8 = labelGiai8DaNang.Text;
                    tmp.Rank7 = llabelGiai7DaNang.Text;
                    tmp.Rank6 = labelGiai6_1DaNang.Text + "-" + labelGiai6_2DaNang.Text + "-" + labelGiai6_3DaNang.Text;
                    tmp.Rank5 = labelGiai5DaNang.Text;
                    tmp.Rank4 = labelGiai4_1DaNang.Text + "-" + labelGiai4_2DaNang.Text + "-" + labelGiai4_3DaNang.Text + "-" + labelGiai4_4DaNang.Text + "-" + labelGiai4_5DaNang.Text + "-" + labelGiai4_6DaNang.Text + "-" + labelGiai4_7DaNang.Text;
                    tmp.Rank3 = labelGiai3_1DaNang.Text + "-" + labelGiai3_2DaNang.Text;
                    tmp.Rank2 = labelGiai2DaNang.Text;
                    tmp.Rank1 = labelGiai1DaNang.Text;
                    tmp.Core = 10000;
                    tmp.RankDb = labelGiaiDBDaNang.Text;
                    int u = _random.Next(1, 10);
                    if (u <= 5)
                    {
                        tmp.Core = 15000;
                    }
                    if (u > 5)
                    {
                        tmp.Core = 20000;
                    }
                    tmp.City = "DaNang";
                    clsLeHuuPhu.DaNangs.Add(tmp);
                    clsLeHuuPhu.writeDataJson();
                }
            }
        }

        public void RunRanDomLotteryQuangNam()
        {
            clsLeHuuPhu.timeDelayQuangNamCount += 100;
            if (clsLeHuuPhu.autoNextRankQuangNam == 8)
            {
                labelGiai8QuangNam.Text = _random.Next(10, 99).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 7;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 7)
            {
                labelGiai7QuangNam.Text = _random.Next(100, 999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 61;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 61)
            {
                labelGiai6_1QuangNam.Text = _random.Next(1000, 9999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 62;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 62)
            {
                labelGiai6_2QuangNam.Text = _random.Next(1000, 9999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 63;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 63)
            {
                labelGiai6_3QuangNam.Text = _random.Next(1000, 9999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 5;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 5)
            {
                labelGiai5QuangNam.Text = _random.Next(1000, 9999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 41;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 41)
            {
                labelGiai4_1QuangNam.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 42;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 42)
            {
                labelGiai4_2QuangNam.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 43;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 43)
            {
                labelGiai4_3QuangNam.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 44;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 44)
            {
                labelGiai4_4QuangNam.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 45;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 45)
            {
                labelGiai4_5QuangNam.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 46;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 46)
            {
                labelGiai4_6QuangNam.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 47;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 47)
            {
                labelGiai4_7QuangNam.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 31;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 31)
            {
                labelGiai3_1QuangNam.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 32;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 32)
            {
                labelGiai3_2QuangNam.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 2;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 2)
            {
                labelGiai2QuangNam.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 1;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 1)
            {
                labelGiai1QuangNam.Text = _random.Next(10000, 99999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 0;
                }
            }
            if (clsLeHuuPhu.autoNextRankQuangNam == 0)
            {
                labelGiaiDBQuangNam.Text = _random.Next(100000, 999999).ToString();
                if (clsLeHuuPhu.timeDelayQuangNamCount >= clsLeHuuPhu.timeDelayQuangNam)
                {
                    clsLeHuuPhu.timeDelayQuangNamCount = 0;
                    clsLeHuuPhu.autoNextRankQuangNam = 8;
                    formManager.QuangNamIsRunNow = false;
                    objLottery tmp = new objLottery();
                    tmp.DateTime = formManager.dateTimeQN.ToString("dd/MM/yyyy");
                    tmp.Rank8 = labelGiai8QuangNam.Text;
                    tmp.Rank7 = labelGiai7QuangNam.Text;
                    tmp.Rank6 = labelGiai6_1QuangNam.Text+"-"+ labelGiai6_2QuangNam.Text + "-" + labelGiai6_3QuangNam.Text;
                    tmp.Rank5 = labelGiai5QuangNam.Text;
                    tmp.Rank4 = labelGiai4_1QuangNam.Text+"-"+ labelGiai4_2QuangNam.Text + "-" + labelGiai4_3QuangNam.Text + "-" + labelGiai4_4QuangNam.Text + "-" + labelGiai4_5QuangNam.Text + "-" + labelGiai4_6QuangNam.Text + "-" + labelGiai4_7QuangNam.Text;
                    tmp.Rank3 = labelGiai3_1QuangNam.Text+"-" + labelGiai3_2QuangNam.Text;
                    tmp.Rank2 = labelGiai2QuangNam.Text;
                    tmp.Rank1 = labelGiai1QuangNam.Text;
                    tmp.Core = 10000;
                    tmp.RankDb = labelGiaiDBQuangNam.Text;
                    int u = _random.Next(1, 10);
                    if (u <= 5)
                    {
                        tmp.Core = 15000;
                    }
                    if (u > 5)
                    {
                        tmp.Core = 20000;
                    }
                    tmp.City = "QuangNam";
                    clsLeHuuPhu.QuangNams.Add(tmp);
                    clsLeHuuPhu.writeDataJson();
                }
            }
        }

        private void RealTimeQuangNam_Tick(object sender, EventArgs e)
        {
            if (formManager.DaNangIsClick)
            {
                formManager.DaNangIsClick = false;
                SetDataWithDateTime(formManager.dateTimeDN);
            }
            if (formManager.QuangNamIsClick)
            {
                formManager.QuangNamIsClick = false;
                SetDataWithDateTime(formManager.dateTimeQN);
            }
            clsLeHuuPhu.timeDelayQuangNam = (int.Parse(formManager.managers[1].Second)*1000);
            if (formManager.QuangNamIsRunNow)
            {
                if (checkQNIsExit(formManager.dateTimeQN) == true)
                {
                    formManager.QuangNamIsRunNow = false;
                    string message = "Ngày " + formManager.dateTimeQN.ToString("dd/MM/yyyy") + " đài Quảng Nam đã được quay số!";
                    string title = "THÔNG BÁO";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                }
                else
                {
                    buttonQuangNam.BackColor = Color.FromArgb(_random.Next(0, 256), _random.Next(0, 256), 0);
                    RunRanDomLotteryQuangNam();
                }
            }
            else
            {
                formManager.QuangNamIsRunNow = false;
                buttonQuangNam.BackColor = Color.DarkCyan;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            String[] p = d.ToString("HH:mm:ss").Split(':');
            labelTime.Text = d.ToString("HH:mm:ss");
        }

        private void buttonRunSearch_Click(object sender, EventArgs e)
        {
            if (formManager.DaNangIsRunNow == false && formManager.QuangNamIsRunNow == false)
            {
                if (comboBox1.Text.Equals("ĐÀ NẴNG"))
                {
                    Console.WriteLine("ĐÀ NẴNG");
                    bool po = true;
                    foreach (objLottery element in clsLeHuuPhu.DaNangs)
                    {
                        String[] myDataTime = element.DateTime.Split('/');
                        if (dateTimePicker1.Value.Year == int.Parse(myDataTime[2]) && dateTimePicker1.Value.Month == int.Parse(myDataTime[1]) && dateTimePicker1.Value.Day == int.Parse(myDataTime[0]))
                        {
                            po = false;
                            checkReward(element);
                            SetDataWithDateTime(dateTimePicker1.Value);
                        }
                    }
                    if(po)
                    {
                        showAlertDialog("Chưa có kết quả quay số ngày " + dateTimePicker1.Value, "THÔNG BÁO");
                        return;
                    }
                }
                if (comboBox1.Text.Equals("QUẢNG NAM"))
                {
                    bool po = true;
                    Console.WriteLine("QUẢNG NAM");
                    foreach (objLottery element in clsLeHuuPhu.QuangNams)
                    {
                        String[] myDataTime = element.DateTime.Split('/');
                        if (dateTimePicker1.Value.Year == int.Parse(myDataTime[2]) && dateTimePicker1.Value.Month == int.Parse(myDataTime[1]) && dateTimePicker1.Value.Day == int.Parse(myDataTime[0]))
                        {
                            po = false;
                            checkReward(element);
                            SetDataWithDateTime(dateTimePicker1.Value);
                        }
                    }
                    if (po)
                    {
                        showAlertDialog("Chưa có kết quả quay số ngày " + dateTimePicker1.Value, "THÔNG BÁO");
                        return;
                    }
                }
            }
            else
            {
                string message = "Hệ thông đang quay số!";
                string title = "THÔNG BÁO";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }

        public void checkReward(objLottery element)
        {
            String input = textBoxInputNumberSearch.Text;
            if(input.Length != 6)
            {
                showAlertDialog("mã số vé là 6 chữ số, vui lòng nhập đúng!", "CẢNH BÁO");
                return;
            }
            Console.WriteLine(input);
            Console.WriteLine(element.Rank8);
            if (input[input.Length - 1] == element.Rank8[1] && input[input.Length - 2] == element.Rank8[0])
            {
                showAlertDialog("Chúc nừng bạn trúng giải 8", "CHÚC MỪNG");
                return;
            }
            String[] tmp = element.Rank7.Split('-');
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == input.Substring(3))
                {
                    showAlertDialog("Chúc nừng bạn trúng giải 7", "CHÚC MỪNG");
                    return;
                }
            }
            tmp = element.Rank6.Split('-');
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == input.Substring(2))
                {
                    showAlertDialog("Chúc nừng bạn trúng giải 6", "CHÚC MỪNG");
                    return;
                }
            }
            tmp = element.Rank5.Split('-');
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == input.Substring(2))
                {
                    showAlertDialog("Chúc nừng bạn trúng giải 5", "CHÚC MỪNG");
                    return;
                }
            }
            tmp = element.Rank4.Split('-');
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == input.Substring(1))
                {
                    showAlertDialog("Chúc nừng bạn trúng giải 4", "CHÚC MỪNG");
                    return;
                }
            }
            tmp = element.Rank3.Split('-');
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == input.Substring(1))
                {
                    showAlertDialog("Chúc nừng bạn trúng giải Ba", "CHÚC MỪNG");
                    return;
                }
            }
            tmp = element.Rank2.Split('-');
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == input.Substring(1))
                {
                    showAlertDialog("Chúc nừng bạn trúng giải Nhì", "CHÚC MỪNG");
                    return;
                }
            }
            
            tmp = element.Rank1.Split('-');
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == input.Substring(1))
                {
                    showAlertDialog("Chúc nừng bạn trúng giải Nhất", "CHÚC MỪNG");
                    return;
                }
            }
            tmp = element.RankDb.Split('-');
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == input)
                {
                    showAlertDialog("Chúc nừng bạn trúng giải Đặc Biệt", "CHÚC MỪNG");
                    return;
                }
            }
            Console.WriteLine(input[input.Length - 1]);
            Console.WriteLine(element.RankDb[5]);
            int kk = int.Parse(element.RankDb);
            int p = int.Parse(input);
            int checkKK = 0;
            while(kk > 10)
            {
                if (p % 10 != kk % 10) { checkKK += 1; }
                p = p / 10;
                kk = kk / 10;
            }

            if (checkKK <= 1)
            {
                showAlertDialog("Chúc nừng bạn trúng giải Khuyến Kích", "CHÚC MỪNG");
                return;
            }
            showAlertDialog("Chúc bạn may mắn lần sau", "Thông Báo");
            return;
        }

        public void showAlertDialog(String message, String title)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
        }
    }
}

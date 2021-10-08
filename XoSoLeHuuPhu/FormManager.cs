using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace XoSoLeHuuPhu
{
    public partial class FormManager : Form
    {
        public bool DaNangIsRunNow = false;
        public bool QuangNamIsRunNow = false;
        public bool DaNangSchedule = false;
        public bool QuangNamSchedule = false;
        string fileName = @"E:\managerSetting.json";
        String dataJson = "[{ 'Hour':'18','Minute':'0','Second':'5'},{ 'Hour':'18','Minute':'0','Second':'10'}]";
        public DateTime dateTimeDN = DateTime.Now;
        public DateTime dateTimeQN = DateTime.Now;
        public List<managerSetting> managers = new List<managerSetting>();
        public bool DaNangIsClick = false;
        public bool QuangNamIsClick = false;
        public FormManager()
        {
            InitializeComponent();
            setHourAndMinute();
            readDataJsonManager();
            ViewUpdateTime();
            timer1.Start();
        }

        void setHourAndMinute()
        {
            for(int i = 1; i<=24; i++)
            {
                comboBoxHourDN.Items.Add(i);
                comboBoxHourQN.Items.Add(i);
            }
            for (int i = 0; i <= 59; i++)
            {
                comboBoxMinuteDN.Items.Add(i);
                comboBoxMinuteQN.Items.Add(i);
            }
            for (int i = 2; i <= 30; i+=2)
            {
                comboBoxSecondDN.Items.Add(i);
                comboBoxSecondQN.Items.Add(i);
            }
        }

        private void buttonRunNowDN_Click(object sender, EventArgs e)
        {
            dateTimeDN = dateTimePickerManagerDN.Value;
            try
            {
                int tmp = int.Parse(comboBoxSecondDN.Text);
                managers[0].Second = comboBoxSecondDN.Text;
                if(DaNangIsRunNow == false)
                {
                    DaNangIsRunNow = true;
                    DaNangIsClick = true;
                }
                else
                {
                    string message = "Vui lòng thử lại khi hệ thống quay số xong!";
                    string title = "HỆ THỐNG ĐANG BẬN";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                }
               
            }
            catch (Exception)
            {
                string message = "Vui lòng chọn số!";
                string title = "Lỗi Nhập Liệu";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }

        private void buttonRunNowQN_Click(object sender, EventArgs e)
        {
            dateTimeQN = dateTimePickerManagerQN.Value;
            try
            {
                int tmp = int.Parse(comboBoxSecondQN.Text);
                managers[1].Second = comboBoxSecondQN.Text;
                if (QuangNamIsRunNow == false)
                {
                    QuangNamIsRunNow = true;
                }
                else
                {
                    string message = "Vui lòng thử lại khi hệ thống quay số xong!";
                    string title = "HỆ THỐNG ĐANG BẬN";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                }
            }
            catch (Exception)
            {
                string message = "Vui lòng chọn số!";
                string title = "Lỗi Nhập Liệu";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }



        public void readDataJsonManager()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        dataJson = "";
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
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            writer.Write("[{'Hour':'18','Minute':'0','Second':'5'},{'Hour':'18','Minute':'0','Second':'10'}]");
                        }
                    }
                    catch (Exception exp)
                    {
                        Console.Write(exp.Message);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            Console.WriteLine(dataJson);
            JArray json = JArray.Parse(dataJson);
            foreach (JObject element in json)
            {
                managerSetting tmp = new managerSetting();
                tmp.Hour = (string)element["Hour"];
                tmp.Minute = (string)element["Minute"];
                tmp.Second = (string)element["Second"];
                managers.Add(tmp);
            }
            managerSetting DN = managers[0];
            comboBoxHourDN.Text = DN.Hour;
            comboBoxMinuteDN.Text = DN.Minute;
            comboBoxSecondDN.Text = DN.Second;
            managerSetting QN = managers[1];
            comboBoxHourQN.Text = QN.Hour;
            comboBoxMinuteQN.Text = QN.Minute;
            comboBoxSecondQN.Text = QN.Second;
            Console.WriteLine(DN.Hour);
        }
        public void writeDataJsonManager()
        {
            String s = "[";
            foreach (managerSetting element in managers)
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

        private void comboBoxHourDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tmp = int.Parse(comboBoxHourDN.Text);
                //Console.WriteLine(tmp);
                managers[0].Hour = comboBoxHourDN.Text;
            }
            catch (Exception)
            {
                string message = "Vui lòng chọn số!";
                string title = "Lỗi Nhập Liệu";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }

        private void comboBoxMinuteDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tmp = int.Parse(comboBoxMinuteDN.Text);
                managers[0].Minute = comboBoxMinuteDN.Text;
            }
            catch (Exception)
            {
                string message = "Vui lòng chọn số!";
                string title = "Lỗi Nhập Liệu";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }

        private void comboBoxSecondDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tmp = int.Parse(comboBoxSecondDN.Text);
                managers[0].Second = comboBoxSecondDN.Text;
            }
            catch (Exception)
            {
                string message = "Vui lòng chọn số!";
                string title = "Lỗi Nhập Liệu";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }

        private void comboBoxHourQN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tmp = int.Parse(comboBoxHourQN.Text);
                managers[1].Hour = comboBoxHourQN.Text;
            }
            catch (Exception)
            {
                string message = "Vui lòng chọn số!";
                string title = "Lỗi Nhập Liệu";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }

        private void comboBoxMinuteQN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tmp = int.Parse(comboBoxMinuteQN.Text);
                managers[1].Minute = comboBoxMinuteQN.Text;
            }
            catch (Exception)
            {
                string message = "Vui lòng chọn số!";
                string title = "Lỗi Nhập Liệu";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }

        private void comboBoxSecondQN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tmp = int.Parse(comboBoxSecondQN.Text);
                managers[1].Second = comboBoxSecondQN.Text;
            }
            catch (Exception)
            {
                string message = "Vui lòng chọn số!";
                string title = "Lỗi Nhập Liệu";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }
        public void ViewUpdateTime()
        {
            labelDesDN.Text = "Đài Đà Nẵng Sẽ Tự Quay Số Vào  " + managers[0].Hour + ":" + managers[0].Minute + "  Hằng Ngày.";
            labelDesQN.Text = "Đài Quảng Nam Sẽ Tự Quay Số Vào  " + managers[1].Hour + ":" + managers[1].Minute + "  Hằng Ngày.";
        }

        private void buttonSetTimeQN_Click(object sender, EventArgs e)
        {
            managers[0].Hour = comboBoxHourDN.Text;
            managers[0].Minute = comboBoxMinuteDN.Text;
            managers[0].Second = comboBoxSecondDN.Text;
            string message = "Đã lưu cập nhật!";
            string title = "THÀNG CÔNG";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            writeDataJsonManager();
            ViewUpdateTime();
        }

        private void buttonSetTimeDN_Click(object sender, EventArgs e)
        {
            managers[1].Hour = comboBoxHourQN.Text;
            managers[1].Minute = comboBoxMinuteQN.Text;
            managers[1].Second = comboBoxSecondQN.Text;
            string message = "Đã lưu cập nhật!";
            string title = "THÀNG CÔNG";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            writeDataJsonManager();
            ViewUpdateTime();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            String[] p = d.ToString("HH:mm").Split(':');
            if (int.Parse(p[0]) == int.Parse(managers[0].Hour) && int.Parse(p[1]) == int.Parse(managers[0].Minute) && DaNangIsRunNow != true)
            {
                dateTimeDN = DateTime.Now;
                
                DaNangIsRunNow = true;

            }
            if (int.Parse(p[0]) == int.Parse(managers[1].Hour) && int.Parse(p[1]) == int.Parse(managers[1].Minute) && QuangNamIsRunNow != true)
            {
                dateTimeQN = DateTime.Now;
                QuangNamIsRunNow = true;
            }
        }
    }
}

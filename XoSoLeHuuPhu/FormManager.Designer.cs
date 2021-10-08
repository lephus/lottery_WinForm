
namespace XoSoLeHuuPhu
{
    partial class FormManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePickerManagerQN = new System.Windows.Forms.DateTimePicker();
            this.labelDesQN = new System.Windows.Forms.Label();
            this.comboBoxSecondQN = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonRunNowQN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSetTimeQN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMinuteQN = new System.Windows.Forms.ComboBox();
            this.comboBoxHourQN = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerManagerDN = new System.Windows.Forms.DateTimePicker();
            this.labelDesDN = new System.Windows.Forms.Label();
            this.comboBoxSecondDN = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRunNowDN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSetTimeDN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMinuteDN = new System.Windows.Forms.ComboBox();
            this.comboBoxHourDN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 403);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dateTimePickerManagerQN);
            this.panel3.Controls.Add(this.labelDesQN);
            this.panel3.Controls.Add(this.comboBoxSecondQN);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.buttonRunNowQN);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.buttonSetTimeQN);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.comboBoxMinuteQN);
            this.panel3.Controls.Add(this.comboBoxHourQN);
            this.panel3.Location = new System.Drawing.Point(3, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 195);
            this.panel3.TabIndex = 7;
            // 
            // dateTimePickerManagerQN
            // 
            this.dateTimePickerManagerQN.Location = new System.Drawing.Point(283, 16);
            this.dateTimePickerManagerQN.Name = "dateTimePickerManagerQN";
            this.dateTimePickerManagerQN.Size = new System.Drawing.Size(124, 20);
            this.dateTimePickerManagerQN.TabIndex = 11;
            // 
            // labelDesQN
            // 
            this.labelDesQN.AutoSize = true;
            this.labelDesQN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesQN.Location = new System.Drawing.Point(60, 161);
            this.labelDesQN.Name = "labelDesQN";
            this.labelDesQN.Size = new System.Drawing.Size(307, 16);
            this.labelDesQN.TabIndex = 10;
            this.labelDesQN.Text = "Đài Đà Nẵng sẽ tự quay số vào 12h:12p hăng ngày";
            // 
            // comboBoxSecondQN
            // 
            this.comboBoxSecondQN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecondQN.FormattingEnabled = true;
            this.comboBoxSecondQN.Location = new System.Drawing.Point(149, 123);
            this.comboBoxSecondQN.Name = "comboBoxSecondQN";
            this.comboBoxSecondQN.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSecondQN.TabIndex = 9;
            this.comboBoxSecondQN.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecondQN_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Giây / 1 Lượt";
            // 
            // buttonRunNowQN
            // 
            this.buttonRunNowQN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunNowQN.ForeColor = System.Drawing.Color.Teal;
            this.buttonRunNowQN.Location = new System.Drawing.Point(284, 42);
            this.buttonRunNowQN.Name = "buttonRunNowQN";
            this.buttonRunNowQN.Size = new System.Drawing.Size(123, 28);
            this.buttonRunNowQN.TabIndex = 6;
            this.buttonRunNowQN.Text = "Quay Số Ngay";
            this.buttonRunNowQN.UseVisualStyleBackColor = true;
            this.buttonRunNowQN.Click += new System.EventHandler(this.buttonRunNowQN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(18, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "THIẾT LẬP CHO ĐÀI QUẢNG NAM";
            // 
            // buttonSetTimeQN
            // 
            this.buttonSetTimeQN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetTimeQN.Location = new System.Drawing.Point(284, 119);
            this.buttonSetTimeQN.Name = "buttonSetTimeQN";
            this.buttonSetTimeQN.Size = new System.Drawing.Size(123, 28);
            this.buttonSetTimeQN.TabIndex = 4;
            this.buttonSetTimeQN.Text = "Lưu Thay Đổi";
            this.buttonSetTimeQN.UseVisualStyleBackColor = true;
            this.buttonSetTimeQN.Click += new System.EventHandler(this.buttonSetTimeQN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Đặt Phút Quay Số";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đặt Giờ Quay Số";
            // 
            // comboBoxMinuteQN
            // 
            this.comboBoxMinuteQN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinuteQN.FormattingEnabled = true;
            this.comboBoxMinuteQN.Location = new System.Drawing.Point(149, 86);
            this.comboBoxMinuteQN.Name = "comboBoxMinuteQN";
            this.comboBoxMinuteQN.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMinuteQN.TabIndex = 1;
            this.comboBoxMinuteQN.SelectedIndexChanged += new System.EventHandler(this.comboBoxMinuteQN_SelectedIndexChanged);
            // 
            // comboBoxHourQN
            // 
            this.comboBoxHourQN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHourQN.FormattingEnabled = true;
            this.comboBoxHourQN.Location = new System.Drawing.Point(149, 46);
            this.comboBoxHourQN.Name = "comboBoxHourQN";
            this.comboBoxHourQN.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHourQN.TabIndex = 0;
            this.comboBoxHourQN.SelectedIndexChanged += new System.EventHandler(this.comboBoxHourQN_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimePickerManagerDN);
            this.panel2.Controls.Add(this.labelDesDN);
            this.panel2.Controls.Add(this.comboBoxSecondDN);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.buttonRunNowDN);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonSetTimeDN);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxMinuteDN);
            this.panel2.Controls.Add(this.comboBoxHourDN);
            this.panel2.Location = new System.Drawing.Point(3, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 170);
            this.panel2.TabIndex = 1;
            // 
            // dateTimePickerManagerDN
            // 
            this.dateTimePickerManagerDN.Location = new System.Drawing.Point(284, 12);
            this.dateTimePickerManagerDN.Name = "dateTimePickerManagerDN";
            this.dateTimePickerManagerDN.Size = new System.Drawing.Size(123, 20);
            this.dateTimePickerManagerDN.TabIndex = 10;
            // 
            // labelDesDN
            // 
            this.labelDesDN.AutoSize = true;
            this.labelDesDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesDN.Location = new System.Drawing.Point(60, 143);
            this.labelDesDN.Name = "labelDesDN";
            this.labelDesDN.Size = new System.Drawing.Size(307, 16);
            this.labelDesDN.TabIndex = 9;
            this.labelDesDN.Text = "Đài Đà Nẵng sẽ tự quay số vào 12h:12p hăng ngày";
            // 
            // comboBoxSecondDN
            // 
            this.comboBoxSecondDN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecondDN.FormattingEnabled = true;
            this.comboBoxSecondDN.Location = new System.Drawing.Point(149, 108);
            this.comboBoxSecondDN.Name = "comboBoxSecondDN";
            this.comboBoxSecondDN.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSecondDN.TabIndex = 8;
            this.comboBoxSecondDN.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecondDN_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Giây / 1 Lượt";
            // 
            // buttonRunNowDN
            // 
            this.buttonRunNowDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunNowDN.ForeColor = System.Drawing.Color.Teal;
            this.buttonRunNowDN.Location = new System.Drawing.Point(284, 40);
            this.buttonRunNowDN.Name = "buttonRunNowDN";
            this.buttonRunNowDN.Size = new System.Drawing.Size(123, 28);
            this.buttonRunNowDN.TabIndex = 6;
            this.buttonRunNowDN.Text = "Quay Số Ngay";
            this.buttonRunNowDN.UseVisualStyleBackColor = true;
            this.buttonRunNowDN.Click += new System.EventHandler(this.buttonRunNowDN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(18, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "THIẾT LẬP CHO ĐÀI ĐÀ NẴNG";
            // 
            // buttonSetTimeDN
            // 
            this.buttonSetTimeDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetTimeDN.Location = new System.Drawing.Point(284, 102);
            this.buttonSetTimeDN.Name = "buttonSetTimeDN";
            this.buttonSetTimeDN.Size = new System.Drawing.Size(123, 28);
            this.buttonSetTimeDN.TabIndex = 4;
            this.buttonSetTimeDN.Text = "Lưu Thay Đổi";
            this.buttonSetTimeDN.UseVisualStyleBackColor = true;
            this.buttonSetTimeDN.Click += new System.EventHandler(this.buttonSetTimeDN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đặt Phút Quay Số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đặt Giờ Quay Số";
            // 
            // comboBoxMinuteDN
            // 
            this.comboBoxMinuteDN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinuteDN.FormattingEnabled = true;
            this.comboBoxMinuteDN.Location = new System.Drawing.Point(149, 77);
            this.comboBoxMinuteDN.Name = "comboBoxMinuteDN";
            this.comboBoxMinuteDN.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMinuteDN.TabIndex = 1;
            this.comboBoxMinuteDN.SelectedIndexChanged += new System.EventHandler(this.comboBoxMinuteDN_SelectedIndexChanged);
            // 
            // comboBoxHourDN
            // 
            this.comboBoxHourDN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHourDN.FormattingEnabled = true;
            this.comboBoxHourDN.Location = new System.Drawing.Point(149, 42);
            this.comboBoxHourDN.Name = "comboBoxHourDN";
            this.comboBoxHourDN.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHourDN.TabIndex = 0;
            this.comboBoxHourDN.SelectedIndexChanged += new System.EventHandler(this.comboBoxHourDN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "THIẾT LẬP QUẢN LÝ HỆ THỐNG";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(446, 427);
            this.Controls.Add(this.panel1);
            this.Name = "FormManager";
            this.Text = "FormManager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRunNowDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSetTimeDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMinuteDN;
        private System.Windows.Forms.ComboBox comboBoxHourDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonRunNowQN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSetTimeQN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMinuteQN;
        private System.Windows.Forms.ComboBox comboBoxHourQN;
        private System.Windows.Forms.ComboBox comboBoxSecondQN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxSecondDN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelDesQN;
        private System.Windows.Forms.Label labelDesDN;
        private System.Windows.Forms.DateTimePicker dateTimePickerManagerDN;
        private System.Windows.Forms.DateTimePicker dateTimePickerManagerQN;
        private System.Windows.Forms.Timer timer1;
    }
}
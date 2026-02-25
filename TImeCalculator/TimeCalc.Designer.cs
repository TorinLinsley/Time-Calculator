namespace TImeCalculator
{
    partial class TimeCalc
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeCalc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_h1 = new System.Windows.Forms.ComboBox();
            this.cb_min1 = new System.Windows.Forms.ComboBox();
            this.cb_s1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clear_up_h = new System.Windows.Forms.Button();
            this.clear_up_min = new System.Windows.Forms.Button();
            this.clear_up_s = new System.Windows.Forms.Button();
            this.clearall_up = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_h2 = new System.Windows.Forms.ComboBox();
            this.cb_min2 = new System.Windows.Forms.ComboBox();
            this.cb_s2 = new System.Windows.Forms.ComboBox();
            this.clear_down_h = new System.Windows.Forms.Button();
            this.clearall_down = new System.Windows.Forms.Button();
            this.clear_down_min = new System.Windows.Forms.Button();
            this.clear_down_s = new System.Windows.Forms.Button();
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.fill = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.RadioButton();
            this.sub = new System.Windows.Forms.RadioButton();
            this.atf = new System.Windows.Forms.CheckBox();
            this.copy_h = new System.Windows.Forms.Button();
            this.copy_min = new System.Windows.Forms.Button();
            this.copy_s = new System.Windows.Forms.Button();
            this.copyall = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.result_h = new System.Windows.Forms.TextBox();
            this.result_min = new System.Windows.Forms.TextBox();
            this.result_s = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Button();
            this.intv = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 30);
            this.label1.TabIndex = 36;
            this.label1.Text = "计算时间";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 37;
            this.label2.Text = "模式选择";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "计算结果";
            // 
            // cb_h1
            // 
            this.cb_h1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_h1.FormattingEnabled = true;
            this.cb_h1.IntegralHeight = false;
            this.cb_h1.ItemHeight = 21;
            this.cb_h1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cb_h1.Location = new System.Drawing.Point(120, 53);
            this.cb_h1.MaxDropDownItems = 21;
            this.cb_h1.Name = "cb_h1";
            this.cb_h1.Size = new System.Drawing.Size(130, 29);
            this.cb_h1.TabIndex = 0;
            this.cb_h1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_min1
            // 
            this.cb_min1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_min1.FormattingEnabled = true;
            this.cb_min1.IntegralHeight = false;
            this.cb_min1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cb_min1.Location = new System.Drawing.Point(256, 53);
            this.cb_min1.MaxDropDownItems = 21;
            this.cb_min1.Name = "cb_min1";
            this.cb_min1.Size = new System.Drawing.Size(130, 29);
            this.cb_min1.TabIndex = 1;
            this.cb_min1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_s1
            // 
            this.cb_s1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_s1.FormattingEnabled = true;
            this.cb_s1.IntegralHeight = false;
            this.cb_s1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cb_s1.Location = new System.Drawing.Point(392, 53);
            this.cb_s1.MaxDropDownItems = 21;
            this.cb_s1.Name = "cb_s1";
            this.cb_s1.Size = new System.Drawing.Size(130, 29);
            this.cb_s1.TabIndex = 2;
            this.cb_s1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "加减数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(162, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "小时";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(298, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "分钟";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(443, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "秒";
            // 
            // clear_up_h
            // 
            this.clear_up_h.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear_up_h.Location = new System.Drawing.Point(120, 120);
            this.clear_up_h.Name = "clear_up_h";
            this.clear_up_h.Size = new System.Drawing.Size(127, 33);
            this.clear_up_h.TabIndex = 19;
            this.clear_up_h.Text = "清除小时";
            this.clear_up_h.UseVisualStyleBackColor = true;
            this.clear_up_h.Click += new System.EventHandler(this.clear_up_h_Click);
            // 
            // clear_up_min
            // 
            this.clear_up_min.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear_up_min.Location = new System.Drawing.Point(257, 120);
            this.clear_up_min.Name = "clear_up_min";
            this.clear_up_min.Size = new System.Drawing.Size(127, 33);
            this.clear_up_min.TabIndex = 20;
            this.clear_up_min.Text = "清除分钟";
            this.clear_up_min.UseVisualStyleBackColor = true;
            this.clear_up_min.Click += new System.EventHandler(this.clear_up_min_Click);
            // 
            // clear_up_s
            // 
            this.clear_up_s.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear_up_s.Location = new System.Drawing.Point(394, 120);
            this.clear_up_s.Name = "clear_up_s";
            this.clear_up_s.Size = new System.Drawing.Size(127, 33);
            this.clear_up_s.TabIndex = 21;
            this.clear_up_s.Text = "清除秒";
            this.clear_up_s.UseVisualStyleBackColor = true;
            this.clear_up_s.Click += new System.EventHandler(this.clear_up_s_Click);
            // 
            // clearall_up
            // 
            this.clearall_up.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearall_up.Location = new System.Drawing.Point(12, 120);
            this.clearall_up.Name = "clearall_up";
            this.clearall_up.Size = new System.Drawing.Size(99, 33);
            this.clearall_up.TabIndex = 18;
            this.clearall_up.Text = "清空上半";
            this.clearall_up.UseVisualStyleBackColor = true;
            this.clearall_up.Click += new System.EventHandler(this.clearall_up_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "被加减数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(162, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "小时";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(298, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "分钟";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(443, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "秒";
            // 
            // cb_h2
            // 
            this.cb_h2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_h2.FormattingEnabled = true;
            this.cb_h2.IntegralHeight = false;
            this.cb_h2.ItemHeight = 21;
            this.cb_h2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cb_h2.Location = new System.Drawing.Point(120, 186);
            this.cb_h2.MaxDropDownItems = 21;
            this.cb_h2.Name = "cb_h2";
            this.cb_h2.Size = new System.Drawing.Size(130, 29);
            this.cb_h2.TabIndex = 3;
            this.cb_h2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_min2
            // 
            this.cb_min2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_min2.FormattingEnabled = true;
            this.cb_min2.IntegralHeight = false;
            this.cb_min2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cb_min2.Location = new System.Drawing.Point(256, 186);
            this.cb_min2.MaxDropDownItems = 21;
            this.cb_min2.Name = "cb_min2";
            this.cb_min2.Size = new System.Drawing.Size(130, 29);
            this.cb_min2.TabIndex = 4;
            this.cb_min2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_s2
            // 
            this.cb_s2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_s2.FormattingEnabled = true;
            this.cb_s2.IntegralHeight = false;
            this.cb_s2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cb_s2.Location = new System.Drawing.Point(392, 186);
            this.cb_s2.MaxDropDownItems = 21;
            this.cb_s2.Name = "cb_s2";
            this.cb_s2.Size = new System.Drawing.Size(130, 29);
            this.cb_s2.TabIndex = 5;
            this.cb_s2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clear_down_h
            // 
            this.clear_down_h.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear_down_h.Location = new System.Drawing.Point(120, 253);
            this.clear_down_h.Name = "clear_down_h";
            this.clear_down_h.Size = new System.Drawing.Size(127, 33);
            this.clear_down_h.TabIndex = 23;
            this.clear_down_h.Text = "清除小时";
            this.clear_down_h.UseVisualStyleBackColor = true;
            this.clear_down_h.Click += new System.EventHandler(this.clear_down_h_Click);
            // 
            // clearall_down
            // 
            this.clearall_down.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearall_down.Location = new System.Drawing.Point(12, 253);
            this.clearall_down.Name = "clearall_down";
            this.clearall_down.Size = new System.Drawing.Size(99, 33);
            this.clearall_down.TabIndex = 22;
            this.clearall_down.Text = "清空上半";
            this.clearall_down.UseVisualStyleBackColor = true;
            this.clearall_down.Click += new System.EventHandler(this.clearall_down_Click);
            // 
            // clear_down_min
            // 
            this.clear_down_min.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear_down_min.Location = new System.Drawing.Point(257, 253);
            this.clear_down_min.Name = "clear_down_min";
            this.clear_down_min.Size = new System.Drawing.Size(127, 33);
            this.clear_down_min.TabIndex = 24;
            this.clear_down_min.Text = "清除分钟";
            this.clear_down_min.UseVisualStyleBackColor = true;
            this.clear_down_min.Click += new System.EventHandler(this.clear_down_min_Click);
            // 
            // clear_down_s
            // 
            this.clear_down_s.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear_down_s.Location = new System.Drawing.Point(394, 253);
            this.clear_down_s.Name = "clear_down_s";
            this.clear_down_s.Size = new System.Drawing.Size(127, 33);
            this.clear_down_s.TabIndex = 25;
            this.clear_down_s.Text = "清除秒";
            this.clear_down_s.UseVisualStyleBackColor = true;
            this.clear_down_s.Click += new System.EventHandler(this.clear_down_s_Click);
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_clearAll.Location = new System.Drawing.Point(179, 352);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(100, 33);
            this.btn_clearAll.TabIndex = 17;
            this.btn_clearAll.Text = "清空全部";
            this.btn_clearAll.UseVisualStyleBackColor = true;
            this.btn_clearAll.Click += new System.EventHandler(this.button9_Click);
            // 
            // fill
            // 
            this.fill.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fill.Location = new System.Drawing.Point(12, 218);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(99, 33);
            this.fill.TabIndex = 26;
            this.fill.Text = "填充至↑";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Checked = true;
            this.add.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add.Location = new System.Drawing.Point(120, 302);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(68, 29);
            this.add.TabIndex = 14;
            this.add.Text = "加法";
            this.add.UseVisualStyleBackColor = true;
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sub.Location = new System.Drawing.Point(204, 302);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(68, 29);
            this.sub.TabIndex = 15;
            this.sub.Text = "减法";
            this.sub.UseVisualStyleBackColor = true;
            // 
            // atf
            // 
            this.atf.AutoSize = true;
            this.atf.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.atf.Location = new System.Drawing.Point(412, 302);
            this.atf.Name = "atf";
            this.atf.Size = new System.Drawing.Size(107, 29);
            this.atf.TabIndex = 16;
            this.atf.Text = "自动填充";
            this.atf.UseVisualStyleBackColor = false;
            // 
            // copy_h
            // 
            this.copy_h.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.copy_h.Location = new System.Drawing.Point(12, 438);
            this.copy_h.Name = "copy_h";
            this.copy_h.Size = new System.Drawing.Size(164, 33);
            this.copy_h.TabIndex = 8;
            this.copy_h.Text = "复制小时";
            this.copy_h.UseVisualStyleBackColor = true;
            // 
            // copy_min
            // 
            this.copy_min.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.copy_min.Location = new System.Drawing.Point(184, 438);
            this.copy_min.Name = "copy_min";
            this.copy_min.Size = new System.Drawing.Size(164, 33);
            this.copy_min.TabIndex = 9;
            this.copy_min.Text = "复制分钟";
            this.copy_min.UseVisualStyleBackColor = true;
            // 
            // copy_s
            // 
            this.copy_s.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.copy_s.Location = new System.Drawing.Point(356, 438);
            this.copy_s.Name = "copy_s";
            this.copy_s.Size = new System.Drawing.Size(164, 33);
            this.copy_s.TabIndex = 10;
            this.copy_s.Text = "复制秒";
            this.copy_s.UseVisualStyleBackColor = true;
            // 
            // copyall
            // 
            this.copyall.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.copyall.Location = new System.Drawing.Point(285, 352);
            this.copyall.Name = "copyall";
            this.copyall.Size = new System.Drawing.Size(129, 33);
            this.copyall.TabIndex = 7;
            this.copyall.Text = "复制全部结果";
            this.copyall.UseVisualStyleBackColor = true;
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calc.Location = new System.Drawing.Point(420, 352);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(100, 33);
            this.calc.TabIndex = 6;
            this.calc.Text = "计算";
            this.calc.UseVisualStyleBackColor = true;
            // 
            // result_h
            // 
            this.result_h.BackColor = System.Drawing.Color.White;
            this.result_h.Cursor = System.Windows.Forms.Cursors.Default;
            this.result_h.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result_h.Location = new System.Drawing.Point(12, 400);
            this.result_h.Name = "result_h";
            this.result_h.ReadOnly = true;
            this.result_h.Size = new System.Drawing.Size(166, 32);
            this.result_h.TabIndex = 11;
            this.result_h.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // result_min
            // 
            this.result_min.BackColor = System.Drawing.Color.White;
            this.result_min.Cursor = System.Windows.Forms.Cursors.Default;
            this.result_min.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result_min.Location = new System.Drawing.Point(183, 400);
            this.result_min.Name = "result_min";
            this.result_min.ReadOnly = true;
            this.result_min.Size = new System.Drawing.Size(166, 32);
            this.result_min.TabIndex = 12;
            // 
            // result_s
            // 
            this.result_s.BackColor = System.Drawing.Color.White;
            this.result_s.Cursor = System.Windows.Forms.Cursors.Default;
            this.result_s.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result_s.Location = new System.Drawing.Point(354, 400);
            this.result_s.Name = "result_s";
            this.result_s.ReadOnly = true;
            this.result_s.Size = new System.Drawing.Size(166, 32);
            this.result_s.TabIndex = 13;
            // 
            // log
            // 
            this.log.Cursor = System.Windows.Forms.Cursors.Default;
            this.log.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.log.Location = new System.Drawing.Point(83, 477);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(437, 29);
            this.log.TabIndex = 40;
            this.log.TabStop = false;
            this.log.TextChanged += new System.EventHandler(this.log_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(3, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 21);
            this.label12.TabIndex = 39;
            this.label12.Text = "提示信息";
            // 
            // about
            // 
            this.about.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.about.Location = new System.Drawing.Point(447, 8);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(75, 33);
            this.about.TabIndex = 35;
            this.about.Text = "关于";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // intv
            // 
            this.intv.AutoSize = true;
            this.intv.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intv.Location = new System.Drawing.Point(289, 302);
            this.intv.Name = "intv";
            this.intv.Size = new System.Drawing.Size(106, 29);
            this.intv.TabIndex = 14;
            this.intv.Text = "间隔计算";
            this.intv.UseVisualStyleBackColor = true;
            // 
            // TimeCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 515);
            this.Controls.Add(this.log);
            this.Controls.Add(this.result_s);
            this.Controls.Add(this.result_min);
            this.Controls.Add(this.result_h);
            this.Controls.Add(this.atf);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.intv);
            this.Controls.Add(this.add);
            this.Controls.Add(this.copy_s);
            this.Controls.Add(this.clear_down_s);
            this.Controls.Add(this.copy_min);
            this.Controls.Add(this.clear_up_s);
            this.Controls.Add(this.clear_down_min);
            this.Controls.Add(this.clear_up_min);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.about);
            this.Controls.Add(this.btn_clearAll);
            this.Controls.Add(this.clearall_down);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.copyall);
            this.Controls.Add(this.copy_h);
            this.Controls.Add(this.clearall_up);
            this.Controls.Add(this.clear_down_h);
            this.Controls.Add(this.clear_up_h);
            this.Controls.Add(this.cb_s2);
            this.Controls.Add(this.cb_s1);
            this.Controls.Add(this.cb_min2);
            this.Controls.Add(this.cb_min1);
            this.Controls.Add(this.cb_h2);
            this.Controls.Add(this.cb_h1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(547, 554);
            this.MinimumSize = new System.Drawing.Size(547, 554);
            this.Name = "TimeCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "时间计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_h1;
        private System.Windows.Forms.ComboBox cb_min1;
        private System.Windows.Forms.ComboBox cb_s1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button clear_up_h;
        private System.Windows.Forms.Button clear_up_min;
        private System.Windows.Forms.Button clear_up_s;
        private System.Windows.Forms.Button clearall_up;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_h2;
        private System.Windows.Forms.ComboBox cb_min2;
        private System.Windows.Forms.ComboBox cb_s2;
        private System.Windows.Forms.Button clear_down_h;
        private System.Windows.Forms.Button clearall_down;
        private System.Windows.Forms.Button clear_down_min;
        private System.Windows.Forms.Button clear_down_s;
        private System.Windows.Forms.Button btn_clearAll;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.RadioButton add;
        private System.Windows.Forms.RadioButton sub;
        private System.Windows.Forms.CheckBox atf;
        private System.Windows.Forms.Button copy_h;
        private System.Windows.Forms.Button copy_min;
        private System.Windows.Forms.Button copy_s;
        private System.Windows.Forms.Button copyall;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.TextBox result_h;
        private System.Windows.Forms.TextBox result_min;
        private System.Windows.Forms.TextBox result_s;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.RadioButton intv;
    }
}


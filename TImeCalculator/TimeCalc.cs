using System;
using System.Threading;
using System.Windows.Forms;
using TimeCalculator;

namespace TImeCalculator
{
    public partial class TimeCalc : Form
    {
        private HelpForm helpFormInstance = null;
        private CancellationTokenSource _cts = null;

        public TimeCalc()
        {
            InitializeComponent();
            log.TabStop = false;
            log.MouseDown += (s, e) => ActiveControl = null;
            log.GotFocus += (s, e) => ActiveControl = null;
            calc.Click += Calc_Click;
            copy_h.Click += Copy_h_Click;
            copy_min.Click += Copy_min_Click;
            copy_s.Click += Copy_s_Click;
            copyall.Click += Copyall_Click;
        }
        private void Fill()
        {
            if(result_h != null && result_h.Text != "0") cb_h1.Text = result_h.Text;
            if(result_min!= null && result_min.Text != "0") cb_min1.Text = result_min.Text;
            if (result_s!= null && result_s.Text != "0") cb_s1.Text = result_s.Text;
        }
        private void Copy_h_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(result_h.Text))
            {
                Clipboard.SetText(result_h.Text);
            }
        }
        private void Copy_min_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(result_min.Text))
            {
                Clipboard.SetText(result_min.Text);
            }
        }

        private void Copy_s_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(result_s.Text))
            {
                Clipboard.SetText(result_s.Text);
            }
        }
        private void Copyall_Click(object sender, EventArgs e)
        {
            string h = string.IsNullOrEmpty(result_h.Text) ? "0" : result_h.Text;
            string m = string.IsNullOrEmpty(result_min.Text) ? "0" : result_min.Text;
            string s = string.IsNullOrEmpty(result_s.Text) ? "0" : result_s.Text;
            string allText = $"{h}:{m}:{s}";
            Clipboard.SetText(allText);
        }
        private void Calc_Click(object sender, EventArgs e)
        {
            _cts?.Cancel(); _cts?.Dispose(); _cts = null;
            log.Clear();

            bool h1Ok = TryParse(cb_h1, out int h1, out bool h1Empty);
            bool m1Ok = TryParse(cb_min1, out int m1, out bool m1Empty);
            bool s1Ok = TryParse(cb_s1, out int s1, out bool s1Empty);
            bool h2Ok = TryParse(cb_h2, out int h2, out bool h2Empty);
            bool m2Ok = TryParse(cb_min2, out int m2, out bool m2Empty);
            bool s2Ok = TryParse(cb_s2, out int s2, out bool s2Empty);

            bool hasInvalid = !h1Ok || !m1Ok || !s1Ok || !h2Ok || !m2Ok || !s2Ok;
            bool allEmpty = h1Empty && m1Empty && s1Empty && h2Empty && m2Empty && s2Empty;

            if (hasInvalid) log.AppendText("请输入有效的整数，不能输入其他字符\r\n");
            if (allEmpty) log.AppendText("请确保上半部分和下半部分都至少有一个输入框有输入时间\r\n");

            if (hasInvalid || allEmpty)
            {
                ClearResult();
                return;
            }

            bool success = true;
            int resH = 0, resM = 0, resS = 0;

            if (add.Checked)
            {
                int carry = 0;
                resS = s1 + s2 + carry;
                carry = resS / 60;
                resS %= 60;

                resM = m1 + m2 + carry;
                carry = resM / 60;
                resM %= 60;

                resH = h1 + h2 + carry;
            }
            else if (sub.Checked)
            {
                int total1 = h1 * 3600 + m1 * 60 + s1;
                int total2 = h2 * 3600 + m2 * 60 + s2;

                if (total1 < total2)
                {
                    log.AppendText("减法结果不能为负数\r\n");
                    success = false;
                }
                else
                {
                    int totalDiff = total1 - total2;
                    resH = totalDiff / 3600;
                    int remain = totalDiff % 3600;
                    resM = remain / 60;
                    resS = remain % 60;
                }
            }
            if (success)
            {
                result_h.Text = resH == 0 ? "" : resH.ToString();
                result_min.Text = (resH == 0 && resM == 0) ? "" : resM.ToString();
                result_s.Text = resS.ToString();
            }
            else
            {
                ClearResult();
            }
            if (atf.Checked) Fill();
        }
        private bool TryParse(Control ctrl, out int val, out bool isEmpty)
        {
            string t = ctrl.Text.Trim();
            isEmpty = string.IsNullOrEmpty(t);
            val = 0;
            return isEmpty || (int.TryParse(t, out val) && val >= 0);
        }
        private void ClearResult() => result_h.Text = result_min.Text = result_s.Text = "";
        private void button9_Click(object sender, EventArgs e)
        {
            cb_h1.Text = cb_min1.Text = cb_s1.Text = cb_h2.Text = cb_min2.Text = cb_s2.Text = log.Text = "";
            cb_h1.Focus();
        }
        private void about_Click(object sender, EventArgs e)
        {
            if (helpFormInstance == null || helpFormInstance.IsDisposed)
            {
                helpFormInstance = new HelpForm();
                helpFormInstance.FormClosed += (s, args) => helpFormInstance = null;
                helpFormInstance.Show();
            }
            else { helpFormInstance.Activate(); }
        }
        private void clear_up_min_Click(object sender, EventArgs e)
        {
            cb_min1.Text = "";
        }
        private void clear_up_s_Click(object sender, EventArgs e)
        {
            cb_s1.Text = "";
        }
        private void clear_up_h_Click(object sender, EventArgs e)
        {
            cb_h1.Text = "";
        }
        private void clearall_up_Click(object sender, EventArgs e)
        {
            cb_h1.Text = cb_min1.Text = cb_s1.Text = "";
        }
        private void clear_down_h_Click(object sender, EventArgs e)
        {
            cb_h2.Text = "";
        }
        private void clear_down_min_Click(object sender, EventArgs e)
        {
            cb_min2.Text = "";
        }
        private void clear_down_s_Click(object sender, EventArgs e)
        {
            cb_s2.Text = "";
        }
        private void clearall_down_Click(object sender, EventArgs e)
        {
            cb_h2.Text = cb_min2.Text = cb_s2.Text = "";
        }
        private void fill_Click(object sender, EventArgs e) { Fill(); }
        private void log_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
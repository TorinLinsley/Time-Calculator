using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TimeCalculator;
namespace TImeCalculator {
    public partial class TimeCalc : Form {
        private HelpForm helpFormInstance = null;
        private CancellationTokenSource _cts = null;
        public TimeCalc() {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 10;
            toolTip.ReshowDelay = 10;
            toolTip.ShowAlways = true;
            toolTip.OwnerDraw = true;
            Font customFont = new Font("微软雅黑", 12F, FontStyle.Regular);
            toolTip.SetToolTip(this.colonForm, "勾选时，将计算结果的复制格式变为用 d h min s 来分隔，而不是用冒号分隔");
            toolTip.SetToolTip(this.fill, "将计算结果4个非空的输入框内容填充至加减数区域的输入框");
            toolTip.SetToolTip(this.intv, "计算两个时间之间的间隔");
            toolTip.SetToolTip(this.about, "关于（F6）");
            toolTip.SetToolTip(this.atf, "点击计算按钮后是否自动将结果填充到加减数区域的输入框中，以便连续计算加减法");
            toolTip.Popup += (s, e) => { if (s is ToolTip tt && e.AssociatedControl != null) { string text = tt.GetToolTip(e.AssociatedControl); if (!string.IsNullOrEmpty(text)) { Size size = TextRenderer.MeasureText(text, customFont); e.ToolTipSize = new Size(size.Width + 10, size.Height + 6); } } };
            toolTip.Draw += (s, e) => { using (SolidBrush bgBrush = new SolidBrush(this.BackColor)) e.Graphics.FillRectangle(bgBrush, e.Bounds); using (Pen borderPen = new Pen(Color.LightGray)) e.Graphics.DrawRectangle(borderPen, 0, 0, e.Bounds.Width - 1, e.Bounds.Height - 1); if (s is ToolTip tt && e.AssociatedControl != null) { string text = tt.GetToolTip(e.AssociatedControl); TextRenderer.DrawText(e.Graphics, text, customFont, e.Bounds, SystemColors.ControlText, TextFormatFlags.Left | TextFormatFlags.VerticalCenter); } };
            log.TabStop = false;
            log.MouseDown += (s, e) => ActiveControl = null;
            log.GotFocus += (s, e) => ActiveControl = null;
            calc.Click += Calc_Click;
            copy_h.Click += Copy_h_Click;
            copy_min.Click += Copy_min_Click;
            copy_s.Click += Copy_s_Click;
            copyall.Click += Copyall_Click;
        }
        private void Fill() {
            cb_d1.Text = result_d.Text;
            cb_h1.Text = result_h.Text;
            cb_min1.Text = result_min.Text;
            cb_s1.Text = result_s.Text;
        }
        private void copy_d_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(result_h.Text)) {
                Clipboard.SetText(result_d.Text);
            }
        }
        private void Copy_h_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(result_h.Text)) {
                Clipboard.SetText(result_h.Text);
            }
        }
        private void Copy_min_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(result_min.Text)) {
                Clipboard.SetText(result_min.Text);
            }
        }
        private void Copy_s_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(result_s.Text)) {
                Clipboard.SetText(result_s.Text);
            }
        }
        private void Copyall_Click(object sender, EventArgs e) {
            string d = string.IsNullOrEmpty(result_d.Text) ? "0" : result_d.Text;
            string h = string.IsNullOrEmpty(result_h.Text) ? "0" : result_h.Text;
            string m = string.IsNullOrEmpty(result_min.Text) ? "0" : result_min.Text;
            string s = string.IsNullOrEmpty(result_s.Text) ? "0" : result_s.Text;
            string allText;
            if (colonForm.Checked) allText = $"{d}:{h}:{m}:{s}";
            else allText = $"{d}d {h}h {m}min {s}s";
            Clipboard.SetText(allText);
        }
        private void Calc_Click(object sender, EventArgs e) {
            _cts?.Cancel(); _cts?.Dispose(); _cts = null;
            log.Clear();
            bool d1Ok = TryParse(cb_d1, out int d1, out bool d1Empty);
            bool h1Ok = TryParse(cb_h1, out int h1, out bool h1Empty);
            bool m1Ok = TryParse(cb_min1, out int m1, out bool m1Empty);
            bool s1Ok = TryParse(cb_s1, out int s1, out bool s1Empty);
            bool d2Ok = TryParse(cb_d2, out int d2, out bool d2Empty);
            bool h2Ok = TryParse(cb_h2, out int h2, out bool h2Empty);
            bool m2Ok = TryParse(cb_min2, out int m2, out bool m2Empty);
            bool s2Ok = TryParse(cb_s2, out int s2, out bool s2Empty);
            bool hasInvalid = !d1Ok || !h1Ok || !m1Ok || !s1Ok || !d2Ok || !h2Ok || !m2Ok || !s2Ok;
            bool allEmpty = d1Empty && h1Empty && m1Empty && s1Empty && d2Empty && h2Empty && m2Empty && s2Empty;
            if (hasInvalid) log.AppendText("请输入有效的整数，不能输入其他字符\r\n");
            if (allEmpty) log.AppendText("请确保上半部分和下半部分都至少有一个输入框有输入时间\r\n");
            if (hasInvalid || allEmpty) {
                ClearResult();
                return;
            }
            bool success = true;
            int resD = 0, resH = 0, resM = 0, resS = 0;
            if (add.Checked) {
                int carry = 0;
                resS = s1 + s2 + carry;
                carry = resS / 60;
                resS %= 60;
                resM = m1 + m2 + carry;
                carry = resM / 60;
                resM %= 60;
                resH = h1 + h2 + carry;
                carry = resH / 24;
                resH %= 24;
                resD = d1 + d2 + carry;
            }
            else if (sub.Checked) {
                int total1 = d1 * 86400 + h1 * 3600 + m1 * 60 + s1;
                int total2 = d2 * 86400 + h2 * 3600 + m2 * 60 + s2;
                if (total1 < total2) {
                    log.AppendText("减法结果不能为负数\r\n");
                    success = false;
                }
                else {
                    int totalDiff = total1 - total2;
                    resD = totalDiff / 86400;
                    int remain = totalDiff % 86400;
                    resH = remain / 3600;
                    remain = remain % 3600;
                    resM = remain / 60;
                    resS = remain % 60;
                }
            }
            else if (intv.Checked) {
                int total1 = d1 * 86400 + h1 * 3600 + m1 * 60 + s1;
                int total2 = d2 * 86400 + h2 * 3600 + m2 * 60 + s2;
                int interval = Math.Abs(total2 - total1);
                resD = interval / 86400;
                int remain = interval % 86400;
                resH = remain / 3600;
                remain = remain % 3600;
                resM = remain / 60;
                resS = remain % 60;
            }
            if (success) {
                result_d.Text = resD == 0 ? "" : resD.ToString();
                result_h.Text = (resD == 0 && resH == 0) ? "" : resH.ToString();
                result_min.Text = (resD == 0 && resH == 0 && resM == 0) ? "" : resM.ToString();
                result_s.Text = resS.ToString();
            }
            else {
                ClearResult();
            }
            if (atf.Checked) Fill();
        }
        private bool TryParse(Control ctrl, out int val, out bool isEmpty) {
            string t = ctrl.Text.Trim();
            isEmpty = string.IsNullOrEmpty(t);
            val = 0;
            return isEmpty || (int.TryParse(t, out val) && val >= 0);
        }
        private void ClearResult() => result_h.Text = result_min.Text = result_s.Text = "";
        private void clearAll(object sender, EventArgs e) {
            if ((ModifierKeys & Keys.Shift) != 0) {
                clearAllPlus(sender, e);
            }
            else {
                cb_d1.Text = cb_h1.Text = cb_min1.Text = cb_s1.Text = cb_d2.Text = cb_h2.Text = cb_min2.Text = cb_s2.Text = log.Text = "";
                cb_d1.Focus();
            }
        }
        private void clearAllPlus(object sender, EventArgs e) {
            result_d.Text = result_h.Text = result_min.Text = result_s.Text = cb_d1.Text = cb_h1.Text = cb_min1.Text = cb_s1.Text = cb_d2.Text = cb_h2.Text = cb_min2.Text = cb_s2.Text = log.Text = "";
            cb_d1.Focus();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.F6) {
                about_Click(null, EventArgs.Empty);
                return true;
            }
            else if (keyData == Keys.Enter || keyData == Keys.Oemplus) {
                Calc_Click(null, EventArgs.Empty);
                return true;
            }
            else if (keyData == Keys.Add || keyData == (Keys.Oemplus | Keys.Shift)) {
                add.Checked = true;
                return true;
            }
            else if (keyData == Keys.Subtract || keyData == Keys.OemMinus) {
                sub.Checked = true;
                return true;
            }
            else if (keyData == Keys.PageDown || keyData == Keys.I) {
                intv.Checked = true;
                return true;
            }
            else if (keyData == Keys.F || keyData == Keys.W) {
                Fill();
                return true;
            }
            else if (keyData == Keys.C || keyData == Keys.W) {
                clearAll(null, EventArgs.Empty);
                return true;
            }
            else if (keyData == (Keys.C | Keys.Shift) || keyData == Keys.W) {
                clearAllPlus(null, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void about_Click(object sender, EventArgs e) {
            if (helpFormInstance == null || helpFormInstance.IsDisposed) {
                helpFormInstance = new HelpForm();
                helpFormInstance.FormClosed += (s, args) => helpFormInstance = null;
                helpFormInstance.Show();
            }
            else { helpFormInstance.Activate(); }
        }
        private void clear_up_min_Click(object sender, EventArgs e) {
            cb_min1.Text = "";
        }
        private void clear_up_s_Click(object sender, EventArgs e) {
            cb_s1.Text = "";
        }
        private void clear_up_d_Click(object sender, EventArgs e) {
            cb_d1.Text = "";
        }
        private void clear_up_h_Click(object sender, EventArgs e) {
            cb_h1.Text = "";
        }
        private void clearall_up_Click(object sender, EventArgs e) {
            cb_d1.Text = cb_h1.Text = cb_min1.Text = cb_s1.Text = "";
        }
        private void clear_down_d_Click(object sender, EventArgs e) {
            cb_d2.Text = "";
        }
        private void clear_down_h_Click(object sender, EventArgs e) {
            cb_h2.Text = "";
        }
        private void clear_down_min_Click(object sender, EventArgs e) {
            cb_min2.Text = "";
        }
        private void clear_down_s_Click(object sender, EventArgs e) {
            cb_s2.Text = "";
        }
        private void clearall_down_Click(object sender, EventArgs e) {
            cb_d2.Text = cb_h2.Text = cb_min2.Text = cb_s2.Text = "";
        }
        private void fill_Click(object sender, EventArgs e) { Fill(); }
        private void log_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

    }
}
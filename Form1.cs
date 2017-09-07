using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;


namespace CSharp剪贴板监视器
{
    public partial class Form1 : Form
    {
        #region Definitions
        //Constants for API Calls...
        private const int WM_DRAWCLIPBOARD = 0x308;
        private const int WM_CHANGECBCHAIN = 0x30D;

        //Handle for next clipboard viewer...
        private IntPtr mNextClipBoardViewerHWnd;

        //API declarations...
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern bool ChangeClipboardChain(IntPtr HWnd, IntPtr HWndNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //private static extern int SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int Width, int Height, int flags);
        ///// <summary>   
        ///// 得到当前活动的窗口   
        ///// </summary>   
        ///// <returns></returns>   
        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //private static extern IntPtr GetForegroundWindow();
        #endregion

        #region Contructor
        public void NewViewer()
        {
            //InitializeComponent()
            //To register this form as a clipboard viewer...
            mNextClipBoardViewerHWnd = SetClipboardViewer(this.Handle);
        }
        #endregion

        public Form1()
        {
            InitializeComponent();

            //SetWindowPos(GetForegroundWindow(), -1, 0, 0, 0, 0, 1 | 4);
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewViewer();
            Point sp = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Left = sp.X -this.Width*6/5; // dp.X + 600;
            this.Top = (sp.Y - this.Height) / 2;
        }

        #region Message Process
        //Override WndProc to get messages...
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    {
                        //The clipboard has changed...
                        //##########################################################################
                        // Process Clipboard Here :)........................
                        //##########################################################################
                        SendMessage(mNextClipBoardViewerHWnd, m.Msg, m.WParam.ToInt32(), m.LParam.ToInt32());

                        //显示剪贴板中的文本信息
                        if (Clipboard.ContainsText())
                        {
                            string ready = Clipboard.GetText();
                            if(ready != textBox5.Text && ready != textBox4.Text && ready != textBox3.Text && ready != textBox2.Text
                                && ready != textBox1.Text)
                            {
                                textBox5.Text = textBox4.Text;
                                textBox4.Text = textBox3.Text;
                                textBox3.Text = textBox2.Text;
                                textBox2.Text = textBox1.Text;
                                textBox1.Text = ready;
                            }
                           
                        }
                        break;
                    }
                case WM_CHANGECBCHAIN:
                    {
                        //Another clipboard viewer has removed itself...
                        if (m.WParam == (IntPtr)mNextClipBoardViewerHWnd)
                        {
                            mNextClipBoardViewerHWnd = m.LParam;
                        }
                        else
                        {
                            SendMessage(mNextClipBoardViewerHWnd, m.Msg, m.WParam.ToInt32(), m.LParam.ToInt32());
                        }
                        break;
                    }
            }
            base.WndProc(ref m);
        }
        #endregion



        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            // 点击"是(YES)"退出程序

                if (MessageBox.Show("确定要离开?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                notifyIcon1.Visible = false;   //设置图标不可见
                this.Dispose();                //释放资源
                Application.Exit();            //关闭应用程序窗体
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Txt_changeWidth(sender);
        }

        public void Txt_changeWidth(object sender)
        {
            if (sender is TextBox)
            {
                if ((sender as TextBox).Text != "")
                {
                    if ((sender as TextBox).Width < 30 || (sender as TextBox).TextLength <= 16)
                    {
                        if ((sender as TextBox).TextLength >= 1)
                        {
                            //判断是否为汉字，关键
                            const string pattern1 = @"^[\u4e00-\u9fa5]+$";
                            Graphics g = (sender as TextBox).CreateGraphics();
                            System.Drawing.SizeF s = g.MeasureString((sender as TextBox).Text, (sender as TextBox).Font);
                            if (Regex.IsMatch((sender as TextBox).Text, pattern1))
                            {
                                (sender as TextBox).Width = (int)s.Width + 14;
                            }
                            else
                            {
                                (sender as TextBox).Width = (int)s.Width + 8;
                            }
                        }
                    }
                }
                else
                {
                    //没内容时回到初始大小
                    (sender as TextBox).Width = 32;
                }
            }
        }



        private void 清除ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.SelectAll();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.SelectAll();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.SelectAll();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //窗体关闭原因为单击"关闭"按钮或Alt+F4
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;           //取消关闭操作 表现为不关闭窗体
                this.Hide();               //隐藏窗体
                MessageBox.Show("多剪已最小化至托盘", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 点击"是(YES)"退出程序

                if (MessageBox.Show("确定要离开?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                notifyIcon1.Visible = false;   //设置图标不可见
                this.Dispose();                //释放资源
                Application.Exit();            //关闭应用程序窗体
            }
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Visible = true;                        //窗体可见
            }
        }
    }
}

namespace CSharp剪贴板监视器
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.清除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("思源宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.清除ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(266, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_exit});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.文件FToolStripMenuItem.Text = "设置";
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Font = new System.Drawing.Font("思源宋体", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(152, 22);
            this.tsmi_exit.Text = "退出";
            this.tsmi_exit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("思源宋体 SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(34, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(198, 78);
            this.textBox1.TabIndex = 4;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("思源宋体 SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(34, 165);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(198, 78);
            this.textBox2.TabIndex = 5;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("思源宋体 SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox3.Location = new System.Drawing.Point(34, 276);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(198, 78);
            this.textBox3.TabIndex = 6;
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            this.textBox3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("思源宋体 SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox4.Location = new System.Drawing.Point(34, 389);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(198, 78);
            this.textBox4.TabIndex = 7;
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            this.textBox4.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("思源宋体 SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox5.Location = new System.Drawing.Point(34, 500);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(198, 78);
            this.textBox5.TabIndex = 8;
            this.textBox5.Click += new System.EventHandler(this.textBox5_Click);
            this.textBox5.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // 清除ToolStripMenuItem
            // 
            this.清除ToolStripMenuItem.Name = "清除ToolStripMenuItem";
            this.清除ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.清除ToolStripMenuItem.Text = "清除";
            this.清除ToolStripMenuItem.Click += new System.EventHandler(this.清除ToolStripMenuItem_Click_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "多剪";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 611);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("思源宋体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "多剪";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ToolStripMenuItem 清除ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}


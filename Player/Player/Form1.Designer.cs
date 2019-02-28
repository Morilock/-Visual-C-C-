namespace Player
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
            this.添加文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部分方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.外观ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放列表折叠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.顺序播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单曲循环ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部循环ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.随机播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除重复文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除错误文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除选择文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除全部文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加文件ToolStripMenuItem,
            this.删除文件ToolStripMenuItem,
            this.部分方式ToolStripMenuItem,
            this.外观ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加文件ToolStripMenuItem
            // 
            this.添加文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件夹ToolStripMenuItem,
            this.打开文件ToolStripMenuItem});
            this.添加文件ToolStripMenuItem.Name = "添加文件ToolStripMenuItem";
            this.添加文件ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加文件ToolStripMenuItem.Text = "添加文件";
            // 
            // 打开文件夹ToolStripMenuItem
            // 
            this.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem";
            this.打开文件夹ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打开文件夹ToolStripMenuItem.Text = "打开文件夹";
            this.打开文件夹ToolStripMenuItem.Click += new System.EventHandler(this.打开文件夹ToolStripMenuItem_Click);
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 删除文件ToolStripMenuItem
            // 
            this.删除文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除重复文件ToolStripMenuItem,
            this.删除错误文件ToolStripMenuItem,
            this.删除选择文件ToolStripMenuItem,
            this.删除全部文件ToolStripMenuItem});
            this.删除文件ToolStripMenuItem.Name = "删除文件ToolStripMenuItem";
            this.删除文件ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.删除文件ToolStripMenuItem.Text = "删除文件";
            // 
            // 部分方式ToolStripMenuItem
            // 
            this.部分方式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顺序播放ToolStripMenuItem,
            this.单曲循环ToolStripMenuItem,
            this.全部循环ToolStripMenuItem,
            this.随机播放ToolStripMenuItem});
            this.部分方式ToolStripMenuItem.Name = "部分方式ToolStripMenuItem";
            this.部分方式ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.部分方式ToolStripMenuItem.Text = "播放方式";
            // 
            // 外观ToolStripMenuItem
            // 
            this.外观ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.播放列表折叠ToolStripMenuItem});
            this.外观ToolStripMenuItem.Name = "外观ToolStripMenuItem";
            this.外观ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.外观ToolStripMenuItem.Text = "外观";
            // 
            // 播放列表折叠ToolStripMenuItem
            // 
            this.播放列表折叠ToolStripMenuItem.Name = "播放列表折叠ToolStripMenuItem";
            this.播放列表折叠ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.播放列表折叠ToolStripMenuItem.Text = "播放列表折叠";
            this.播放列表折叠ToolStripMenuItem.Click += new System.EventHandler(this.播放列表折叠ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(704, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "打开文件夹";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "添加文件";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "mp3文件|*.mp3|wma文件|*.wma|所有文件*.*|*.*";
            this.openFileDialog1.Multiselect = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axWindowsMediaPlayer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(704, 424);
            this.splitContainer1.SplitterDistance = 569;
            this.splitContainer1.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(569, 424);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(131, 424);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "播放文件名";
            this.columnHeader2.Width = 177;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "路径";
            this.columnHeader3.Width = 0;
            // 
            // 顺序播放ToolStripMenuItem
            // 
            this.顺序播放ToolStripMenuItem.Name = "顺序播放ToolStripMenuItem";
            this.顺序播放ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.顺序播放ToolStripMenuItem.Text = "顺序播放";
            this.顺序播放ToolStripMenuItem.Click += new System.EventHandler(this.顺序播放ToolStripMenuItem_Click);
            // 
            // 单曲循环ToolStripMenuItem
            // 
            this.单曲循环ToolStripMenuItem.Name = "单曲循环ToolStripMenuItem";
            this.单曲循环ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.单曲循环ToolStripMenuItem.Text = "单曲循环";
            this.单曲循环ToolStripMenuItem.Click += new System.EventHandler(this.单曲循环ToolStripMenuItem_Click);
            // 
            // 全部循环ToolStripMenuItem
            // 
            this.全部循环ToolStripMenuItem.Name = "全部循环ToolStripMenuItem";
            this.全部循环ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.全部循环ToolStripMenuItem.Text = "全部循环";
            this.全部循环ToolStripMenuItem.Click += new System.EventHandler(this.全部循环ToolStripMenuItem_Click);
            // 
            // 随机播放ToolStripMenuItem
            // 
            this.随机播放ToolStripMenuItem.Name = "随机播放ToolStripMenuItem";
            this.随机播放ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.随机播放ToolStripMenuItem.Text = "随机播放";
            this.随机播放ToolStripMenuItem.Click += new System.EventHandler(this.随机播放ToolStripMenuItem_Click);
            // 
            // 删除重复文件ToolStripMenuItem
            // 
            this.删除重复文件ToolStripMenuItem.Name = "删除重复文件ToolStripMenuItem";
            this.删除重复文件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除重复文件ToolStripMenuItem.Text = "删除重复文件";
            // 
            // 删除错误文件ToolStripMenuItem
            // 
            this.删除错误文件ToolStripMenuItem.Name = "删除错误文件ToolStripMenuItem";
            this.删除错误文件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除错误文件ToolStripMenuItem.Text = "删除错误文件";
            // 
            // 删除选择文件ToolStripMenuItem
            // 
            this.删除选择文件ToolStripMenuItem.Name = "删除选择文件ToolStripMenuItem";
            this.删除选择文件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除选择文件ToolStripMenuItem.Text = "删除选择文件";
            // 
            // 删除全部文件ToolStripMenuItem
            // 
            this.删除全部文件ToolStripMenuItem.Name = "删除全部文件ToolStripMenuItem";
            this.删除全部文件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除全部文件ToolStripMenuItem.Text = "删除全部文件";
            this.删除全部文件ToolStripMenuItem.Click += new System.EventHandler(this.删除全部文件ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 474);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "播放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem 添加文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部分方式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 外观ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放列表折叠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem 删除重复文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除错误文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除选择文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除全部文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顺序播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单曲循环ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部循环ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 随机播放ToolStripMenuItem;
    }
}


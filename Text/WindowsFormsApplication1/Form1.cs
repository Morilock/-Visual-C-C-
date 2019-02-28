using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static string openfilepath = "";			//保存所打开文件的路径
        public Form1()
        {	InitializeComponent();  }
	    /*打开子菜单事件用于打开文件文件*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*新建子菜单事件用于新建文件文件*/
        private void 新建UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {
                /*提示保存对话框*/
                DialogResult dResult = MessageBox.Show("文件" + this.Text + "的内容已改变，需要保存吗？", "保存文件", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dResult)
                {
                    case DialogResult.Yes:
                        另存为ToolStripMenuItem_Click(null, null);
                        richTextBox1.Clear();
                        this.Text = "无标题－记事本";
                        break;
                    case DialogResult.No:
                        richTextBox1.Clear();
                        this.Text = "无标题－记事本";
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                richTextBox1.Clear();
                this.Text = "无标题－记事本";
                richTextBox1.Modified = false;
            }
        }
        /*打开子菜单事件用于打开文件文件*/
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"; 	//设置文件类型   
            openFileDialog1.FilterIndex = 1;            	//设置默认文件类型的显示顺序
            openFileDialog1.RestoreDirectory = true;    	//打开对话框是否记忆上次打开的目录
            StreamReader sr = null;					//定义StreamReader对象
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    openfilepath = openFileDialog1.FileName;				//获取打开的文件路径
                    string name = openfilepath.Substring(openfilepath.LastIndexOf("\\") + 1);
                    this.Text = name;								//文件名作为标题
                    sr = new StreamReader(openfilepath, Encoding.Default);	//实例化sr
                    richTextBox1.Text = sr.ReadToEnd();					//读取所有文件内容
                }
                catch
                {
                    MessageBox.Show("打开文件时出错。", "错误",
                       System.Windows.Forms.MessageBoxButtons.OK,
                       System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }
                finally
                {
                    if (sr != null)
                    {
                        sr.Close();				//关闭对象sr
                        sr.Dispose();			//释放对象sr资源
                    }
                }
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            if (openfilepath == "")
            {
                另存为ToolStripMenuItem_Click(null, null);      //调用另存为方法
                return;
            }
            try
            {
                sw = new StreamWriter(openfilepath, false, Encoding.Default);
                sw.Write(richTextBox1.Text);
                toolStripStatusLabel1.Text = "保存成功";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", System.Windows.Forms.MessageBoxButtons.
                    OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();     			//关闭StreamWriter
                    sw.Dispose();   			//释放资源
                }
            }
        }
        /*另存为菜单事件用于将文件另存到电脑中*/
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"; //设置文件类型   
            saveFileDialog1.FilterIndex = 2;		//设置默认文件类型的显示顺序
            saveFileDialog1.RestoreDirectory = true;	//保存对话框是否记忆上次打开的目录
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openfilepath = saveFileDialog1.FileName.ToString(); //获取文件路径   
                FileStream fs;
                try
                { fs = File.Create(openfilepath); }
                catch
                {
                    MessageBox.Show("建立文件时出错。", "错误",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }
                byte[] content = Encoding.Default.GetBytes(richTextBox1.Text);
                try
                {
                    fs.Write(content, 0, content.Length);
                    fs.Flush();
                    toolStripStatusLabel1.Text = "保存成功";
                }
                catch
                {
                    MessageBox.Show("写入文件时出错。", "错误",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                }
                finally
                {
                    fs.Close();
                    fs.Dispose();
                }
            }
        }
        /*以下子菜单事件分别实现打印、退出等功能*/

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 剪切ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 复制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 粘贴ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void 查找ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.richtextbox = richTextBox1;
            ff.ShowDialog();
        }

        private void 替换ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 ff = new Form3();
            ff.richText = richTextBox1;
            ff.ShowDialog();
        }

        private void 全选ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 时间日期ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectedText = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.
                    Second.ToString() + " " + DateTime.Now.Year.ToString() + "-" + DateTime.
                    Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            }
            else
            {
                richTextBox1.SelectedText += DateTime.Now.Hour.ToString() + ":" + DateTime.
                    Now.Second.ToString() + " " + DateTime.Now.Year.ToString() + "-" + DateTime.
                    Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            }
        }
        /*自动换行子菜单用来控制文本是否自动换行*/

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap == true)
            {
                richTextBox1.WordWrap = false;
                自动换行ToolStripMenuItem.Checked = false;
                richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            }
            else
            {
                richTextBox1.WordWrap = true;
                自动换行ToolStripMenuItem.Checked = true;
                richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            }
        }
        /*字体子菜单用来设置所选择的文本字体*/

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                richTextBox1.SelectionFont = font;
            }
        }
        /*状态栏子菜单用来设置是否显示状态栏*/

        private void 状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusStrip1.Visible == true)
            {
                statusStrip1.Visible = false;
                状态栏ToolStripMenuItem.Checked = false;
                richTextBox1.Height += 22;
            }
            else
            {
                statusStrip1.Visible = true;
                状态栏ToolStripMenuItem.Checked = true;
                richTextBox1.Height -= 22;
            }
        }

        private void 关于记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此记事的版本为V1.0！");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public RichTextBox richtextbox;
        public int start = 0;
        public Form2()
        { InitializeComponent(); }
        private void button1_Click_1(object sender, EventArgs e)  	//查找下一个
        {
            richtextbox.SelectionColor = Color.Blue;            //显示为蓝色
            string str;
            str = textBox1.Text;
            if (checkBox1.Checked)
            {
                if (radioButton2.Checked)
                { checkUp(str); }
                else
                { checkDown(str); }
            }
            else
            {
                if (radioButton1.Checked)
                { uncheckDown(str); }
                else
                { uncheckUp(str); }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)	//取消
        {
            this.Close();
        }
        public void checkDown(string ss)                    	//区分大小写向下查找
        {
            int c = 0;
            int b = 0;
            try
            {
                c = richtextbox.SelectionStart;
                b = richtextbox.Text.IndexOf(ss, c + ss.Length, StringComparison.CurrentCulture);
                richtextbox.SelectionStart = b;
                richtextbox.SelectionLength = ss.Length;
                richtextbox.SelectionColor = Color.Red;      	//显示为红色
            }
            catch
            {
                MessageBox.Show("已查找到文档的结尾", "查找结束对话框",
                    MessageBoxButtons.OK);
                this.textBox1.SelectionStart = c;
                this.textBox1.SelectionLength = ss.Length;
            }
        }
        public void checkUp(string ss)						//区分大小写向上查找
        {
            int c = 0;
            int b = 0;
            try
            {
                c = richtextbox.SelectionStart;
                b = richtextbox.Text.LastIndexOf(ss, c - ss.Length, StringComparison.InvariantCulture);
                richtextbox.SelectionStart = b;
                richtextbox.SelectionLength = ss.Length;
                richtextbox.SelectionColor = Color.Red;         //显示为红色
            }
            catch
            {
                MessageBox.Show("已查找到文档的结尾", "查找结束对话框",
                    MessageBoxButtons.OK);
                richtextbox.SelectionStart = c;
                richtextbox.SelectionLength = ss.Length;
            }
        }
        public void uncheckDown(string ss) 				//不区分大小写向下查找
        {
            int c = 0;
            int b = 0;
            try
            {
                c = richtextbox.SelectionStart;
                b = richtextbox.Text.IndexOf(ss, c + ss.Length, StringComparison.CurrentCultureIgnoreCase);
                richtextbox.SelectionStart = b;
                richtextbox.SelectionLength = ss.Length;
                richtextbox.SelectionColor = Color.Red;         //显示为红色
            }
            catch
            {
                MessageBox.Show("已查找到文档的结尾", "查找结束对话框",
                    MessageBoxButtons.OK);
                richtextbox.SelectionStart = c;
                richtextbox.SelectionLength = ss.Length;
            }
        }
        public void uncheckUp(string ss)					//不区分大小写向上查找
        {
            int c = 0;
            int b = 0;
            try
            {
                c = richtextbox.SelectionStart;
                b = richtextbox.Text.LastIndexOf(ss, c - ss.Length,
                StringComparison.InvariantCultureIgnoreCase);
                richtextbox.SelectionStart = b;
                richtextbox.SelectionLength = ss.Length;
                richtextbox.SelectionColor = Color.Red;         //显示为红色
            }
            catch
            {
                MessageBox.Show("已查找到文档的结尾", "查找结束对话框",
                    MessageBoxButtons.OK);
                richtextbox.SelectionStart = c;
                richtextbox.SelectionLength = ss.Length;
            }
        }
    }
}

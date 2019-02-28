using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 作业1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r = textBox1.Text.Trim();
            string code = "2015210830";
            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "输入不能为空值！");
                return;
            }
            if (r == code)
            {
                label2.Text = "于浩正";
                label3.Text = "山东省潍坊市";
                label4.Text = "围棋、足球";
                label5.Text = "机器学习科学家";
            }
            else
            {
                label2.Text = "此学号信息缺失";
                label3.Text = "此学号信息缺失";
                label4.Text = "此学号信息缺失";
                label5.Text = "此学号信息缺失";
            }
        }
    }
}

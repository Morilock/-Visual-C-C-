using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 作业1_4
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
            string mainname = "于浩正";
            string friend1 = "张明";
            string friend2 = "王平";
            string friend3 = "李梅";
            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "输入不能为空值！");
                return;
            }
            if (r == mainname)
            {
                label2.Text = "男，20岁";
                label3.Text = "山东省潍坊市";
                label4.Text = "围棋、足球";
                label5.Text = "机器学习科学家";
            }
            else if (r == friend1)
            {
                label2.Text = "男，22岁";
                label3.Text = "湖北省武汉市";
                label4.Text = "篮球，小提琴";
                label5.Text = "机械工程师";
            }
            else if (r == friend2)
            {
                label2.Text = "男，21岁";
                label3.Text = "江苏省南京市";
                label4.Text = "游泳，写作";
                label5.Text = "摄影师";
            }
            else if (r == friend3)
            {
                label2.Text = "女，19岁";
                label3.Text = "四川省成都市";
                label4.Text = "电影，钢琴";
                label5.Text = "作家";
            }
            else
            {
                label2.Text = "此人信息缺失";
                label3.Text = "此人信息缺失";
                label4.Text = "此人信息缺失";
                label5.Text = "此人信息缺失";
            }
        }
    }
}

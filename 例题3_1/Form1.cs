using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 例题3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r = textBox1.Text.Trim();				
            double DouR = Convert.ToDouble(r);			
            const double PI = 3.1415926;					
            label1.Text = "圆的面积为：" + PI * DouR * DouR;	
        }
    }
}

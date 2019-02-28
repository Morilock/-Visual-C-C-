using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 例题3_8
{
    public partial class Form3 : Form1
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox1.Text.Trim());
            double k = Convert.ToDouble(textBox2.Text.Trim());
            Rectangular R = new Rectangular(c, k);
            label3.Text = "矩形面积:" + R.GetArea();
        }
    }
}

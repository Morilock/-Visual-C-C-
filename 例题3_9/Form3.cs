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
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "矩形边长不能为空值！");
                return;
            }
            double c = Convert.ToDouble(textBox1.Text.Trim());
            double k = Convert.ToDouble(textBox2.Text.Trim());
            Rectangular R = new Rectangular(c, k);
            label3.Text = "矩形面积:" + R.GetArea();	
        }
    }
}

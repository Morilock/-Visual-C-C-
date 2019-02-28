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
    public partial class Form4 : Form1
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "正方形边长不能为空值！");
                return;
            }
            Square S = new Square(Convert.ToDouble(textBox1.Text.Trim()));
            label2.Text = "正方形面积：" + S.GetArea();
        }
    }
}

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
    public partial class Form2 : Form1
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "圆的半径不能为空值！");	
                return;										
            }
            Circle C = new Circle(Convert.ToDouble(textBox1.Text.Trim()));  
            label2.Text = "圆的面积：" + C.GetArea();
        }
    }
}

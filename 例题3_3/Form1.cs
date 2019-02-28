using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 例题3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string R = textBox1.Text.Trim();			
            double GetR = Convert.ToDouble(R);      	
            Circle C = new Circle(GetR);        		
            label2.Text = "圆的面积为：" + C.area.ToString();
        }
        class Circle            					
        {
            public double area;
            const double PI = 3.141592653589793;  	 	
            public Circle(double r)                 	
            { area = PI * r * r; }
        }

    }
}

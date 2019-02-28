using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 例题3_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CGraph C = new CGraph();        		
            if (textBox1.Text.Trim() != "") 		
            {
                if (textBox1.Text.Trim().IndexOf('.') == -1)			
                {
                    int i1 = Convert.ToInt32(textBox1.Text.Trim());	
                    C. calculate (i1);        				
                }
                else  							
                {
                    double d1 = Convert.ToDouble(textBox1.Text.Trim());
                    C. calculate (d1);
                }
                
            }else if(textBox2.Text.Trim()!=""&&textBox3.Text.Trim()!="")
            {
                double d2 = Convert.ToDouble(textBox2.Text.Trim());
                double d3 = Convert.ToDouble(textBox3.Text.Trim());
                C. calculate (d2,d3);
            }else if(textBox4.Text.Trim()!=""&&textBox5.Text.Trim()!=""&&textBox6.Text.Trim()!="")
            {
                double d4 = Convert.ToDouble(textBox4.Text.Trim());
                double d5 = Convert.ToDouble(textBox5.Text.Trim());
                double d6 = Convert.ToDouble(textBox6.Text.Trim());
                C. calculate (d4,d5,d6);
            }
            label7.Text = CGraph.result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
            label7.Text = string.Empty;
        }
    }
    
    class CGraph
    {
        double S;               							//面积
        public static string result="没有结果";					//最终输出的结果
        public void calculate (double r)  						//计算高精度圆面积
        {
           
            S=Math.PI * r * r;
            result = "高精度圆面积为：" + S.ToString();
        }
        public void calculate (int r)							//计算低精度圆面积
        {
            S = 3.1416 * r * r;
            result = "低精度圆面积为：" + S.ToString();
        }
        public void calculate (double c, double k)  				//计算矩形面积
        {
            S = c * k;
            result = "计算矩形面积:" + S.ToString();
        }
        public void calculate (double a1, double a2, double a3)		//计算三角形面积
        {
            //利用海伦公式求三角形面积
            double P=0.5*(a1+a2+a3);
            S = Math.Sqrt(P * (P-a1) * (P-a2) * (P-a3));
            result = "三角形面积:" + S.ToString();
        }
    }
}

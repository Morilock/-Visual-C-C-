using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 例题3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] array = new int[3] { r.Next(100), r.Next(100), r.Next(100) };
            textBox1.Text = "随机生成的3个数为:" +
            array[0].ToString() + "," + array[1].ToString() + "," + array[2].ToString() + "\r\n";
            int Max;
            Sort S = new Sort();
            Max = S.Sort_1(array[0], array[1], array[2]);
            textBox1.Text += "值参数方法，最大值为：" + Max.ToString() + "\r\n";
            S.Sort_2(ref array[0], ref array[1], ref array[2]);
            textBox1.Text += "引用参数方法，最大值为：" + array[2].ToString() + "\r\n";
            S.Sort_3(array[0], array[1], array[2], out Max);
            textBox1.Text += "输出参数方法，最大值为:" + Max.ToString() + "\r\n";
            S.Sort_4(out Max, array);
            textBox1.Text += "参数数组方法，最大值为:" + Max.ToString();
        }

        class Sort							
        {
            public int Sort_1(int x, int y, int z)     	
            {
                int tmp;                           
                if (x > y) { tmp = x; x = y; y = tmp; }
                if (x > z) { tmp = x; x = z; z = tmp; }
                if (y > z) { tmp = y; y = z; z = tmp; }
                return z;					
            }
            public void Sort_2(ref int x, ref int y, ref int z) 	
            {
                int tmp;                            	  
                if (x > y) { tmp = x; x = y; y = tmp; }
                if (x > z) { tmp = x; x = z; z = tmp; }
                if (y > z) { tmp = y; y = z; z = tmp; }
            }
            public void Sort_3(int x, int y, int z, out int max)	
            {
                int tmp;                
                if (x > y) { tmp = x; x = y; y = tmp; }
                if (x > z) { tmp = x; x = z; z = tmp; }
                if (y > z) { tmp = y; y = z; z = tmp; }
                max = z; 				
            }
            public void Sort_4(out int max, params int[] a) 		             
            {
                max = a[0];
                for (int i = 1; i < a.Length; i++)
                { if (a[i] > max) max = a[i]; }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 例题3_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();		
            button1.Width = trackBar1.Value;       
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
            button1.Height = trackBar2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonParameter BP = new ButtonParameter();   
            BP.Text = "按钮控件";   					
            button1.Text = BP.Text; 						
            button1.Height = BP.Height;					
            button1.Width = BP.Width;  					
            label1.Text = "默认高度为：";
            label2.Text = "默认宽度为：";
            textBox1.Text = BP.Height.ToString();			
            textBox2.Text = BP.Width.ToString();			
        }
    }

    class ButtonParameter       						
    {
        private string _text;   							
        private int _height;    							
        private int _width;     							
        public ButtonParameter()						
        {
            _height = 23;
            _width = 75;
        }
        public string Text								
        {
            get									
            { return _text; }
            set									
            { _text = value; }
        }
        public int Height   							
        {
            get
            { return _height; }
        }
        public int Width    							
        {
            get
            { return _width; }
        }
    }
}

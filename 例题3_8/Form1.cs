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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "圆")			
            {
                Form2 form2 = new Form2();	
                form2.Show();				
            }
            else if (e.Node.Text == "矩形")
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            else if (e.Node.Text == "正方形")
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
        }
    }

    public class Shape	            		
    { }

    public class Circle : Shape				
    {
        private double Radius;
        public Circle(double Radius)
        { this.Radius = Radius; }
        public double GetArea()
        { return Math.PI * Radius * Radius; }
    }

    public class Rectangular : Shape 			
    {
        protected double Length, Width;
        public Rectangular()
        { Length = Width = 0; }
        public Rectangular(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public double GetArea()      		
        { return Length * Width; }
    }

    public class Square : Rectangular       	
    {
        public Square(double Length)
            : base()	
        {
            this.Length = Length;
            this.Width = Length;
        }
    }
}

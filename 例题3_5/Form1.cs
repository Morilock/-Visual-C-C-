using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 例题3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int st;									
            int InNumItems = Convert.ToInt32(textBox1.Text.Trim());	
            int Incost = Convert.ToInt32(textBox2.Text.Trim());		
            int Insale = Convert.ToInt32(textBox3.Text.Trim());	 	
            cashRegister C = new cashRegister(InNumItems, Incost);  	
            C.makeSale(Insale, out st);					
            label6.Text = cashRegister.productCost().ToString(); 
            label7.Text = st.ToString();				 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = label6.Text = label7.Text = "";
        }

        class cashRegister
        {
            int numItems;           				
            double cost;　          				
            static double cashSum;   				
            public cashRegister(int numItems, double cost)	
            {
                this.numItems = numItems;
                this.cost = cost;
            }
            static cashRegister()					
            {
                cashSum = 0.0;
            }
            public void makeSale(int num, out int stock)  	
            {
                this.numItems -= num;
                cashSum += cost * num;      		
                stock = numItems;
            }
            public static double productCost()  		
            {
                return cashSum;
            }
        }
    }
}

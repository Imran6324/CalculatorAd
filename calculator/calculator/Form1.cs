using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculator : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_presssed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
 
        private void button_Click(object sender, EventArgs e)
        {  
            if ((result.Text == "0") || (operation_presssed))
                result.Clear(); 

            operation_presssed = false; 
            Button b = (Button)sender;
            
            if(b.Text == ".") 
            {
                if(!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
        } 

        private void button13_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                button16.PerformClick();
                operation = b.Text;
                operation_presssed = true;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_presssed = true;
                equation.Text = value + " " + operation;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            equation.Text = " ";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = Double.Parse(result.Text);
            equation.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        String operation = "";
        Double numberOne;
        Double numberTwo;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";
            
            if(b.Text==".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            String s, f;
            s = Convert.ToString(numberOne);
            f = Convert.ToString(numberTwo);

            s = "";
            f = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void Operational_Function(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            numberOne = Double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            numberTwo = Double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(numberOne + numberTwo);
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(numberOne - numberTwo);
                    break;
                case "*":
                    txtDisplay.Text = Convert.ToString(numberOne * numberTwo);
                    break;
                case "/":
                    txtDisplay.Text = Convert.ToString(numberOne / numberTwo);
                    break;
                default:
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.CalcServ;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double a,b,res;
    private  int operatr ;
        public Form1()
        {
            InitializeComponent();
        }

        private void inDisplay(string s)
        {
            lblDisplay.Text = lblDisplay.Text + s;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            inDisplay(((Button)sender).Text);

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = string.Empty;
        }

        private void btnoperator_Click(object sender, EventArgs e)
        {
             a=double.Parse(lblDisplay.Text);
            lblDisplay.Text = string.Empty;
            operatr = int.Parse(((Button)sender).Tag.ToString());
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            b = double.Parse(lblDisplay.Text);
            switch (operatr)
            {
                case 0:
                    res = new CalcServ.calcPortTypeClient().add(a, b);
                    break;
                case 1:
                    res = new CalcServ.calcPortTypeClient().sub(a, b);
                    break;
                case 2:
                    res = new CalcServ.calcPortTypeClient().mul(a, b);
                    break;
                case 3:
                    res = new CalcServ.calcPortTypeClient().div(a, b);
                    break;
                case 4:
                    res = new CalcServ.calcPortTypeClient().pow(a, b);
                    break;
                default:
                    break;
                    
            }
           
            lblDisplay.Text = string.Empty;
            lblDisplay.Text = res.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        float num1, num2;
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1 = (float)Convert.ToInt32(txtNum1.Text);
            float num2 = (float)Convert.ToInt32(txtNum2.Text);
            if(cbOperator.Text == "+")
            {
                float Total = BasicComputation.Addition(num1 , num2);
                string totals = Total.ToString();
                lblComputation.Text = totals;
            }
            else if (cbOperator.Text == "-")
            {
                float Total = BasicComputation.Subtraction(num1 , num2);
                string totals = Total.ToString();
                lblComputation.Text = totals;
            }
            else if ( cbOperator.Text == "*")
            {
                float Total = BasicComputation.Multiplication(num1 , num2);
                string totals = Total.ToString();
                lblComputation.Text = totals;
            }
            else if ( cbOperator.Text == "/")
            {
                float Total = BasicComputation.Division(num1 , num2);
                string totals = Total.ToString();
                lblComputation.Text = totals;
            }
           

        }
    }
}

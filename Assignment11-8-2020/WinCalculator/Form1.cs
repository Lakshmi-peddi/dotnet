using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLib;

namespace WinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArthematicOperations obj;
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            obj = new ArthematicOperations();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = obj.Add().ToString();
            txtNum1.Text = "";
            txtNum2.Text= "";
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            obj = new ArthematicOperations();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = obj.Subtract().ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            obj = new ArthematicOperations();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = obj.Divide().ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            obj = new ArthematicOperations();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = obj.Multiply().ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";
        }
    }
}

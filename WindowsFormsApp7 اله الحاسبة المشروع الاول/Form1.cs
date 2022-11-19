using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7_اله_الحاسبة_المشروع_الاول
{
    public partial class Calculator : Form
    {
        double resultvalue = 0;
        string operationperformed = "";
        bool isoperationperformed = false;

        public Calculator()
        {
            InitializeComponent();
        }
       
        private void button_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0" || (isoperationperformed))
                txt.Clear();

            isoperationperformed = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txt.Text.Contains("."))
                    txt.Text += button.Text;
            }
            else
            {
                txt.Text += button.Text;
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operationperformed = button.Text;
            resultvalue = double.Parse(txt.Text);
            isoperationperformed = true;
        }

        private void btncc_Click(object sender, EventArgs e)
        {
            txt.Text = "0";
        }

        private void btnyy_Click(object sender, EventArgs e)
        {
            if (operationperformed == "+")
            {
                txt.Text = (resultvalue + double.Parse(txt.Text)).ToString();
            }
            else if (operationperformed == "-")
            {
                txt.Text = (resultvalue - double.Parse(txt.Text)).ToString();
            }
            else if (operationperformed == "*")
            {
                txt.Text = (resultvalue * double.Parse(txt.Text)).ToString();
            }
            else
            {
                txt.Text = (resultvalue / double.Parse(txt.Text)).ToString();
            }
        }

        private void btndeleet_Click(object sender, EventArgs e)
        {
            if (txt.Text.Length > 0)
                txt.Text = txt.Text.Remove(txt.Text.Length - 1, 1);
            if (txt.Text == "")
                txt.Text = "0";
        }
    }
}



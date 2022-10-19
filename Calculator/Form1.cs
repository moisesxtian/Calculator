using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input;
        string operators;
        string allinputs;
        string sset;
        int compute;
        double answer;
        public Form1()
        {
            InitializeComponent();
        }

        private double calculate(double fnum, double snum)
        {
            if (operators == "÷")
            {
                answer = fnum / snum;
                return answer; ;
            }
            else if (operators == "*")
            {
                answer = fnum * snum;
                return answer;
            }
            else if (operators == "+") { 
                answer=fnum+snum;
                return answer;
            }
            else if (operators == "%")
            {
                answer = fnum % snum;
                return answer;
            }
            else if (operators == "-")
            {
                answer = fnum - snum;
                return answer;
            }
            else
            {
                return 0.00;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                showinput.Text = "0";
            }
            else
            {
                if (input.Length >= 2)
                {
                    input = input.Substring(0, input.Length - 1);
                    showinput.Text = input;
                }
                else if (input.Length==1) {
                    input = null;
                    showinput.Text = "0";
                }

                else
                {
                    showinput.Text = "0";
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            input = input + ".";
            showinput.Text = input;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            input = input + "9";
            showinput.Text = input;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            input = input + "8";
            showinput.Text = input;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            input = input + "7";
            showinput.Text = input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            input = input + "6";
            showinput.Text = input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            input = input + "5";
            showinput.Text = input;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            input = input + "4";
            showinput.Text = input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            input = input + "3";
            showinput.Text = input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            input = input + "2";
            showinput.Text = input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input = input + "1";
            showinput.Text = input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input = input + "0";
            showinput.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                double ssetstr = Convert.ToDouble(sset);
                double inputstr = Convert.ToDouble(input);
                double comp = ssetstr / inputstr;

                showinput.Text = calculate(ssetstr, inputstr).ToString();
                input = showinput.Text;
            }
            catch (FormatException io) {
                input = null;
                showinput.Text = "0";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sset = input;
            allinput.Text = sset;

            operators = "+";
            allinput.Text = input + " "+operators;
            input = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sset = input;
            allinput.Text = sset;

            operators = "*";
            allinput.Text = input + " " + operators;
            input = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sset = input;
            allinput.Text = sset;
            
            operators = "÷";
            allinput.Text = input + " " + operators;
            input = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sset = input;
            allinput.Text = sset;

            operators = "%";
            allinput.Text = input + " " + operators;
            input = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input = null;
            showinput.Text="0";
            allinputs = null;
            allinput.Text=null; 
        }

        private void button24_Click(object sender, EventArgs e)
        {
            input = input + "00";
            showinput.Text = input;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sset = input;
            allinput.Text = sset;

            operators = "-";
            allinput.Text = input + " " + operators;
            input = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

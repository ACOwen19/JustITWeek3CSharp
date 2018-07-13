using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formCalculator
{
    
    

    public partial class calcForm : Form
    {
        public calcForm()
        {
            InitializeComponent();
        }

        public static int numberCount = 0;
        public double numeral;
        public List<char> operators = new List<char>();
        public List<double> numbers = new List<double>();
        public string calculation = "";

        public void CalcNumber(string calculation, List<double> numbers)
        {
            numeral = Convert.ToDouble(calculation);
            numbers.Add(numeral);
            numberCount += 1;
        }
                        
        private void button1_Click(object sender, EventArgs e)
        {
            entryScreen.Text += "1";
            calculation += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            entryScreen.Text += "2";
            calculation += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entryScreen.Text += "3";
            calculation += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            entryScreen.Text += "4";
            calculation += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            entryScreen.Text += "5";
            calculation += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            entryScreen.Text += "6";
            calculation += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            entryScreen.Text += "7";
            calculation += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            entryScreen.Text += "8";
            calculation += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            entryScreen.Text += "9";
            calculation += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            entryScreen.Text += "0";
            calculation += "0";
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            entryScreen.Text += " + ";
            CalcNumber(calculation, numbers);
            operators.Add('+');
            calculation = "";
        }
                
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            entryScreen.Text += " - ";
            CalcNumber(calculation, numbers);
            operators.Add('-');
            calculation = "";
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            entryScreen.Text += " * ";
            CalcNumber(calculation, numbers);
            operators.Add('*');
            calculation = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            entryScreen.Text += " / ";
            CalcNumber(calculation, numbers);
            operators.Add('/');
            calculation = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            int calLeng = calculation.Length;
            string entryText = entryScreen.Text;
            int entLeng = entryText.Length;
            calculation = calculation.Remove(calLeng-1);
            entryScreen.Text = entryText.Remove(entLeng-1);
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            entryScreen.Text += ".";
            calculation += ".";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            calculation = "";
            entryScreen.Text = "";
            resultsScreen.Text = "";
            operators.Clear();
            numbers.Clear();
            numberCount = 0;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            CalcNumber(calculation, numbers);
            numeral = numbers[0];
            for (int i = 0; i < (numberCount - 1); i += 1)
            {
                switch (operators[i])
                {
                    case '+':
                        numeral += numbers[i + 1];
                        break;
                    case '-':
                        numeral -= numbers[i + 1];
                        break;
                    case '*':
                        numeral *= numbers[i + 1];
                        break;
                    case '/':
                        numeral /= numbers[i + 1];
                        break;
                }
            }
            resultsScreen.Text = Convert.ToString(numeral);
        }
    }
   
}

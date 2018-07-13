using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creditCardCheckerWLuhn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private long accountOne = 1234567891;
        // This has a check digit of 4
        public string balance = "£300";
        public long LuhnConvertor(string input)
        {
            long fullNumber = Convert.ToInt64(input);
            long[] seperateNumbers = input.ToCharArray().Select(Convert.ToInt64).ToArray();
            long[] doubledNumbers = new long[10];
            long[] sumNumbers = new long[10];
            long checkSum = 0;
            long checkNum = 0;

            for (long i = 0; i<seperateNumbers.Length; i += 1)
            {
                if ((i+2)%2 != 0)
                {
                    doubledNumbers[i] = seperateNumbers[i] * 2;
                    if (doubledNumbers[i] > 10)
                    {
                        long summer = doubledNumbers[i];
                        sumNumbers[i] = summer - 9;
                    }
                    else
                    {
                        sumNumbers[i] = doubledNumbers[i];
                    }
                }
                else
                {
                    doubledNumbers[i] = seperateNumbers[i];
                    sumNumbers[i] = doubledNumbers[i];
                }

            }  

            for (int i = 0; i<sumNumbers.Length; i += 1)
            {
                checkSum += sumNumbers[i];
            }

            checkNum = (checkSum * 9) % 10;

            long output = checkSum + checkNum;
            return output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = cardEntry.Text;
        }
    }
}

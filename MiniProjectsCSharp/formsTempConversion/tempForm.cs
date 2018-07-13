using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsTempConversion
{
    public partial class tempForm : Form
    {
        public tempForm()
        {
            InitializeComponent();
        }

        public double CentFahConv(double tempInput)
        {
            double output = (tempInput * 1.8) + 32;
            return output;
        }

        public double FahCentConv(double tempInput)
        {
            double output = (tempInput - 32) / 1.8;
            return output;
        }


        private void converter_Click(object sender, EventArgs e)
        {

            double tempOutput = 0;
            double tempInput = Convert.ToDouble(tempEntry.Text);
            if (originalScale.Text == "Centigrade")
            {
                switch (convertedScale.Text)
                {
                    case "Fahrenheit":
                        {
                            tempOutput = CentFahConv(tempInput);
                            convertedTemp.Text = tempOutput.ToString() + "\u2109";
                            break;
                        }
                    case "Kelvin":
                        {
                            tempOutput = tempInput - 273.15;
                            convertedTemp.Text = tempOutput.ToString() + "K";
                            break;
                        }

                    default:
                        {
                            convertedTemp.Text = tempInput.ToString() + "\u2103";
                            break;
                        }
                }
            }
            else if (originalScale.Text == "Fahrenheit")
            {
                switch (convertedScale.Text)
                {
                    case "Centigrade":
                        {
                            tempOutput = FahCentConv(tempInput);
                            convertedTemp.Text = tempOutput.ToString() + "\u2103";
                            break;
                        }
                    case "Kelvin":
                        {
                            tempOutput = FahCentConv(tempInput) - 273.15;
                            convertedTemp.Text = tempOutput.ToString() + "K";
                            break;
                        }

                    default:
                        {
                            convertedTemp.Text = tempInput.ToString() + "\u2109";
                            break;
                        }

                }
            }
            else if (originalScale.Text == "Kelvin")
            {
                switch (convertedScale.Text)
                {
                    case "Centigrade":
                        {
                            tempOutput = tempInput + 273.15;
                            convertedTemp.Text = tempOutput.ToString() + "\u2103";
                            break;
                        }
                    case "Fahrenheit":
                        {
                            tempOutput = CentFahConv(tempInput + 273.15);
                            convertedTemp.Text = tempOutput.ToString() + "\u2109";
                            break;
                        }

                    default:
                        {
                            convertedTemp.Text = tempInput.ToString() + "K";
                            break;
                        }

                }
            }
            else
            {
                convertedTemp.Text = "Please select both scales and enter a temperature";
            }
        }
    }
}

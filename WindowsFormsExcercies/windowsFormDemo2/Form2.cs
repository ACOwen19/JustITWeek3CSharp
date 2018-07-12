using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormDemo2
{
    public partial class Form2 : Form
    {
        int timeLeft = 20;
        bool q1Correct = false;
        bool q2Correct = false;
        bool q3Correct = false;

        public Form2()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox6.Visible = false;
        }

        private void Q1R1_CheckedChanged(object sender, EventArgs e)
        {
            if (Q1R1.Checked)
            {
                Q1Feedback.ForeColor = Color.Red;
                Q1Feedback.Text = "\u00fb"; // Unicode for cross, note you use the \u in c#
                // NB NEED TO SET FONT TO WINGDINGS TO DISPLAY CORRECTLY
                q1Correct = false;
            }
            else
            {
                Q1Feedback.Text = "";
            }
        }

        private void Q1R2_CheckedChanged(object sender, EventArgs e)
        {
            if (Q1R2.Checked)
            {
                Q1Feedback.ForeColor = Color.Green;
                Q1Feedback.Text = "\u00fc"; // Unicode for tick
                q1Correct = true;
            }
            else
            {
                Q1Feedback.Text = "";
            }
        }
        private void Q1R3_CheckedChanged(object sender, EventArgs e)
        {
            if (Q1R3.Checked)
            {
                Q1Feedback.ForeColor = Color.Red;
                Q1Feedback.Text = "\u00fb";
                q1Correct = false;
            }
            else
            {
                Q1Feedback.Text = "";
            }
        }
        private void Q2R1_CheckedChanged(object sender, EventArgs e)
        {
            if (Q2R1.Checked)
            {
                Q2Feedback.ForeColor = Color.Green;
                Q2Feedback.Text = "\u00fc";
                q2Correct = true;
            }
            else
            {
                Q2Feedback.Text = "";
            }
        }
        private void Q2R2_CheckedChanged(object sender, EventArgs e)
        {
            if (Q2R2.Checked)
            {
                Q2Feedback.ForeColor = Color.Red;
                Q2Feedback.Text = "\u00fb";
                q2Correct = false;
            }
            else
            {
                Q2Feedback.Text = "";
            }
        }
        private void Q2R3_CheckedChanged(object sender, EventArgs e)
        {
            if (Q2R3.Checked)
            {
                Q2Feedback.ForeColor = Color.Red;
                Q2Feedback.Text = "\u00fb";
                q2Correct = false;

            }
            else
            {
                Q2Feedback.Text = "";
            }
        }
        private void Q3R1_CheckedChanged(object sender, EventArgs e)
        {
            if (Q3R1.Checked)
            {
                Q3Feedback.ForeColor = Color.Red;
                Q3Feedback.Text = "\u00fb";
                q3Correct = false;

            }
            else
            {
                Q3Feedback.Text = "";
            }
        }
        private void Q3R2_CheckedChanged(object sender, EventArgs e)
        {
            if (Q3R2.Checked)
            {
                Q3Feedback.ForeColor = Color.Red;
                Q3Feedback.Text = "\u00fb";
                q3Correct = false;
            }
            else
            {
                Q3Feedback.Text = "";
            }
        }
        private void Q3R3_CheckedChanged(object sender, EventArgs e)
        {
            if (Q3R3.Checked)
            {
                Q3Feedback.ForeColor = Color.Green;
                Q3Feedback.Text = "\u00fc";
                q3Correct = true;
            }
            else
            {
                Q3Feedback.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //NB To get timer to go in seconds you need to change the interval property from 100 to 1000 (miliseconds)
            if (q1Correct && q2Correct && q3Correct)
            {
                timer1.Stop();
                MessageBox.Show("Congratulations", "You got them all :)");
            }

            else if (timeLeft > 0) {
                timeLeft--;
                timeLabel.Text = timeLeft + "seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's Up!";
                MessageBox.Show("Sorry", "You ran out of time :(");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            groupBox1.Visible = true;
            groupBox3.Visible = true;
            groupBox6.Visible = true;
            startButton.Enabled = false;
            timer1.Start();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

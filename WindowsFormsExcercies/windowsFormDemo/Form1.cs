using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void getMessage_Click(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            //name = the contents of the textbox called NameEntry in the form
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - birthdayDateSelector.Value;
            // declare todays date and using the date selected in the form
            // subtracct from todays date, the remainder will be the timespan the person has been alive at the given date
            int years = ((int)ageDays.TotalDays) / 365;
            // calculate the number of years the person has been alive by getting the number of days in the
            // Timespan ageDays as an interger and dividing by 365
            int day = birthdayDateSelector.Value.Day;
            // gets the day of the month of the person's birthday
            string month = birthdayDateSelector.Value.ToString("MMMM");
            // extracting the month as a string, works this way because thats how its formatted

            displayMessage.Text = "Hello, " + name + "! You will be " + (years + 1) + " years old on " + day + " " + month + ".";
            // Changing the Text property of the displayMessage label to the following concatonated string. 
            // Telling user what their age will be at their next birthday
      }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormsDemo4
{
    public partial class Form5 : Form
    {
        Random rnd = new Random();
        public Form5()
        {
            InitializeComponent();
        }

        private void numGen_Click(object sender, EventArgs e)
        {
            foreach (Control displayLabels in Controls)
                // controls are objects within the form, these paramaters will select all of them
            {
                Label numberLabel = displayLabels as Label;
                // This will pull out only the labels
                if(numberLabel !=null)
                {
                    // by delaring rnd as a global variable it will be a new number each time it is called
                    int randomNumber = rnd.Next(1, 69);
                    numberLabel.Text = randomNumber.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormDemo3
{
    public partial class Demo3 : Form
    {
        public Demo3()
        {
            InitializeComponent();

        }

        private void textButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "*.txt";
            openFileDialog1.Filter = "Text files (*.txt)| *.txt |All Files (*.*)|*.*";
            // Why doesn't this display text files when selected?
            openFileDialog1.InitialDirectory = "c:\\Users\\student\\Desktop\\JITACO\\justITWeek3CSharp\\WindowsFormsExcercies\\testText.txt";
            if ((openFileDialog1.ShowDialog() == DialogResult.OK) && (openFileDialog1.FileName.Length > 0))
            {
                displayBox.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            PopupForm popUp = new PopupForm();
            popUp.Show();
            Hide();

            FormState.hiddenForm = this;
        }

        private void bgButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        public static class FormState
        {
            public static Form hiddenForm;
        }
    }
}

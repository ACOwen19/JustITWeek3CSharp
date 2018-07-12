using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static windowsFormDemo3.Demo3;

namespace windowsFormDemo3
{
    public partial class PopupForm : Form
    {
        public PopupForm()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FormState.hiddenForm.Show();
            FormState.hiddenForm = this;

            Close();
        }
    }
}

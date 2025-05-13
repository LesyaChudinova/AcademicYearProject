using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicYearProject
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void GreetingTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}

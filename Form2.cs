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

        public Form2(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.Pink;
        }

        private void GreetingTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void help_button_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Help.ShowHelpIndex(this, "Help.chm");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            HelpNavigator navigator = HelpNavigator.Find;
            Help.ShowHelp(this, "Help.chm", navigator, "Аннотация");
        }
    }
}

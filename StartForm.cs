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
    public partial class StartScreen: Form
    {
        public StartScreen(AppForm2 appForm2)
        {
            InitializeComponent();

        }

        public StartScreen()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void GreetingTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SkipInstruction_Click(object sender, EventArgs e)
        {
            AppForm1 form1 = new AppForm1(this);
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelpIndex(this, "Help.chm");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Find;
            Help.ShowHelp(this, "Help.chm", navigator, "Аннотация");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppForm1 form1 = new AppForm1(this);
            form1.Show();
        }
    }
}

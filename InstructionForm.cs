using System;
using System.Windows.Forms;

namespace AcademicYearProject
{
    public partial class InstructionForm : Form
    {
        private AppForm1 appForm1;

        public InstructionForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InstructionForm_Load(object sender, EventArgs e)
        {

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (appForm1 == null)
                appForm1 = new AppForm1();
            appForm1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Find;
            Help.ShowHelp(this, "Help.chm", navigator, "Аннотация");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelpIndex(this, "Help.chm");
        }
    }
}

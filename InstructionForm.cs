using System;
using System.Windows.Forms;

namespace AcademicYearProject
{
    public partial class AInstructionForm : Form
    {
        private AppForm1 appForm1;

        public AInstructionForm()
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
    }
}

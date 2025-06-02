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
    public partial class AppForm1 : Form
    {
        
        private AppForm2 appForm2;
        private InstructionForm instructionForm;        

        public AppForm1()
        {
            InitializeComponent();
        }                 

        private void Women_Click(object sender, EventArgs e)
        {

        }

        private void Men_Click(object sender, EventArgs e)
        {

        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (appForm2 == null)
                appForm2 = new AppForm2();
            appForm2.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (instructionForm == null)
                instructionForm = new InstructionForm();
            instructionForm.Show();
            this.Close();
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            if (instructionForm == null)
                instructionForm = new InstructionForm();
            instructionForm.Show();
            this.Close();
        }

        private void AppForm1_Load(object sender, EventArgs e)
        {

        }

        private void GreetingTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

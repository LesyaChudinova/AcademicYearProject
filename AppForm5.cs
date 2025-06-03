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
    public partial class AppForm5 : Form
    {
        private AppForm4 appForm4;
        private AppForm6 appForm6;
        private InstructionForm instructionForm;
        public AppForm5()
        {
            InitializeComponent();
        }

        private void AppForm5_Load(object sender, EventArgs e)
        {

        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (appForm6 == null)
                appForm6 = new AppForm6();
            appForm6.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (appForm4 == null)
                appForm4 = new AppForm4();
            appForm4.Show();
            this.Close();
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            if (instructionForm == null)
                instructionForm = new InstructionForm();
            instructionForm.Show();
            this.Close();
        }
    }
}

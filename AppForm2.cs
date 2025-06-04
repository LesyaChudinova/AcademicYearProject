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
    public partial class AppForm2 : Form
    {
        private AppState appState;
        private Button selectedAgeButton = null;
        private AppForm3 appForm3;
        private AppForm1 appForm1;
        private InstructionForm instructionForm;

        public AppForm2(AppState state)
        {
            InitializeComponent();
            appState = state;
        }              

        private void AppForm2_Load(object sender, EventArgs e)
        {

        }

        private void TeenagersButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (selectedAgeButton != null)
            {
                selectedAgeButton.BackColor = SystemColors.Control;
                selectedAgeButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedAgeButton = button;

            appState.AgeGroup = "п";
        }

        private void YoungstearsButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (selectedAgeButton != null)
            {
                selectedAgeButton.BackColor = SystemColors.Control;
                selectedAgeButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedAgeButton = button;

            appState.AgeGroup = "м";
        }

        private void AdultsButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (selectedAgeButton != null)
            {
                selectedAgeButton.BackColor = SystemColors.Control;
                selectedAgeButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedAgeButton = button;

            appState.AgeGroup = "в";
        }

        private void OlderButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (selectedAgeButton != null)
            {
                selectedAgeButton.BackColor = SystemColors.Control;
                selectedAgeButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedAgeButton = button;

            appState.AgeGroup = "з";
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (appForm3 == null)
                appForm3 = new AppForm3(appState);
            appForm3.Show();
            this.Close();            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (appForm1 == null)
                appForm1 = new AppForm1(appState);
            appForm1.Show();
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

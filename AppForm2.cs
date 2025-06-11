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

        private void SelectButton(Button button, ref Button selectedButton, string result)
        {
            if (selectedButton != null)
            {
                selectedButton.FlatAppearance.BorderSize = 0;
            }

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.Red;
            button.FlatAppearance.BorderSize = 3;

            selectedButton = button;
            appState.AgeGroup = result;
        }

        private void AppForm2_Load(object sender, EventArgs e)
        {

        }

        private void TeenagersButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedAgeButton, "п");
        }

        private void YoungstearsButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedAgeButton, "ю");
        }

        private void AdultsButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedAgeButton, "в");
        }

        private void OlderButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedAgeButton, "з");
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

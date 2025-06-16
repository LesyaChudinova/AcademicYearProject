using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace AcademicYearProject
{
    public partial class AppForm1 : Form
    {
        private AppState appState;
        private AppForm2 appForm2;
        private InstructionForm instructionForm;
        private Button selectedGenderButton = null;
       
        public AppForm1(AppState state = null)
        {
            InitializeComponent();
            appState = state ?? new AppState();
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
            appState.Gender = result;
        }

        private void Women_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedGenderButton, "ж");
        }
        

        private void Men_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedGenderButton, "м");
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(appState.Gender))
            {
                MessageBox.Show("Пожалуйста, выберите пол");
                return;
            }

            if (appForm2 == null)
                appForm2 = new AppForm2(appState);
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

        private void help_button_Click(object sender, EventArgs e)
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

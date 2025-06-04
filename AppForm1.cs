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

        private void Women_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            // Сбрасываем предыдущий выбор
            if (selectedGenderButton != null)
            {
                selectedGenderButton.BackColor = SystemColors.Control;
                selectedGenderButton.ForeColor = SystemColors.ControlText;
            }

            // Устанавливаем новый выбор
            button.BackColor = Color.LightBlue;
            selectedGenderButton = button;

            appState.Gender = button.Text;
        }
        

        private void Men_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            // Сбрасываем предыдущий выбор
            if (selectedGenderButton != null)
            {
                selectedGenderButton.BackColor = SystemColors.Control;
                selectedGenderButton.ForeColor = SystemColors.ControlText;
            }

            // Устанавливаем новый выбор
            button.BackColor = Color.LightBlue;
            selectedGenderButton = button;

            appState.Gender = button.Text;

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
    }
}

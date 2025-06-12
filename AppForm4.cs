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
    public partial class AppForm4 : Form
    {
        private AppState appState;
        private Button selectedWeatherButton = null;
        private AppForm3 appForm3;
        private AppForm5 appForm5;
        private InstructionForm instructionForm;
        public AppForm4(AppState state)
        {
            InitializeComponent();
            appState = state;
        }

        private void AppForm4_Load(object sender, EventArgs e)
        {

        }        

        private void ForwardButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(appState.Weather))
            {
                MessageBox.Show("Пожалуйста, выберите погоду");
                return;
            }

            if (appForm5 == null)
                appForm5 = new AppForm5(appState);
            appForm5.Show();
            this.Close();            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (appForm3 == null)
                appForm3 = new AppForm3(appState);
            appForm3.Show();
            this.Close();            
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            if (instructionForm == null)
                instructionForm = new InstructionForm();
            instructionForm.Show();
            this.Close();
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
            appState.Weather = result;
        }

        private void SunnyButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedWeatherButton, "солнечно");
        }

        private void SnowButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedWeatherButton, "снег");
        }

        private void RainButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedWeatherButton, "дождь");
        }

        private void WindyButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedWeatherButton, "ветренно");
        }
    }
}

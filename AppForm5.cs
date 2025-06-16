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
        private AppState appState;
        private Button selectedMoodButton = null;
        private AppForm4 appForm4;
        private AppForm6 appForm6;
        private InstructionForm instructionForm;
        public AppForm5(AppState state)
        {
            InitializeComponent();
            appState = state;
        }

        private void AppForm5_Load(object sender, EventArgs e)
        {

        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(appState.Mood))
            {
                MessageBox.Show("Пожалуйста, выберите ваше настроение");
                return;
            }

            if (appForm6 == null)
                appForm6 = new AppForm6(appState);
            appForm6.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (appForm4 == null)
                appForm4 = new AppForm4(appState);
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
            appState.Mood = result;
        }

        private void ActiveButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedMoodButton, "активное");
        }

        private void RelaxedButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedMoodButton, "расслабленное");
        }

        private void ShackledButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedMoodButton, "закрыться от всех");
        }

        private void CalmButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedMoodButton, "обычное");
        }

        private void BrightButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedMoodButton, "яркое");
        }

        private void RomanticButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedMoodButton, "романтичное");
        }

        private void CozyButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedMoodButton, "уютное");
        }

        private void StrictButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedMoodButton, "строгое");
        }

        private void EleganceButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedMoodButton, "элегантное");
        }

        private void DaringButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedMoodButton, "дерзкое");
        }

        private void LuxuriousButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedMoodButton, "роскошное");
        }

        private void RestrainedButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedMoodButton, "сдержанное");
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Find;
            Help.ShowHelp(this, "Help.chm", navigator, "Аннотация");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Help.ShowHelpIndex(this, "Help.chm");
        }
    }
}

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

        private void ActiveButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedMoodButton != null)
            {
                selectedMoodButton.BackColor = SystemColors.Control;
                selectedMoodButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedMoodButton = button;

            appState.Mood = "активное";
        }

        private void RelaxedButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedMoodButton != null)
            {
                selectedMoodButton.BackColor = SystemColors.Control;
                selectedMoodButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedMoodButton = button;

            appState.Mood = "расслабленное";
        }

        private void ShackledButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedMoodButton != null)
            {
                selectedMoodButton.BackColor = SystemColors.Control;
                selectedMoodButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedMoodButton = button;

            appState.Mood = "закрыться от всех";
        }

        private void CalmButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedMoodButton != null)
            {
                selectedMoodButton.BackColor = SystemColors.Control;
                selectedMoodButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedMoodButton = button;

            appState.Mood = "обычное";
        }

        private void BrightButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedMoodButton != null)
            {
                selectedMoodButton.BackColor = SystemColors.Control;
                selectedMoodButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedMoodButton = button;

            appState.Mood = "яркое";
        }

        private void RomanticButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedMoodButton != null)
            {
                selectedMoodButton.BackColor = SystemColors.Control;
                selectedMoodButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedMoodButton = button;

            appState.Mood = "романтичное";
        }

        private void CozyButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedMoodButton != null)
            {
                selectedMoodButton.BackColor = SystemColors.Control;
                selectedMoodButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedMoodButton = button;

            appState.Mood = "уютное";
        }

        private void StrictButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedMoodButton != null)
            {
                selectedMoodButton.BackColor = SystemColors.Control;
                selectedMoodButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedMoodButton = button;

            appState.Mood = "строгое";
        }

        private void EleganceButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedMoodButton != null)
            {
                selectedMoodButton.BackColor = SystemColors.Control;
                selectedMoodButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedMoodButton = button;

            appState.Mood = "элегантное";
        }

        private void DaringButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedMoodButton != null)
            {
                selectedMoodButton.BackColor = SystemColors.Control;
                selectedMoodButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedMoodButton = button;

            appState.Mood = "дерзкое";
        }

        private void LuxuriousButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedMoodButton != null)
            {
                selectedMoodButton.BackColor = SystemColors.Control;
                selectedMoodButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedMoodButton = button;

            appState.Mood = "роскошное";
        }

        private void RestrainedButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedMoodButton != null)
            {
                selectedMoodButton.BackColor = SystemColors.Control;
                selectedMoodButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedMoodButton = button;

            appState.Mood = "сдержанное";
        }
    }
}

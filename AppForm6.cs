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
    public partial class AppForm6 : Form
    {
        private AppState appState;
        private Button selectedOccasionButton = null;
        private AppForm5 appForm5;
        private AppForm7 appForm7;
        private InstructionForm instructionForm;

        public AppForm6(AppState state)
        {
            InitializeComponent();
            appState = state;
        }

        private void AppForm6_Load(object sender, EventArgs e)
        {

        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (appForm7 == null)
                appForm7 = new AppForm7(appState);
            appForm7.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (appForm5 == null)
                appForm5 = new AppForm5(appState);
            appForm5.Show();
            this.Close();
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            if (instructionForm == null)
                instructionForm = new InstructionForm();
            instructionForm.Show();
            this.Close();
        }

        private void ClassicButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedOccasionButton != null)
            {
                selectedOccasionButton.BackColor = SystemColors.Control;
                selectedOccasionButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedOccasionButton = button;

            appState.Occasion = "классический";
        }

        private void SportsButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedOccasionButton != null)
            {
                selectedOccasionButton.BackColor = SystemColors.Control;
                selectedOccasionButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedOccasionButton = button;

            appState.Occasion = "спортивный";
        }

        private void UsualDayButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedOccasionButton != null)
            {
                selectedOccasionButton.BackColor = SystemColors.Control;
                selectedOccasionButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedOccasionButton = button;

            appState.Occasion = "пвседневный";
        }
    }
}

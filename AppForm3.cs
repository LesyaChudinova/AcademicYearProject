using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicYearProject
{
    public partial class AppForm3: Form
    {
        private AppState appState;
        private Button selectedSeasonButton = null;
        private AppForm4 appForm4;
        private AppForm2 appForm2;
        private InstructionForm instructionForm;

        public AppForm3(AppState state)
        {
            InitializeComponent();
            appState = state;
        }                
                       

        private void help_button_Click_1(object sender, EventArgs e)
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
                

        private void AppForm4_Load(object sender, EventArgs e)
        {

        }

        private void SummerButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (selectedSeasonButton != null)
            {
                selectedSeasonButton.BackColor = SystemColors.Control;
                selectedSeasonButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedSeasonButton = button;

            appState.Season = "лето";
        }

        private void WinterButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (selectedSeasonButton != null)
            {
                selectedSeasonButton.BackColor = SystemColors.Control;
                selectedSeasonButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedSeasonButton = button;

            appState.Season = "зима";
        }

        private void SpringButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (selectedSeasonButton != null)
            {
                selectedSeasonButton.BackColor = SystemColors.Control;
                selectedSeasonButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedSeasonButton = button;

            appState.Season = "весна";
        }

        private void AutumnButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (selectedSeasonButton != null)
            {
                selectedSeasonButton.BackColor = SystemColors.Control;
                selectedSeasonButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedSeasonButton = button;

            appState.Season = "осень";
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (appForm4 == null)
                appForm4 = new AppForm4(appState);
            appForm4.Show();
            this.Close();            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (appForm2 == null)
                appForm2 = new AppForm2(appState);
            appForm2.Show();
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

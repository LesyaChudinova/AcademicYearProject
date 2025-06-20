﻿using System;
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
            if (string.IsNullOrEmpty(appState.Occasion))
            {
                MessageBox.Show("Пожалуйста, выберите, есть ли сегодня мероприятие");
                return;
            }

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
            appState.Occasion = result;
        }

        private void ClassicButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedOccasionButton, "классический");
        }

        private void SportsButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedOccasionButton, "спортивный");
        }

        private void UsualDayButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedOccasionButton, "повседневный");
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

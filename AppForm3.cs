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
    public partial class AppForm3: Form
    {
        public AppForm3(AppForm2 appForm2)
        {
            InitializeComponent();
        }

        public AppForm3(StartScreen f)
        {
            InitializeComponent();
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
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

        private void SnowButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RainButton_Click(object sender, EventArgs e)
        {

        }

        private void SunnyButton_Click(object sender, EventArgs e)
        {

        }

        private void WindyButton_Click(object sender, EventArgs e)
        {

        }
    }
}

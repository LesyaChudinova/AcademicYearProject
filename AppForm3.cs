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
        private AppForm4 appForm4;

        public AppForm3(AppForm2 appForm2)
        {
            InitializeComponent();
        }

        public AppForm3()
        {
            InitializeComponent();
        }        

        public AppForm3(AppForm4 appForm4)
        {
            this.appForm4 = appForm4;
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

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            AppForm4 form4 = new AppForm4();
            form4.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AppForm2 form2 = new AppForm2();
            form2.Show();
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            StartScreen form = new StartScreen();
            form.Show();
        }
    }
}

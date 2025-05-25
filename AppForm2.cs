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
    public partial class AppForm2 : Form
    {
        private AppForm3 appForm3;
        private AppForm1 appForm1;
        private StartScreen startForm;

        public AppForm2()
        {
            InitializeComponent();
        }              

        private void AppForm2_Load(object sender, EventArgs e)
        {

        }

        private void TeenagersButton_Click(object sender, EventArgs e)
        {
            
        }

        private void YoungstearsButton_Click(object sender, EventArgs e)
        {

        }

        private void AdultsButton_Click(object sender, EventArgs e)
        {

        }

        private void OlderButton_Click(object sender, EventArgs e)
        {

        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (appForm3 == null)
                appForm3 = new AppForm3();
            appForm3.Show();
            this.Close();            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (appForm1 == null)
                appForm1 = new AppForm1();
            appForm1.Show();
            this.Close();            
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            if (startForm == null)
                startForm = new StartScreen();
            startForm.Show();
            this.Close();
        }
    }
}

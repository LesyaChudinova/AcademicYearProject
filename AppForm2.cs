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

        public AppForm2()
        {
            InitializeComponent();
        }

        public AppForm2(AppForm1 appForm1)
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
            AppForm3 form3 = new AppForm3(this);
            form3.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AppForm1 form1 = new AppForm1();
            form1.Show();
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            StartScreen screen = new StartScreen(this);
            screen.Show();
        }
    }
}

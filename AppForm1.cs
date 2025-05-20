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
    public partial class AppForm1 : Form
    {
        private AppForm2 appForm2;

        public AppForm1(StartScreen startScreen)
        {
            InitializeComponent();
        }

        public AppForm1(AppForm2 appForm2)
        {
            this.appForm2 = appForm2;
        }
               

        private void AgainButton_Click(object sender, EventArgs e)
        {
            StartScreen form = new StartScreen();
            form.Show();
        }

        private void Women_Click(object sender, EventArgs e)
        {

        }

        private void Men_Click(object sender, EventArgs e)
        {

        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            AppForm2 form2 = new AppForm2();
            form2.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            StartScreen form = new StartScreen();
            form.Show();
        }

        private void AppForm1_Load(object sender, EventArgs e)
        {

        }
    }
}

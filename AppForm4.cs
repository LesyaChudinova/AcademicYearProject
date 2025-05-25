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
    public partial class AppForm4 : Form
    {
        public AppForm4()
        {
            InitializeComponent();
        }

        private void AppForm4_Load(object sender, EventArgs e)
        {

        }        

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            AppForm5 form5 = new AppForm5();
            form5.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AppForm3 form3 = new AppForm3();
            form3.Show();
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            StartScreen form = new StartScreen();
            form.Show();
        }
    }
}

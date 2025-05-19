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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(AppForm3 f)
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            
            System.Diagnostics.Process.Start("https://ru.pinterest.com/lecchuu/outfits/?request_params=%7B%221%22%3A%20130%2C%20%227%22%3A%208159570208037873931%2C%20%228%22%3A%20659707114106231973%2C%20%2230%22%3A%20%22outfits%22%2C%20%2232%22%3A%2045%2C%20%2233%22%3A%20%5B659707045451662235%5D%2C%20%2236%22%3A%20%5B659707114106231973%5D%2C%20%2237%22%3A%20%22outfits%22%2C%20%2234%22%3A%200%2C%20%22102%22%3A%204%7D&full_feed_title=outfits&view_parameter_type=3069&pins_display=3");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void help_button_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}

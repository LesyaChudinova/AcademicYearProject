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
    public partial class ResultForm : Form
    {
        private AppState appState;

        public ResultForm(AppState state)
        {
            InitializeComponent();
            appState = state;
            DisplayResults();
        }


        private void ResultForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayResults()
         {
             if (appState.RecommendedOutfits.Any())
             {
                 OutfitsListBox.DataSource = appState.RecommendedOutfits;
                 OutfitsListBox.DisplayMember = "Name";
             }
             else
             {
                 MessageBox.Show("Подходящих образов не найдено");
             }
         }

         private void OutfitsListBox_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (OutfitsListBox.SelectedItem is Outfit selected)
             {
                 DetailsTextBox.Text = selected.ToString();
             }
         }
    }
}

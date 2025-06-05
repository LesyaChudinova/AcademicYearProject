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
    public partial class AppForm7 : Form
    {
        private AppState appState;
        private OutfitTree outfitTree;
        private Button selectedStyleButton = null;
        private AppForm6 appForm6;
        private InstructionForm instructionForm;

        public AppForm7(AppState state)
        {
            InitializeComponent();
            appState = state;
            outfitTree = new OutfitTree();
            LoadData();
        }

        private void AppForm7_Load(object sender, EventArgs e)
        {

        }

    
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (appForm6 == null)
                appForm6 = new AppForm6(appState);
            appForm6.Show();
            this.Close();
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            if (instructionForm == null)
                instructionForm = new InstructionForm();
            instructionForm.Show();
            this.Close();
        }

        private void CasualButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedStyleButton != null)
            {
                selectedStyleButton.BackColor = SystemColors.Control;
                selectedStyleButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedStyleButton = button;

            appState.Style = "кэжуал";
        }

        private void GrangeButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedStyleButton != null)
            {
                selectedStyleButton.BackColor = SystemColors.Control;
                selectedStyleButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedStyleButton = button;

            appState.Style = "гранж";
        }

        private void RomanticButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedStyleButton != null)
            {
                selectedStyleButton.BackColor = SystemColors.Control;
                selectedStyleButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedStyleButton = button;

            appState.Style = "романтический";
        }

        private void BusinessButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedStyleButton != null)
            {
                selectedStyleButton.BackColor = SystemColors.Control;
                selectedStyleButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedStyleButton = button;

            appState.Style = "деловой";
        }

        private void SportsButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedStyleButton != null)
            {
                selectedStyleButton.BackColor = SystemColors.Control;
                selectedStyleButton.ForeColor = SystemColors.ControlText;
            }

            button.BackColor = Color.LightBlue;
            selectedStyleButton = button;

            appState.Style = "спортивный";
        }

        private void LoadData()
        {
            try
            {
                var loader = new ExcelDataLoader();
                var outfits = loader.LoadClothingItemsFromExcel("Образы.xlsx");

                if (outfits == null || !outfits.Any())
                {
                    MessageBox.Show("Файл Excel пуст или не загружен");
                    return;
                }

                // Заполняем дерево
                foreach (var outfit in outfits)
                {
                    outfitTree.Add(outfit.Id, outfit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }


        private void ForwardButton_Click_1(object sender, EventArgs e)
        {

            if (outfitTree == null)
            {
                MessageBox.Show("Данные не загружены!");
                return;
            }

            MessageBox.Show($"Ищем: \nПол={appState.Gender}, \nВозраст={appState.AgeGroup}, \nПогода ={ appState.Weather}, \nСезон={appState.Season}, \nНастроение={appState.Mood}, \nСлучай={appState.Occasion}, \nСтиль = {appState.Style}");
            var allItems = outfitTree.FindByCriteria(o => true);
            MessageBox.Show($"Всего элементов: {allItems.Count}");

            // Поиск по критериям
            appState.RecommendedOutfits = outfitTree.FindByCriteria(o =>
                (string.IsNullOrEmpty(appState.Gender) || o.MatchesCriteria("Gender", appState.Gender)) &&
                (string.IsNullOrEmpty(appState.AgeGroup) || o.MatchesCriteria("AgeGroup", appState.AgeGroup)) &&
                (string.IsNullOrEmpty(appState.Mood) || o.MatchesCriteria("Mood", appState.Mood)) &&
                (string.IsNullOrEmpty(appState.Occasion) || o.MatchesCriteria("Occasion", appState.Occasion)) &&
                (string.IsNullOrEmpty(appState.Style) || o.MatchesCriteria("Style", appState.Style)) &&
                (string.IsNullOrEmpty(appState.Season) || o.MatchesCriteria("Season", appState.Season)) &&
                (string.IsNullOrEmpty(appState.Weather) || o.MatchesCriteria("Weather", appState.Weather))
            ).ToList();

            // Переход на форму с результатами
            if (appState.RecommendedOutfits.Any())
            {
                new ResultForm(appState).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ничего не найдено. Попробуйте изменить критерии.");
            }
        }
    }
}

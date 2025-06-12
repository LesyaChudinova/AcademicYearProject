using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AcademicYearProject.OutfitTree;

namespace AcademicYearProject
{
    public partial class AppForm7 : Form
    {
        private AppState appState;
        private OutfitTree outfitTree;
        private Button selectedStyleButton = null;
        private AppForm6 appForm6;
        private ResultForm resultForm;
        private InstructionForm instructionForm;
        public int currentOutfitIndex = 0;
        public List<OutfitCombo> filteredOutfitCombos = new List<OutfitCombo>();
        public Func<Outfit, bool> criteria;

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
            appState.Style = result;
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
            SelectButton((Button)sender, ref selectedStyleButton, "кэжуал");
        }

        private void GrangeButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedStyleButton, "гранж");
        }

        private void RomanticButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedStyleButton, "романтический");
        }

        private void BusinessButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedStyleButton, "деловой");
        }

        private void SportsButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender, ref selectedStyleButton, "спортивный");
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

            if (string.IsNullOrEmpty(appState.Style))
            {
                MessageBox.Show("Пожалуйста, выберите предпочитаемый стиль");
                return;
            }

            try
            {
                if (outfitTree == null)
                {
                    MessageBox.Show("Приносим извинения!\nСкорее всего, в настоящее время ведется работа над информационной базой, \nпоэтому данные временно не загружены. Возвращайтесь позже!");
                    return;
                }

                var criteria = new Func<Outfit, bool>(o =>
                    (string.IsNullOrEmpty(appState.Gender) || o.MatchesCriteria("Gender", appState.Gender)) &&
                    (string.IsNullOrEmpty(appState.AgeGroup) || o.MatchesCriteria("AgeGroup", appState.AgeGroup)) &&
                    (string.IsNullOrEmpty(appState.Mood) || o.MatchesCriteria("Mood", appState.Mood)) &&
                    (string.IsNullOrEmpty(appState.Occasion) || o.MatchesCriteria("Occasion", appState.Occasion)) &&
                    (string.IsNullOrEmpty(appState.Style) || o.MatchesCriteria("Style", appState.Style)) &&
                    (string.IsNullOrEmpty(appState.Season) || o.MatchesCriteria("Season", appState.Season)) &&
                    (string.IsNullOrEmpty(appState.Weather) || o.MatchesCriteria("Weather", appState.Weather)));

                var filteredOutfitCombos = outfitTree.GenerateRandomOutfitsFromFiltered(criteria, 10);

                if (!filteredOutfitCombos.Any())
                {
                    MessageBox.Show("Ничего не найдено. Попробуйте изменить критерии.");
                    return;
                }

                // Передаём данные в ResultForm
                appState.FilteredOutfitCombos = filteredOutfitCombos;
                appState.CurrentComboIndex = 0;

                var resultForm = new ResultForm(appState, filteredOutfitCombos);
                resultForm.Show();
                this.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}

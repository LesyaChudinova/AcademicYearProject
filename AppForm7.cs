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
            try
            {
                if (outfitTree == null)
                {
                    MessageBox.Show("Данные не загружены!");
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

                // Генерируем комбинации ДО создания формы
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

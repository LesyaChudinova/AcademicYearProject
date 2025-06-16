using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            outfitTree = new OutfitTree(appState);
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
                    ShowServiceUnavailableMessage();
                    return;
                }

                var criteria = CreateSearchCriteria();

                var filteredOutfitCombos = outfitTree.GenerateRandomOutfitsFromFiltered(criteria, appState.Gender, 20);

                var outfitCombos = GenerateOutfitCombinations(criteria, 20);

                if (!outfitCombos.Any())
                {
                    ShowNoResultsMessage();
                    return;
                }

                OpenResultsForm(outfitCombos);
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        private void ShowServiceUnavailableMessage()
        {
            MessageBox.Show("Приносим извинения!\nСкорее всего, в настоящее время ведется работа над информационной базой, \nпоэтому данные временно не загружены. Возвращайтесь позже!");
        }

        private Func<Outfit, bool> CreateSearchCriteria()
        {
            return o =>
            {
                bool matches = true;

                if (!string.IsNullOrEmpty(appState.Gender))
                    matches &= o.MatchesCriteria("Gender", appState.Gender);

                if (!string.IsNullOrEmpty(appState.AgeGroup))
                    matches &= o.MatchesCriteria("AgeGroup", appState.AgeGroup);

                if (!string.IsNullOrEmpty(appState.Mood))
                    matches &= o.MatchesCriteria("Mood", appState.Mood);

                if (!string.IsNullOrEmpty(appState.Occasion))
                    matches &= o.MatchesCriteria("Occasion", appState.Occasion);

                if (!string.IsNullOrEmpty(appState.Style))
                    matches &= o.MatchesCriteria("Style", appState.Style);

                if (!string.IsNullOrEmpty(appState.Season))
                    matches &= o.MatchesCriteria("Season", appState.Season);

                if (!string.IsNullOrEmpty(appState.Weather))
                    matches &= o.MatchesCriteria("Weather", appState.Weather);

                return matches;
            };
        }

        private List<OutfitCombo> GenerateOutfitCombinations(Func<Outfit, bool> criteria, int count)
        {
            var combos = outfitTree.GenerateRandomOutfitsFromFiltered(criteria, appState.Gender, count);

            Debug.WriteLine($"Сгенерировано {combos.Count} комплектов:");
            foreach (var combo in combos)
            {
                Debug.WriteLine($"- {combo.Top?.Name} + {combo.Bottom?.Name}");
            }

            return combos;
        }

        private void ShowNoResultsMessage()
        {
            MessageBox.Show("К сожалению, по вашим критериям ничего не найдено.\nПопробуйте изменить параметры поиска.");
        }

        private void OpenResultsForm(List<OutfitCombo> outfitCombos)
        {
            appState.FilteredOutfitCombos = outfitCombos;
            appState.CurrentComboIndex = 0;

            var resultForm = new ResultForm(appState, outfitCombos)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            this.Hide();
            resultForm.ShowDialog();
            this.Close();
        }

        private void HandleError(Exception ex)
        {
            Debug.WriteLine($"Ошибка: {ex.ToString()}");
            MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}\nПопробуйте еще раз или обратитесь в поддержку.",
                           "Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
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
    }
}

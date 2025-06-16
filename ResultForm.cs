using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AcademicYearProject.OutfitTree;


namespace AcademicYearProject
{
    public partial class ResultForm : Form
    {
        private readonly AppState appState;
        private InstructionForm instructionForm;
        private readonly List<OutfitCombo> outfitCombos;
        private int currentComboIndex = 0;

        public ResultForm(AppState state, List<OutfitCombo> combos)
        {
            InitializeComponent();
            Environment.CurrentDirectory = Application.StartupPath;
            appState = state ?? throw new ArgumentNullException(nameof(state));
            outfitCombos = combos ?? throw new ArgumentNullException(nameof(combos));

            if (!outfitCombos.Any())
            {
                MessageBox.Show("Нет доступных комплектов");
                this.Close();
                return;
            }

            DisplayCurrentCombo(state);
        }


        private void DisplayCurrentCombo(AppState appState)
        {
            if (outfitCombos == null || !outfitCombos.Any())
            {
                ResetDisplay();
                return;
            }

            var combo = outfitCombos[currentComboIndex];

            lblOutfitName.Text = combo.Bottom == null
                ? combo.Top.Name
                : $"{combo.Top.Name} + {combo.Bottom.Name}";

            lblTopInfo.Text = FormatOutfitInfo(combo.Top);
            lblBottomInfo.Text = combo.Bottom != null
                ? FormatOutfitInfo(combo.Bottom)
                : "Цельный предмет одежды";

            string imageUrl = GenerateImageUrl(combo.Top, combo.Bottom, GetGenderPrefix(appState.Gender));
            string fullImagePath = Path.Combine(Application.StartupPath, imageUrl); 
           
            try
            {
                if (File.Exists(fullImagePath))
                {
                    pictureBox1.Image?.Dispose();
                    pictureBox1.Image = Image.FromFile(fullImagePath);
                }
                else
                {
                    pictureBox1.Image = null; 
                    Debug.WriteLine($"Файл не найден: {fullImagePath}"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
                pictureBox1.Image = null;
            }

            string pinterestLink = GeneratePinterestLink(combo.Top, combo.Bottom, appState.Gender);
            linkPinterest.Links.Clear();
            linkPinterest.Links.Add(0, linkPinterest.Text.Length, pinterestLink);

            lblPageInfo.Text = $"{currentComboIndex + 1} из {outfitCombos.Count}";
        }
       
        private string FormatOutfitInfo(Outfit outfit)
        {
            if (outfit == null) return "Нет данных";

            return $@"Название: {outfit.Name}
                Слой: {outfit.Layer}
                Часть тела: {outfit.BodyPart}
                Пол: {outfit.Gender}
                Возраст: {outfit.AgeGroup}
                Стиль: {outfit.Style}
                Сезон: {outfit.Season}";
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }


        private void ResetDisplay()
        {
            lblOutfitName.Text = "Нет данных";
            lblTopInfo.Text = string.Empty;
            lblBottomInfo.Text = string.Empty;
            pictureBox1.Image = null;
            linkPinterest.Text = string.Empty;
            lblPageInfo.Text = "0 из 0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (outfitCombos.Count == 0) return;
            
            currentComboIndex = (currentComboIndex + 1) % outfitCombos.Count;

            // Обновляем все компоненты
            DisplayCurrentCombo(appState);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (outfitCombos.Count == 0) return;

            // Уменьшаем индекс с проверкой на выход за границы
            currentComboIndex = (currentComboIndex - 1 + outfitCombos.Count) % outfitCombos.Count;

            // Обновляем все компоненты
            DisplayCurrentCombo(appState);
        }

        private void linkPinterest_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link?.LinkData == null) return;

            try
            {
                Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString())
                {
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}");
            }
        }

        private void lblOutfitName_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ResultForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
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

        private void AgainButton_Click(object sender, EventArgs e)
        {
            if (instructionForm == null)
                instructionForm = new InstructionForm();
            instructionForm.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static AcademicYearProject.OutfitTree;

namespace AcademicYearProject
{
    public partial class ResultForm : Form
    {
        private readonly AppState appState;
        private readonly OutfitTree outfitTree;
        private AppForm7 appForm7;
        private InstructionForm instructionForm;
        private readonly List<OutfitCombo> outfitCombos;
        private int currentComboIndex = 0;

        public ResultForm(AppState state, List<OutfitCombo> combos)
        {
            InitializeComponent();

            appState = state ?? throw new ArgumentNullException(nameof(state));
            outfitCombos = combos ?? throw new ArgumentNullException(nameof(combos));

            if (!outfitCombos.Any())
            {
                MessageBox.Show("Нет доступных комплектов");
                this.Close();
                return;
            }

            DisplayCurrentCombo();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayCurrentCombo()
        {
            try
            {
                // Проверка на null и пустую коллекцию
                if (appState?.FilteredOutfitCombos == null || !appState.FilteredOutfitCombos.Any())
                {
                    lblOutfitName.Text = "Нет доступных комплектов";
                    lblTopInfo.Text = string.Empty;
                    lblBottomInfo.Text = string.Empty;
                    lblPageInfo.Text = "0 из 0";
                    pictureBox1.Image = null; // Запасное изображение
                    linkPinterest.Visible = false;
                    return;
                }

                // Корректировка индекса, если он вышел за границы
                currentComboIndex = (currentComboIndex < 0) ? 0 :
                   (currentComboIndex >= appState.FilteredOutfitCombos.Count) ?
                   appState.FilteredOutfitCombos.Count - 1 :
                   currentComboIndex;

                var combo = appState.FilteredOutfitCombos[currentComboIndex];

                // Проверка элементов комплекта
                if (combo?.Top == null || combo?.Bottom == null)
                {
                    lblOutfitName.Text = "Ошибка: неполные данные комплекта";
                    return;
                }

                // Отображение основной информации
                lblOutfitName.Text = $"{combo.Top.Name} + {combo.Bottom.Name}";
                lblTopInfo.Text = FormatOutfitInfo(combo.Top);
                lblBottomInfo.Text = FormatOutfitInfo(combo.Bottom);
                lblPageInfo.Text = $"{currentComboIndex + 1} из {appState.FilteredOutfitCombos.Count}";

                // Загрузка изображения с обработкой ошибок
                LoadOutfitImage(combo);

                // Настройка Pinterest ссылки
                SetupPinterestLink(combo);
            }
            catch (Exception ex)
            {
                // Логирование ошибки
                Debug.WriteLine($"Ошибка в DisplayCurrentCombo: {ex.Message}");

                // Отображение информации об ошибке
                lblOutfitName.Text = "Ошибка отображения данных";
                pictureBox1.Image = null;
            }
        }

        // Вспомогательные методы:

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

        private void LoadOutfitImage(OutfitCombo combo)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(combo.ImageUrl))
                {
                    pictureBox1.LoadAsync(combo.ImageUrl);
                    pictureBox1.LoadCompleted += (s, e) =>
                    {
                        if (e.Error != null)
                            pictureBox1.Image = null;
                    };
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }

        private void SetupPinterestLink(OutfitCombo combo)
        {
            linkPinterest.Links.Clear();
            linkPinterest.Visible = !string.IsNullOrWhiteSpace(combo.PinterestLink);

            if (linkPinterest.Visible)
            {
                linkPinterest.Text = "Посмотреть похожие образы на Pinterest";
                linkPinterest.Links.Add(new LinkLabel.Link
                {
                    LinkData = combo.PinterestLink,
                    Description = $"Поиск: {combo.Top.Name} + {combo.Bottom.Name}"
                });
            }
        }
        private void StyleControls()
        {
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9);

            lblOutfitName.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblOutfitName.ForeColor = Color.DarkSlateBlue;
/*
            btnPrev.BackColor = Color.LightSteelBlue;
            btnNext.BackColor = Color.LightSteelBlue;*/

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }


        private void linkPinterest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

    }
}

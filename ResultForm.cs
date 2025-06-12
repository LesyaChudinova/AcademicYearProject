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
        private readonly List<OutfitCombo> outfitCombos;
        private int currentComboIndex = 0;

        public ResultForm(AppState state, List<OutfitCombo> combos)
        {
            InitializeComponent(); // Инициализация кнопок навигации

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


        private void DisplayCurrentCombo()
        {
            try
            {
                if (outfitCombos == null || !outfitCombos.Any())
                {
                    lblOutfitName.Text = "Нет доступных комплектов";
                    lblTopInfo.Text = string.Empty;
                    lblBottomInfo.Text = string.Empty;
                    lblPageInfo.Text = "0 из 0";
                    pictureBox1.Image = null;
                    linkPinterest.Visible = false;
                    return;
                }

                // Корректировка индекса
                currentComboIndex = Math.Max(0, Math.Min(currentComboIndex, outfitCombos.Count - 1));

                var combo = outfitCombos[currentComboIndex];

                if (combo?.Top == null || combo?.Bottom == null)
                {
                    lblOutfitName.Text = "Ошибка: неполные данные комплекта";
                    return;
                }

                // Обновление информации
                lblOutfitName.Text = $"{combo.Top.Name} + {combo.Bottom.Name}";
                lblTopInfo.Text = FormatOutfitInfo(combo.Top);
                lblBottomInfo.Text = FormatOutfitInfo(combo.Bottom);
                lblPageInfo.Text = $"{currentComboIndex + 1} из {outfitCombos.Count}";

                // Загрузка изображения
                LoadOutfitImage(combo);

                // Настройка ссылки Pinterest
                SetupPinterestLink(combo);

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка в DisplayCurrentCombo: {ex.Message}");
                lblOutfitName.Text = "Ошибка отображения данных";
                pictureBox1.Image = null;
            }
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

        private void LoadOutfitImage(OutfitCombo combo)
        {
            try
            {
                pictureBox1.Image = null; // Сброс изображения перед загрузкой

                if (!string.IsNullOrWhiteSpace(combo.ImageUrl))
                {
                    pictureBox1.LoadAsync(combo.ImageUrl);
                    pictureBox1.LoadCompleted += (s, e) =>
                    {
                        if (e.Error != null)
                            pictureBox1.Image = null;
                    };
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

            if (!string.IsNullOrWhiteSpace(combo.PinterestLink))
            {
                linkPinterest.Visible = true;
                linkPinterest.Text = "Посмотреть похожие образы на Pinterest";
                linkPinterest.Links.Add(new LinkLabel.Link
                {
                    LinkData = combo.PinterestLink,
                    Description = $"Поиск: {combo.Top.Name} + {combo.Bottom.Name}"
                });
            }
            else
            {
                linkPinterest.Visible = false;
            }
        }

        private void linkPinterest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(e.Link.LinkData.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}");
            }
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (outfitCombos.Count == 0) return;

            currentComboIndex++;
            if (currentComboIndex >= outfitCombos.Count)
                currentComboIndex = 0; // Циклический переход

            DisplayCurrentCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (outfitCombos.Count == 0) return;

            currentComboIndex--;
            if (currentComboIndex < 0)
                currentComboIndex = outfitCombos.Count - 1; // Циклический переход

            DisplayCurrentCombo();
        }
    }
}

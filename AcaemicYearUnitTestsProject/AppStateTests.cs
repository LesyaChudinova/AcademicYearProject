using static AcademicYearProject.OutfitTree;

namespace AcademicYearProject
{
    [TestClass]
    public class AppStateTests
    {
        [TestMethod]
        public void Properties_CanBeSetAndGet()
        {
            // Arrange
            AppState appState = new AppState();

            // Act
            appState.Gender = "м";
            appState.AgeGroup = "ю";
            appState.Mood = "обычное";
            appState.Occasion = "спортивное";
            appState.Style = "спортивный";
            appState.Season = "лето";
            appState.Weather = "солнечно";
            appState.CurrentComboIndex = 1;

            // Assert
            Assert.AreEqual("м", appState.Gender);
            Assert.AreEqual("ю", appState.AgeGroup);
            Assert.AreEqual("обычное", appState.Mood);
            Assert.AreEqual("спортивное", appState.Occasion);
            Assert.AreEqual("спортивный", appState.Style);
            Assert.AreEqual("лето", appState.Season);
            Assert.AreEqual("солнечно", appState.Weather);
            Assert.AreEqual(1, appState.CurrentComboIndex);
        }

        [TestMethod]
        public void FilteredOutfitCombos_CanBeSetAndGet()
        {
            // Arrange
            AppState appState = new AppState();
            var combos = new List<OutfitCombo>
                {
                    new OutfitCombo { Top = new Outfit(1, "кофта", "верхняя", "верх", "м", "ю", "яркое", "нет", "кэжуал", "весна", "ветренно"), Bottom = new Outfit(2, "джинсы", "верхняя", "низ", "м", "ю", "яркое", "нет", "кэжуал", "весна", "ветренно")},
                    new OutfitCombo { Top = new Outfit(3, "платье", "верхняя", "всё", "ж", "ю", "яркое", "нет", "кэжуал", "весна", "солнечно"), Bottom = null }
                };

            // Act
            appState.FilteredOutfitCombos = combos;

            // Assert
            Assert.AreEqual(2, appState.FilteredOutfitCombos.Count);
            Assert.AreEqual("кофта", appState.FilteredOutfitCombos[0].Top.Name);
        }

        [TestMethod]
        public void RecommendedOutfits_InitializesAsEmptyList()
        {
            // Arrange & Act
            AppState appState = new AppState();

            // Assert
            Assert.IsNotNull(appState.RecommendedOutfits);
            Assert.AreEqual(0, appState.RecommendedOutfits.Count);
        }

        [TestMethod]
        public void RecommendedOutfits_CanAddItems()
        {
            // Arrange
            AppState appState = new AppState();
            var outfit = new Outfit(3, "платье", "верхняя", "всё", "ж", "ю", "яркое", "нет", "кэжуал", "весна", "солнечно");

            // Act
            appState.RecommendedOutfits.Add(outfit);

            // Assert
            Assert.AreEqual(1, appState.RecommendedOutfits.Count);
            Assert.AreEqual("платье", appState.RecommendedOutfits[0].Name);
        }

        [TestMethod]
        public void DefaultValues_AreCorrect()
        {
            // Arrange & Act
            AppState appState = new AppState();

            // Assert
            Assert.IsNull(appState.Gender);
            Assert.IsNull(appState.AgeGroup);
            Assert.IsNull(appState.Mood);
            Assert.IsNull(appState.Occasion);
            Assert.IsNull(appState.Style);
            Assert.IsNull(appState.Season);
            Assert.IsNull(appState.Weather);
            Assert.IsNull(appState.FilteredOutfitCombos);
            Assert.AreEqual(0, appState.CurrentComboIndex);
        }

        [TestMethod]
        public void CurrentComboIndex_CanBeModified()
        {
            // Arrange
            AppState appState = new AppState();

            // Act
            appState.CurrentComboIndex = 5;

            // Assert
            Assert.AreEqual(5, appState.CurrentComboIndex);
        }

        [TestMethod]
        public void FilteredOutfitCombos_CanBeNull()
        {
            // Arrange
            AppState appState = new AppState
            {
                FilteredOutfitCombos = new List<OutfitCombo>()
            };

            // Act
            appState.FilteredOutfitCombos = null;

            // Assert
            Assert.IsNull(appState.FilteredOutfitCombos);
        }
    }
}
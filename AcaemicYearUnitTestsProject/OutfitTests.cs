using AcademicYearProject;

namespace AcademicYearProject
{
    [TestClass]
    public class OutfitTests
    {
        private Outfit testOutfit;

        [TestInitialize]
        public void InitializeDataBeforeTests()
        {
            testOutfit = new Outfit(
                id: 1,
                name: "джинсовая куртка",
                layer: "верхний",
                bodyPart: "верх",
                gender: "м/ж",
                ageGroup: "ю/в",
                mood: "повседневное/уличное",
                occasion: "прогулка/работа",
                style: "кэжуал/гламур",
                season: "весна/осень",
                weather: "солнечно/прохладно"
            );
        }

        [TestMethod]
        public void Constructor_SetsAllPropertiesCorrectly()
        {
            // Assert
            Assert.AreEqual(1, testOutfit.Id);
            Assert.AreEqual("джинсовая куртка", testOutfit.Name);
            Assert.AreEqual("верхний", testOutfit.Layer);
            Assert.AreEqual("м/ж", testOutfit.Gender);
            Assert.AreEqual("ю/в", testOutfit.AgeGroup);
        }

        [TestMethod]
        public void ToString_ReturnsFormattedString()
        {
            // Act
            string result = testOutfit.ToString();

            // Assert
            StringAssert.Contains(result, "джинсовая куртка");
            StringAssert.Contains(result, "Слой: верхний");
            StringAssert.Contains(result, "Пол: м/ж");
            StringAssert.Contains(result, "Погода: солнечно/прохладно");
        }

        [TestMethod]
        [DataRow("Gender", "м", true)]
        [DataRow("Gender", "ж", true)]
        [DataRow("Gender", "унисекс", false)]
        [DataRow("Season", "весна", true)]
        [DataRow("Mood", "уличное", true)]
        [DataRow("Occasion", "работа", true)]
        [DataRow("Style", "кэжуал,уличный", true)]
        [DataRow("Weather", "", true)]
        public void MatchesCriteria_ReturnsExpectedResult(string property, string value, bool expected)
        {
            // Act
            bool result = testOutfit.MatchesCriteria(property, value);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MatchesCriteria_WithInvalidProperty_ReturnsFalse()
        {
            // Act
            bool result = testOutfit.MatchesCriteria("InvalidProperty", "значение");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MatchesCriteria_WithNullPropertyValue_ReturnsFalse()
        {
            // Arrange
            Outfit outfit = new Outfit(
                id: 2,
                name: "футболка",
                layer: null,
                bodyPart: "верх",
                gender: "м",
                ageGroup: "ю",
                mood: "повседневное",
                occasion: "спорт",
                style: "кэжуал",
                season: "лето",
                weather: "солнечно"
            );

            // Act
            bool result = outfit.MatchesCriteria("Layer", "верхний");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow("м/ж", "м,ж", true)]
        [DataRow("кэжуал, гламур", "кэжуал | гламур", true)]
        [DataRow("весна/лето", "зима", false)]
        public void MatchesCriteria_HandlesDifferentDelimiters(string propertyValue, string searchValue, bool expected)
        {
            // Arrange
            Outfit outfit = new Outfit(
                id: 3,
                name: "тест",
                layer: "верхний",
                bodyPart: "верх",
                gender: propertyValue,
                ageGroup: "ю",
                mood: "повседневное",
                occasion: "работа",
                style: "кэжуал",
                season: "лето",
                weather: "солнечно"
            );

            // Act
            bool result = outfit.MatchesCriteria("Gender", searchValue);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MatchesCriteria_WithPartialMatch_ReturnsTrue()
        {
            // Act
            bool result = testOutfit.MatchesCriteria("Mood", "уличное");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MatchesCriteria_WithCaseInsensitiveMatch_ReturnsTrue()
        {
            // Act
            bool result = testOutfit.MatchesCriteria("Gender", "М");

            // Assert
            Assert.IsTrue(result);
        }
    }
}

using AcademicYearProject.Properties;
using AcademicYearProject;

namespace AcademicYearProject
{
    [TestClass]
    public class OutfitNodeTests
    {
        [TestMethod]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            Outfit outfit = new Outfit(
                id: 1,
                name: "Футболка",
                layer: "верхний",
                bodyPart: "верх",
                gender: "м",
                ageGroup: "ю",
                mood: "повседневное",
                occasion: "работа",
                style: "кэжуал",
                season: "лето",
                weather: "солнечно"
            );

            // Act
            OutfitNode node = new OutfitNode(outfit);

            // Assert
            Assert.IsNotNull(node.Outfit);
            Assert.AreEqual("Футболка", node.Outfit.Name);
            Assert.IsNull(node.Left);
            Assert.IsNull(node.Right);
        }

        [TestMethod]
        public void LeftProperty_CanBeSetAndGet()
        {
            // Arrange
            Outfit mainOutfit = new Outfit(1, "Куртка", "верхний", "верх", "м", "п", "повседневное", "работа", "кэжуал", "зима", "холодно");
            Outfit leftOutfit = new Outfit(2, "Футболка", "верхний", "верх", "м", "п", "повседневное", "работа", "кэжуал", "лето", "солнечно");

            OutfitNode mainNode = new OutfitNode(mainOutfit);
            OutfitNode leftNode = new OutfitNode(leftOutfit);

            // Act
            mainNode.Left = leftNode;

            // Assert
            Assert.IsNotNull(mainNode.Left);
            Assert.AreEqual("Футболка", mainNode.Left.Outfit.Name);
        }

        [TestMethod]
        public void RightProperty_CanBeSetAndGet()
        {
            // Arrange
            Outfit mainOutfit = new Outfit(1, "Куртка", "верхний", "верх", "м", "ю", "повседневное", "работа", "кэжуал", "зима", "холодно");
            Outfit rightOutfit = new Outfit(3, "Джинсы", "нижний", "низ", "м", "ю", "повседневное", "работа", "кэжуал", "лето", "любая");

            OutfitNode mainNode = new OutfitNode(mainOutfit);
            OutfitNode rightNode = new OutfitNode(rightOutfit);

            // Act
            mainNode.Right = rightNode;

            // Assert
            Assert.IsNotNull(mainNode.Right);
            Assert.AreEqual("Джинсы", mainNode.Right.Outfit.Name);
        }

        [TestMethod]
        public void OutfitProperty_CanBeReplaced()
        {
            // Arrange
            Outfit originalOutfit = new Outfit(1, "Куртка", "верхний", "верх", "м", "ю", "повседневное", "работа", "кэжуал", "зима", "холодно");
            OutfitNode newNode = new OutfitNode(originalOutfit);
            Outfit newOutfit = new Outfit(2, "Пальто", "верхний", "верх", "м/ж", "в", "официальное", "работа", "классика", "зима", "холодно");

            // Act
            newNode.Outfit = newOutfit;

            // Assert
            Assert.AreEqual("Пальто", newNode.Outfit.Name);
            Assert.AreEqual("официальное", newNode.Outfit.Mood);
        }

        [TestMethod]
        public void DefaultConstructor_InitializesNullProperties()
        {
            // Act
            OutfitNode node = new OutfitNode(null);

            // Assert
            Assert.IsNull(node.Outfit);
            Assert.IsNull(node.Left);
            Assert.IsNull(node.Right);
        }
    }
}

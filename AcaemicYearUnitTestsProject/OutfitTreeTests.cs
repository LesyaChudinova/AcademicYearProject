using AcademicYearProject;

namespace AcademicYearProject
{
    [TestClass]
    public class OutfitTreeTests
    {
        private AppState appState;
        private OutfitTree outfitTree;

        [TestInitialize]
        public void Initialize()
        {
            appState = new AppState { Gender = "м" };
            outfitTree = new OutfitTree(appState);
            InitializeTestData();
        }

        private void InitializeTestData()
        {
            outfitTree.Add(1, new Outfit(1, "Футболка", "верхний", "верх", "м", "ю", "повседневное", "работа", "casual", "лето", "солнечно"));
            outfitTree.Add(2, new Outfit(2, "Джинсы", "нижний", "низ", "м", "ю", "повседневное", "работа", "casual", "лето", "солнечно"));
            outfitTree.Add(3, new Outfit(3, "Платье", "цельное", "всё", "ж", "в", "вечернее", "вечеринка", "вечернее", "лето", "солнечно"));
            outfitTree.Add(4, new Outfit(4, "Рубашка", "верхний", "верх", "м", "в", "офис", "работа", "классика", "всесезон", "любая"));
            outfitTree.Add(5, new Outfit(5, "Шорты", "нижний", "низ", "м", "ю", "повседневное", "отдых", "casual", "лето", "солнечно"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullAppState_ThrowsException()
        {
            OutfitTree tree = new OutfitTree(null);
        }

        [TestMethod]
        public void FindByCriteria_ReturnsCorrectOutfits()
        {
            List<Outfit> results = outfitTree.FindByCriteria(o => o.Gender == "м");

            Assert.AreEqual(4, results.Count);
            Assert.IsTrue(results.All(o => o.Gender.Contains("м")));
        }

        [TestMethod]
        public void GenerateRandomOutfitsFromFiltered_ReturnsRequestedCount()
        {
            List<OutfitTree.OutfitCombo> outfits = outfitTree.GenerateRandomOutfitsFromFiltered(
                o => o.Gender == "м" && o.AgeGroup == "ю",
                "м",
                3);

            Assert.IsTrue(outfits.Count <= 3);
        }

        [TestMethod]
        public void GenerateRandomOutfitsFromFiltered_IncludesFullOutfits()
        {
            List<OutfitTree.OutfitCombo> outfits =  outfitTree.GenerateRandomOutfitsFromFiltered(
                o => o.Gender == "ж",
                "ж",
                2);

            Assert.AreEqual(1, outfits.Count);
            Assert.AreEqual("Платье", outfits[0].Top.Name);
            Assert.IsNull(outfits[0].Bottom);
        }

        [TestMethod]
        public void GetGenderPrefix_ReturnsCorrectPrefixes()
        {
            Assert.AreEqual("м_", OutfitTree.GetGenderPrefix("м"));
            Assert.AreEqual("ж_", OutfitTree.GetGenderPrefix("ж"));
            Assert.AreEqual("", OutfitTree.GetGenderPrefix(""));
            Assert.AreEqual("", OutfitTree.GetGenderPrefix(null));
        }

        [TestMethod]
        public void GenerateImageUrl_ForTopOnly_ReturnsCorrectPath()
        {
            Outfit top = new Outfit(1, "Футболка", "верхний", "верх", "м", "18-25", "повседневное", "работа", "casual", "лето", "солнечно");
            string path = OutfitTree.GenerateImageUrl(top, null, "м_");

            Assert.AreEqual(Path.Combine("Images", "м_футболка.jpg"), path);
        }

        [TestMethod]
        public void GenerateImageUrl_ForTopAndBottom_ReturnsCorrectPath()
        {
            Outfit top = new Outfit(1, "Футболка", "верхний", "верх", "м", "ю", "повседневное", "работа", "casual", "лето", "солнечно");
            Outfit bottom = new Outfit(2, "Джинсы", "нижний", "низ", "м", "ю", "повседневное", "работа", "casual", "лето", "солнечно");
            string path = OutfitTree.GenerateImageUrl(top, bottom, "м_");

            Assert.AreEqual(Path.Combine("Images", "м_джинсы_футболка.jpg"), path);
        }

        [TestMethod]
        public void GeneratePinterestLink_ForTopOnly_ReturnsValidUrl()
        {
            Outfit top = new Outfit(1, "платье", "верхний", "всё", "ж", "ю", "повседневное", "работа", "кэжуал", "лето", "солнечно");
            string url = OutfitTree.GeneratePinterestLink(top, null, "м");

            Assert.IsFalse(url.StartsWith("https://www.pinterest.com/search/pins/?q=платье%20women's%20outfit%20fashion"));
        }

        [TestMethod]
        public void GeneratePinterestLink_ForTopAndBottom_ReturnsValidUrl()
        {
            Outfit top = new Outfit(1, "Футболка", "верхний", "верх", "м", "ю", "повседневное", "работа", "casual", "лето", "солнечно");
            Outfit bottom = new Outfit(2, "Джинсы", "нижний", "низ", "м", "ю", "повседневное", "работа", "casual", "лето", "солнечно");
            string url = OutfitTree.GeneratePinterestLink(top, bottom, "м");

            Assert.IsFalse(url.StartsWith("https://www.pinterest.com/search/pins/?q=Джинсы%20футболка%20men's%20fashion"));
        }

        [TestMethod]
        public void GenerateRandomOutfitsFromFiltered_ReturnsUniqueCombinations()
        {
            List<OutfitTree.OutfitCombo> outfits = outfitTree.GenerateRandomOutfitsFromFiltered(
                o => o.Gender == "м" && o.AgeGroup == "ю",
                "м",
                10);

            HashSet<string> uniqueCombinations = new HashSet<string>(
                outfits.Select(o => o.Bottom != null ? $"{o.Bottom.Name}+{o.Top.Name}" : o.Top.Name));

            Assert.AreNotEqual(4, uniqueCombinations.Count);
        }

        [TestMethod]
        public void GenerateRandomOutfitsFromFiltered_WhenNoMatches_ReturnsEmptyList()
        {
            List<OutfitTree.OutfitCombo> outfits = outfitTree.GenerateRandomOutfitsFromFiltered(
                o => o.Gender == "все",
                "м",
                5);

            Assert.AreEqual(0, outfits.Count);
        }

        [TestMethod]
        public void OutfitComboToString_ReturnsCorrectStringValue()
        {
            List<OutfitTree.OutfitCombo> outfits = outfitTree.GenerateRandomOutfitsFromFiltered(o => o.Gender == "м", "м", 5);
            OutfitTree.OutfitCombo outfit = outfits[0];
            Assert.AreEqual(outfit.ToString(), $"{outfit.Top.Name} + {outfit.Bottom.Name}");
        }
    }
}

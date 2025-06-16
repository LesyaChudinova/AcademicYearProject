using OfficeOpenXml;

namespace AcademicYearProject
{
    [TestClass]
    public class ExcelDataLoaderTests
    {
        private string testFilePath;
        private string sheetName = "Лист1";

        [TestInitialize]
        public void Initialize()
        {
            testFilePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "test_data.xlsx");

            SafeDeleteFile(testFilePath);

            CreateTestExcelFile();

            Thread.Sleep(200);
        }

        [TestCleanup]
        public void Cleanup()
        {
            SafeDeleteFile(testFilePath);
        }

        private void SafeDeleteFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    Thread.Sleep(100);
                }
            }
            catch
            {
               
            }
        }

        private void CreateTestExcelFile()
        {
            ExcelPackage.License.SetNonCommercialOrganization("некоммерческое использование");

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(sheetName);

                worksheet.Cells[1, 1].Value = "Название";
                worksheet.Cells[1, 2].Value = "Слой";
                worksheet.Cells[1, 3].Value = "Часть тела";

                worksheet.Cells[2, 1].Value = "футболка";
                worksheet.Cells[2, 2].Value = "верхний";
                worksheet.Cells[2, 3].Value = "верх";

                package.SaveAs(new FileInfo(testFilePath));
            }
        }

        [TestMethod]
        public void LoadClothingItemsFromExcel_ValidFile_ReturnsItems()
        {
            // Arrange
            var loader = new ExcelDataLoader();

            // Act
            var items = loader.LoadClothingItemsFromExcel(testFilePath, sheetName);

            // Assert
            Assert.IsTrue(items.Count > 0);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LoadClothingItemsFromExcel_InvalidPath_ThrowsException()
        {
            // Arrange
            var loader = new ExcelDataLoader();

            // Act & Assert
            loader.LoadClothingItemsFromExcel("invalid_path.xlsx", sheetName);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LoadClothingItemsFromExcel_InvalidSheet_ThrowsException()
        {
            // Arrange
            var loader = new ExcelDataLoader();

            // Act & Assert
            loader.LoadClothingItemsFromExcel(testFilePath, "invalid_sheet");
        }

        [TestMethod]
        public void GetMultiValues_NormalizesDelimiters()
        {
            // Arrange
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Test");
                worksheet.Cells[1, 1].Value = "м/ж/женский";
                var loader = new ExcelDataLoader();

                // Act
                var result = loader.GetMultiValues(worksheet, 1, 1);

                // Assert
                Assert.AreEqual("м/ж/женский", result);
            }
        }

        [TestMethod]
        public void GetCellValue_ReturnsEmptyForNull()
        {
            // Arrange
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Test");
                worksheet.Cells[1, 1].Value = null;
                var loader = new ExcelDataLoader();

                // Act
                var result = loader.GetCellValue(worksheet, 1, 1);

                // Assert
                Assert.AreEqual(string.Empty, result);
            }
        }

        [TestMethod]
        public void LoadClothingItemsFromExcel_HandlesDifferentDelimiters()
        {
            // Arrange
            var loader = new ExcelDataLoader();

            // Act
            var items = loader.LoadClothingItemsFromExcel(testFilePath, sheetName);

            // Assert
            Assert.AreEqual("м/ж", items[0].Gender);
            Assert.AreEqual("ю/в", items[1].AgeGroup);
        }

        [TestMethod]
        public void LoadClothingItemsFromExcel_SkipsInvalidRows()
        {
            // Arrange
            using (var package = new ExcelPackage(new FileInfo(testFilePath)))
            {
                var worksheet = package.Workbook.Worksheets[sheetName];
                worksheet.Cells[4, 1].Value = ""; // Пустая строка
                package.Save();
            }

            var loader = new ExcelDataLoader();

            // Act
            var items = loader.LoadClothingItemsFromExcel(testFilePath, sheetName);

            // Assert
            Assert.AreEqual(2, items.Count); // Должны остаться только 2 валидные записи
        }
    }
}

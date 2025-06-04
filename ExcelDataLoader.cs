using System;
using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;

namespace AcademicYearProject
{
    public class ExcelDataLoader
    {
        public List<Outfit> LoadClothingItemsFromExcel(string filePath, string sheetName = "Лист1")
        {
            List<Outfit> items = new List<Outfit>();

            FileInfo fileInfo = new FileInfo(filePath);
            if (!fileInfo.Exists)
            {
                throw new FileNotFoundException("Файл базы данных не найден!");
            }

            ExcelPackage.License.SetNonCommercialOrganization("некоммерческое использование");

            using (var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets[sheetName];
                if (worksheet == null)
                {
                    throw new Exception($"Лист '{sheetName}' не найден в файле.");
                }

                int rowCount = worksheet.Dimension.Rows;

                // Начинаем с 2 строки, так как первая - заголовки
                for (int row = 2; row <= rowCount; row++)
                {
                    try
                    {
                        var outfit = new Outfit(
                            id: row - 1, // Используем номер строки как ID
                            name: GetCellValue(worksheet, row, 1),
                            layer: GetMultiValues(worksheet, row, 2),
                            bodyPart: GetMultiValues(worksheet, row, 3),
                            gender: GetMultiValues(worksheet, row, 4),
                            ageGroup: GetMultiValues(worksheet, row, 5),
                            mood: GetMultiValues(worksheet, row, 6),
                            occasion: GetMultiValues(worksheet, row, 7),
                            style: GetMultiValues(worksheet, row, 8),
                            season: GetMultiValues(worksheet, row, 9),
                            weather: GetMultiValues(worksheet, row, 10)
                        );

                        items.Add(outfit);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при обработке строки {row}: {ex.Message}");
                    }
                }
            }

            return items;
        }

        private string GetCellValue(ExcelWorksheet worksheet, int row, int col)
        {
            var cell = worksheet.Cells[row, col];
            return cell.Text?.Trim() ?? string.Empty;
        }

        private string GetMultiValues(ExcelWorksheet worksheet, int row, int col)
        {
            string value = GetCellValue(worksheet, row, col);

            // Заменяем переносы строк и множественные пробелы
            value = value.Replace("\n", "/").Replace("  ", " ").Trim();

            // Удаляем лишние пробелы вокруг слэшей
            value = System.Text.RegularExpressions.Regex.Replace(value, @"\s*/\s*", "/");

            return value;
        }
    }
}
using System.Collections.Generic;
using System;
using System.Linq;

namespace AcademicYearProject
{
    public class Outfit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Layer { get; set; }
        public string BodyPart { get; set; }
        public string Gender { get; set; }
        public string AgeGroup { get; set; }
        public string Mood { get; set; }
        public string Occasion { get; set; }
        public string Style { get; set; }
        public string Season { get; set; }
        public string Weather { get; set; }


        public Outfit(int id, string name, string layer, string bodyPart, string gender, string ageGroup, string mood, string occasion, string style, string season, string weather)
        {
            Id = id;
            Name = name;
            Layer = layer;
            BodyPart = bodyPart;
            Gender = gender;
            AgeGroup = ageGroup;
            Mood = mood;
            Occasion = occasion;
            Style = style;
            Season = season;
            Weather = weather;
        }

        public override string ToString()
        {
            return $"{Name} \n(Слой: {Layer}\nПол: {Gender}\nВозрастная категория: {AgeGroup}\nНастроение: {Mood}\nНазначение: {Occasion}\nСтль: {Style}\nВремя года: {Season}\nПогода: {Weather})";
        }

        public bool MatchesCriteria(string propertyName, string searchValue)
        {
            if (string.IsNullOrEmpty(searchValue))
                return true;

            var property = this.GetType().GetProperty(propertyName);
            if (property == null)
            {
                // Для отладки
                Console.WriteLine($"Свойство {propertyName} не найдено");
                return false;
            }

            string propertyValue = property.GetValue(this)?.ToString();
            if (string.IsNullOrEmpty(propertyValue))
            {
                Console.WriteLine($"Значение свойства {propertyName} пустое");
                return false;
            }

            // Нормализация и разделение значений
            var propertyValues = propertyValue
                .Split(new[] { '/', ',', ';', '|' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim().ToLowerInvariant())
                .ToList();

            var searchValues = searchValue
                .Split(new[] { '/', ',', ';', '|' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim().ToLowerInvariant())
                .ToList();

            // Добавим отладочный вывод
            Console.WriteLine($"Поиск по {propertyName}:");
            Console.WriteLine($"Значения в записи: {string.Join("|", propertyValues)}");
            Console.WriteLine($"Искомые значения: {string.Join("|", searchValues)}");

            // Более гибкое сравнение
            return propertyValues.Any(p =>
                   searchValues.Any(s =>
                       p.Contains(s) || s.Contains(p)));
        }
    }
}

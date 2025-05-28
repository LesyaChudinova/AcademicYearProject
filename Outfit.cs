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

        public List<string> GetSplitValues(string propertyName)
        {
            var property = GetType().GetProperty(propertyName);
            if (property == null) return new List<string>();

            string value = property.GetValue(this) as string;
            if (string.IsNullOrEmpty(value)) return new List<string>();

            return value.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim())
                        .ToList();
        }

        public bool MatchesCriteria(string propertyName, string searchValue)
        {
            var propertyValues = GetSplitValues(propertyName);
            var searchValues = searchValue.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(x => x.Trim())
                                         .ToList();

            return propertyValues.Any(pv => searchValues.Any(sv => pv.Equals(sv, StringComparison.OrdinalIgnoreCase)));
        }
    }
}

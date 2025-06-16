using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AcademicYearProject
{
    public class OutfitTree : BinaryTree<int, Outfit>
    {
        public AppState appState;
        public OutfitTree(AppState appState)
        {
            this.appState = appState ?? throw new ArgumentNullException(nameof(appState));
        }

        private Random random = new Random();
        public List<Outfit> FindByCriteria(Func<Outfit, bool> predicate)
        {
            var results = new List<Outfit>();
            FindByCriteria(root, predicate, results);
            return results;
        }

        private void FindByCriteria(TreePoint<int, Outfit> node, Func<Outfit, bool> predicate, List<Outfit> results)
        {
            if (node == null) return;

            bool isMatch = predicate(node.Value);
            Console.WriteLine($"Проверяем элемент ID={node.Value.Id}, Name={node.Value.Name}, Совпадение: {isMatch}");

            if (isMatch)
                results.Add(node.Value);

            FindByCriteria(node.Left, predicate, results);
            FindByCriteria(node.Right, predicate, results);
        }

        public class OutfitCombo
        {
            public Outfit Top { get; set; }
            public Outfit Bottom { get; set; }
            public string ImageUrl { get; set; }
            public string PinterestLink { get; set; }

            public override string ToString() => $"{Top.Name} + {Bottom.Name}";
        }

        public List<OutfitCombo> GenerateRandomOutfitsFromFiltered(Func<Outfit, bool> criteria, string gender, int count)
        {
            var result = new List<OutfitCombo>();
            string genderPrefix = GetGenderPrefix(gender);

            var tops = FindByCriteria(o => criteria(o) && o.BodyPart == "верх").Distinct().ToList();
            var bottoms = FindByCriteria(o => criteria(o) && o.BodyPart == "низ").Distinct().ToList();
            var fullOutfits = FindByCriteria(o => criteria(o) && o.BodyPart == "всё").Distinct().ToList();

            var possibleCombinations = (from top in tops
                                        from bottom in bottoms
                                        select new { top, bottom }).ToList();

            var randomCombinations = possibleCombinations
                .OrderBy(x => random.Next())
                .Take(Math.Min(count / 2, possibleCombinations.Count))
                .ToList();

            foreach (var combo in randomCombinations)
            {
                result.Add(new OutfitCombo
                {
                    Top = combo.top,
                    Bottom = combo.bottom,
                    ImageUrl = GenerateImageUrl(combo.top, combo.bottom, genderPrefix),
                    PinterestLink = GeneratePinterestLink(combo.top, combo.bottom, gender)
                });
            }

            foreach (var outfit in fullOutfits.OrderBy(x => random.Next()).Take(count - result.Count))
            {
                result.Add(new OutfitCombo
                {
                    Top = outfit,
                    Bottom = null,
                    ImageUrl = GenerateImageUrl(outfit, null, genderPrefix),
                    PinterestLink = GeneratePinterestLink(outfit, null, gender)
                });
            }

            return result.OrderBy(x => random.Next()).ToList();
        }

        public static string GetGenderPrefix(string gender)
        {
            return string.IsNullOrEmpty(gender)
                ? ""
                : (gender == "м" ? "м_" : "ж_");
        }

        public static string GenerateImageUrl(Outfit top, Outfit bottom, string genderPrefix)
        {
            if (top == null)
                return string.Empty;

            return bottom == null
                ? Path.Combine("Images", $"{genderPrefix.ToLower()}{top.Name.ToLower()}.jpg")
                : Path.Combine("Images", $"{genderPrefix.ToLower()}{bottom.Name.ToLower()}_{top.Name.ToLower()}.jpg");
        }

        public static string GeneratePinterestLink(Outfit top, Outfit bottom, string gender)
        {
            try
            {
                if (top == null)
                    return "https://www.pinterest.com/";

                string genderTerm = "";
                if (!string.IsNullOrEmpty(gender))
                {
                    string lowerGender = gender.ToLower();
                    if (lowerGender == "м")
                    {
                        genderTerm = " men's";
                    }
                    else if (lowerGender == "ж")
                    {
                        genderTerm = " women's";
                    }
                }

                string searchQuery = bottom == null
                    ? $"{top.Name}{genderTerm} outfit fashion"         
                    : $"{top.Name} {bottom.Name}{genderTerm} fashion";  

                searchQuery = searchQuery
                    .Replace("  ", " ")      
                    .Trim()                 
                    .ToLower();               

                string encodedQuery = Uri.EscapeDataString(searchQuery);
                return $"https://www.pinterest.com/search/pins/?q={encodedQuery}&rs=typed";
            }
            catch
            {
                return "https://www.pinterest.com/";
            }
        }
    }
}


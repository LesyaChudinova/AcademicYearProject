using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AcademicYearProject
{
    public class OutfitTree : BinaryTree<int, Outfit>
    {
        // Добавим методы, специфичные для работы с одеждой
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

        // Метод для генерации полных образов (комбинации верх+низ)
        public class OutfitCombo
        {
            public Outfit Top { get; set; }
            public Outfit Bottom { get; set; }
            public string ImageUrl { get; set; }
            public string PinterestLink { get; set; }

            public override string ToString() => $"{Top.Name} + {Bottom.Name}";
        }

        public List<OutfitCombo> GenerateRandomOutfitsFromFiltered(Func<Outfit, bool> criteria, int count)
        {
            var tops = FindByCriteria(o => criteria(o) && o.BodyPart == "верх");
            var bottoms = FindByCriteria(o => criteria(o) && o.BodyPart == "низ");

            if (!tops.Any() || !bottoms.Any())
                return new List<OutfitCombo>();

            var combinations = new List<OutfitCombo>();
            var usedPairs = new HashSet<(int, int)>();

            while (combinations.Count < count && usedPairs.Count < tops.Count * bottoms.Count)
            {
                var top = tops[random.Next(tops.Count)];
                var bottom = bottoms[random.Next(bottoms.Count)];
                var pair = (top.Id, bottom.Id);

                if (!usedPairs.Contains(pair))
                {
                    usedPairs.Add(pair);
                    combinations.Add(new OutfitCombo
                    {
                        Top = top,
                        Bottom = bottom,
                        ImageUrl = GetImageUrl(top, bottom),
                        PinterestLink = GetPinterestLink(top, bottom)
                    });
                }
            }

            return combinations;
        }

        private string GetImageUrl(Outfit top, Outfit bottom)
        {
            // Реализация поиска изображения (можно заменить на реальный API)
            return $"https://example.com/images/{top.Name.ToLower()}_{bottom.Name.ToLower()}.jpg";
        }

        private string GetPinterestLink(Outfit top, Outfit bottom)
        {
            // Формирование ссылки на поиск в Pinterest
            return $"https://pinterest.com/search/pins/?q={Uri.EscapeDataString($"{top.Name} {bottom.Name} fashion outfit")}";
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademicYearProject
{
    public class OutfitTree : BinaryTree<int, Outfit>
    {
        // Добавим методы, специфичные для работы с одеждой

        public List<Outfit> FindByCriteria(Func<Outfit, bool> predicate)
        {
            var results = new List<Outfit>();
            FindByCriteria(root, predicate, results);
            return results;
        }

        private void FindByCriteria(TreePoint<int, Outfit> node, Func<Outfit, bool> predicate, List<Outfit> results)
        {
            if (node == null) return;

            if (predicate(node.Value))
                results.Add(node.Value);

            FindByCriteria(node.Left, predicate, results);
            FindByCriteria(node.Right, predicate, results);
        }

        // Метод для генерации полных образов (комбинации верх+низ)
        public List<List<Outfit>> GenerateCompleteOutfits(Func<Outfit, bool> criteria)
        {
            var tops = FindByCriteria(o => criteria(o) && o.BodyPart == "верх");
            var bottoms = FindByCriteria(o => criteria(o) && o.BodyPart == "низ");

            return tops.SelectMany(top =>
                   bottoms.Select(bottom =>
                   new List<Outfit> { top, bottom })).ToList();
        }
    }
}


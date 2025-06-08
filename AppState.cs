using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AcademicYearProject.OutfitTree;

namespace AcademicYearProject
{
    public class AppState
    {
        public string Gender { get; set; }
        public string AgeGroup { get; set; }
        public string Mood { get; set; }
        public string Occasion { get; set; }
        public string Style { get; set; }
        public string Season { get; set; }
        public string Weather { get; set; }
        public List<OutfitCombo> FilteredOutfitCombos { get; set; }
        public int CurrentComboIndex { get; set; }
        public List<Outfit> RecommendedOutfits { get; set; } = new List<Outfit>();
    }
}

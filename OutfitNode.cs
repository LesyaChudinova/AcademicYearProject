namespace AcademicYearProject.Properties
{
    public class OutfitNode
    {
        public Outfit Outfit { get; set; }
        public OutfitNode Left { get; set; }
        public OutfitNode Right { get; set; }

        public OutfitNode(Outfit outfit)
        {
            Outfit = outfit;
            Left = null;
            Right = null;
        }
    }
}

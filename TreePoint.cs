namespace AcademicYearProject
{
    public class TreePoint<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public TreePoint<TKey, TValue> Left { get; set; }
        public TreePoint<TKey, TValue> Right { get; set; }
        public int Height { get; set; } = 1;

        public TreePoint(TKey key, TValue value)
        {
            Key = key;
            Value = value;
            Left = null;
            Right = null;
        }
    }
}

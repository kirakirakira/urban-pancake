namespace UrbanPancake.Library
{
    public static class EnumerableStringExtensions
    {
        public static bool IsCountEven(this IEnumerable<string> thing)
        {
            return thing.Count() % 2 == 0;
        }

        public static bool IsCountOdd(this IEnumerable<string> thing)
        {
            return !thing.IsCountEven();
        }
    }
}

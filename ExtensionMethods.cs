using System.Text.RegularExpressions;

namespace SharedTools
{
    public static class ExtensionMethods
    {
        private static readonly Regex sWhitespace = new Regex(@"\s+");

        public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> source)
        {
            return source.Select((item, index) => (item, index));
        }

        public static string ReplaceWhitespace(this string input, string replacement = "")
        {
            return sWhitespace.Replace(input, replacement);
        }

        public static T PopMax<T>(this IList<T> source) where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            var max = source.Max();
            source.Remove(max);

            return max;
        }
    }
}

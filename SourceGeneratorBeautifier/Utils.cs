using System.Text.RegularExpressions;

namespace SourceGeneratorBeautifier
{
    internal class Utils
    {
        public static string GenerateIndentation(int count)
        {
            return new string('\t', count);
        }

        public static string ToSentenceCase(string str)
        {
            return Regex.Replace(str, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}");
        }
    }
}

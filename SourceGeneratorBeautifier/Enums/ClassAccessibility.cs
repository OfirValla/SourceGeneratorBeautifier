
namespace SourceGeneratorBeautifier.Enums
{
    public enum ClassAccessibility
    {
        None = 0,
        Public = 1,
        Internal = 2
    }

    internal static class ClassAccessibilityExtensions
    {
        public static string AccessibilityToString(this ClassAccessibility accessibility)
        {
            if (accessibility == ClassAccessibility.None) return "";
            return $"{accessibility.ToString().ToLower()} ";
        }
    }
}

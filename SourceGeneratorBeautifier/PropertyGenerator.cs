using SourceGeneratorBeautifier.Enums;

namespace SourceGeneratorBeautifier
{
    public class PropertyGenerator
    {
        public PropertyAccessibility Accessibility { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            string accessibility = Utils.ToSentenceCase(Accessibility.ToString()).ToLower();
            return $"{accessibility} {Type} {Name} {{ get; set; }}";
        }
    }
}

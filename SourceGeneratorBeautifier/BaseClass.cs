using SourceGeneratorBeautifier.Enums;

namespace SourceGeneratorBeautifier
{
    public abstract class BaseClass
    {
        public string Name { get; set; }
        public ClassAccessibility Accessibility { get; set; }

        public virtual string Print(int indent = 1)
        {
            return "";
        }
    }
}

using SourceGeneratorBeautifier.Enums;
using System.Collections.Generic;
using System.Text;

namespace SourceGeneratorBeautifier
{
    public class RecordGenerator : BaseClass 
    {
        public Dictionary<string, string> Properties { get; set; }

        public RecordGenerator(string name)
        {
            Accessibility = ClassAccessibility.Public;
            Name = name;
            Properties = new Dictionary<string, string>();
        }

        public RecordGenerator(ClassAccessibility accessibility, string name) : this(name)
        {
            Accessibility = accessibility;
        }

        public override string Print(int indent = 1)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{Utils.GenerateIndentation(indent)}{Accessibility.AccessibilityToString()}record {Name}(");

            foreach(var property in Properties)
            {
                builder.AppendLine($"{Utils.GenerateIndentation(indent + 1)}{property.Key} {property.Value},");
            }
            builder.Remove(builder.Length - 3, 1);
            
            builder.AppendLine($"{Utils.GenerateIndentation(indent)});");

            return builder.ToString();
        }
    }
}

using SourceGeneratorBeautifier.Enums;
using System.Collections.Generic;
using System.Text;

namespace SourceGeneratorBeautifier
{
    public class EnumGenerator : BaseClass
    {
        public Dictionary<string, int> Values { get; set; }

        public string Extends { get; set; }

        public bool IsFlags { get; set; }

        public EnumGenerator(string name)
        {
            Accessibility = ClassAccessibility.Public;
            IsFlags = false;
            Extends = null;
            Name = name;
            Values = new Dictionary<string, int>();
        }

        public EnumGenerator(ClassAccessibility accessibility, string name) : this(name)
        {
            Accessibility = accessibility;
        }

        public override string Print(int indent = 1)
        {
            StringBuilder builder = new StringBuilder();

            if (IsFlags)
                builder.AppendLine($"{Utils.GenerateIndentation(indent)}[Flags]");

            string extends = "";
            if (!string.IsNullOrWhiteSpace(Extends))
                extends = $" : {Extends}";

            builder.AppendLine($"{Utils.GenerateIndentation(indent)}{Accessibility.AccessibilityToString()}enum {Name}{extends}");
            builder.AppendLine($"{Utils.GenerateIndentation(indent)}{{");

            foreach(var item in Values)
            {
                builder.AppendLine($"{Utils.GenerateIndentation(indent + 1)}{item.Key} = {item.Value},");
            }

            builder.AppendLine($"{Utils.GenerateIndentation(indent)}}}");
            return builder.ToString();
        }
    }
}

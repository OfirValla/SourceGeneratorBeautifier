using SourceGeneratorBeautifier.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SourceGeneratorBeautifier
{
    public class ClassGenerator : BaseClass
    {
        public List<PropertyGenerator> Properties { get; set; }

        public ClassGenerator(string name)
        {
            Accessibility = ClassAccessibility.Public;
            Name = name;
            Properties = new List<PropertyGenerator>();
        }

        public ClassGenerator(ClassAccessibility accessibility, string name) : this(name)
        {
            Accessibility = accessibility;
        }

        public override string Print(int indent = 1)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{Utils.GenerateIndentation(indent)}{Accessibility.AccessibilityToString()}class {Name}");
            builder.AppendLine($"{Utils.GenerateIndentation(indent)}{{");

            Properties.ForEach(property =>
            {
                builder.AppendLine($"{Utils.GenerateIndentation(indent + 1)}{property}");
            });

            builder.AppendLine($"{Utils.GenerateIndentation(indent)}}}");

            return builder.ToString();
        }
    }

    internal class TEST
    {
        internal int MyProperty { get; set; }
        public string MyProperty2 { get; set; }
    }

}

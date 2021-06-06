using System;
using System.Collections.Generic;
using System.Text;

namespace SourceGeneratorBeautifier
{
    public class NamespaceGenerator
    {
        public List<string> Usings { get; set; }
        public string Name { get; set; }
        public List<BaseClass> Classes { get; set; }

        public NamespaceGenerator(string name)
        {
            Usings = new List<string>();
            Name = name;
            Classes = new List<BaseClass>();
        }

        public string Print()
        {
            StringBuilder builder = new StringBuilder();

            Usings.ForEach(usingRef =>
            {
                builder.AppendLine($"using {usingRef};");
            });
            builder.AppendLine();

            builder.AppendLine($"namespace {Name}");
            builder.AppendLine("{");

            Classes.ForEach(classRef =>
            {
                builder.AppendLine(classRef.Print());
            });

            builder.AppendLine("}");

            return builder.ToString();
        }
    }
}

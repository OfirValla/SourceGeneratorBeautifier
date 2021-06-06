using SourceGeneratorBeautifier;
using SourceGeneratorBeautifier.Enums;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            NamespaceGenerator myNamespace = new("TestNamespace");

            myNamespace.Usings.Add("System");
            myNamespace.Usings.Add("System.IO");

            EnumGenerator myEnum = new(ClassAccessibility.Internal ,"TestEnum");
            myEnum.IsFlags = true;
            myEnum.Extends = "short";
            myEnum.Values.Add("None", 0);
            myEnum.Values.Add("Black", 1);
            myEnum.Values.Add("Red", 2);
            myEnum.Values.Add("Green", 4);
            myEnum.Values.Add("Blue", 8);
            myNamespace.Classes.Add(myEnum);

            RecordGenerator myRecord = new("TestRecord");
            myRecord.Properties.Add("string", "TEST");
            myRecord.Properties.Add("int", "TEST2");
            myNamespace.Classes.Add(myRecord);

            ClassGenerator myClass = new(ClassAccessibility.None, "TestClass");
            myClass.Properties.Add(new PropertyGenerator { Accessibility = PropertyAccessibility.Private, Type = "string", Name = "prop1" });
            myClass.Properties.Add(new PropertyGenerator { Accessibility = PropertyAccessibility.ProtectedInternal, Type = "int", Name = "prop2" });
            myNamespace.Classes.Add(myClass);

            string namespaceText = myNamespace.Print();
            Console.WriteLine(namespaceText);

        }
    }


    public record TestRecord(
        string TEST, 
        int TEST2
    );
}



using CSharp12.AttributesAndMetadata;

Console.WriteLine("Hello from Ziggy Rafiq!");
DeveloperInfoAttribute.DisplayDeveloperInfo(typeof(ExampleClass));
DeveloperInfoAttribute.DisplayDeveloperInfo(typeof(ExampleClass).GetMethod("ExampleMethod"));


ComponentInfoAttribute.DisplayComponentInfo(typeof(ZiggyComponent));

using System.Reflection;

namespace CSharp12.AttributesAndMetadata;

[AttributeUsage(AttributeTargets.Class)]
public class ComponentInfoAttribute : Attribute
{
    public string Name { get; }
    public string Version { get; }

    public ComponentInfoAttribute(string name, string version)
    {
        Name = name;
        Version = version;
    }

    public static void DisplayComponentInfo(Type componentType)
    {
        var attribute = componentType.GetCustomAttribute<ComponentInfoAttribute>();
        if (attribute != null)
        {
            Console.WriteLine($"Component Name: {attribute.Name}");
            // Split version into parts if needed
            var versionParts = attribute.Version.Split('.');
            if (versionParts.Length == 3)
            {
                Console.WriteLine($"Version: Major={versionParts[0]}, Minor={versionParts[1]}, Patch={versionParts[2]}");
            }

        }
    }
}

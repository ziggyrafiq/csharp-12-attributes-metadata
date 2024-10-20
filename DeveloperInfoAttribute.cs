using System.Reflection;

namespace CSharp12.AttributesAndMetadata;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false)]
public class DeveloperInfoAttribute : Attribute
{
    public string DeveloperName { get; }
    public string Version { get; }
    public string? Notes { get; }

    public DeveloperInfoAttribute(string developerName, string version, string? notes = null)
    {
        DeveloperName = developerName;
        Version = version;
        Notes = notes;
    }

    public static void DisplayDeveloperInfo(MemberInfo member)
    {
        var attribute = member.GetCustomAttribute<DeveloperInfoAttribute>();
        if (attribute != null)
        {
            Console.WriteLine($"Member: {member.Name}");
            Console.WriteLine($"Developer: {attribute.DeveloperName}");
            Console.WriteLine($"Version: {attribute.Version}");
            Console.WriteLine($"Notes: {attribute.Notes}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"No DeveloperInfo attribute found on {member.Name}.");
        }
    }

}

namespace CSharp12.AttributesAndMetadata;

[DeveloperInfo("Ziggy Rafiq", "0.0.1", "Initial version")]
public class ExampleClass
{
    [DeveloperInfo("Ziggy Rafiq", "0.0.2", "Fixed minor bugs")]
    public void ExampleMethod()
    {
        Console.WriteLine("Executing ExampleMethod.");
    }

}

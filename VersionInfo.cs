namespace CSharp12.AttributesAndMetadata;

public readonly struct VersionInfo
{
    public int Major { get; }
    public int Minor { get; }
    public int Patch { get; }

    public VersionInfo(int major, int minor, int patch)
    {
        Major = major;
        Minor = minor;
        Patch = patch;
    }
}

namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aidenit.com";
    public string Message => "A practice application from CPST 343";
}
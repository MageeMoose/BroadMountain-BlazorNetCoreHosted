namespace BroadMountainBlazorNetCoreHosted.Shared;

public class NavImage
{
    public int Id { get; set; }
    public string ImgUrl { get; set; } = string.Empty;
    public string PathLink { get; set; } = string.Empty;
    public string ImgAlt { get; set; } = string.Empty;
    public bool IsExt { get; set; }
    public bool IsSign { get; set; }
    public bool IsNav { get; set; }
    public int Delay { get; set; }
    
}
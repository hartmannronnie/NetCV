namespace Domain.Models;

public class Settings
{
    public long Id { get; set; }

    public string? FavIconFileName { get; set; }

    public string? PortraitImageFileName { get; set; }

    public string? BackgroundImageFileName { get; set; }

    public required bool OpenToWork { get; set; }

    public required bool ShowFooter { get; set; }

    public required bool ShowVersion { get; set; }

    public required bool ShowPoweredByNetCv { get; set; }
}

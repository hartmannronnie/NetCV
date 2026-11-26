namespace Application.Services.Settings;

public interface ISettingsService
{
    Task<string> GetFavIconFilePathAsync();

    Task<string> GetPortraitFilePathAsync();

    Task<string> GetBackgroundFilePathAsync();

    Task<bool> GetOpenToWorkAsync();

    Task<bool> GetShowFooterAsync();

    Task<bool> GetShowVersionAsync();

    Task<bool> GetShowPoweredByNetCvAsync();

    Task UpdateFavIconFileNameAsync(string fileName);

    Task UpdatePortraitFileNameAsync(string fileName);

    Task UpdateBackgroundFileNameAsync(string fileName);

    Task UpdateOpenToWorkAsync(bool openToWork);

    Task UpdateShowFooterAsync(bool showFooter);

    Task UpdateShowVersionAsync(bool showVersion);

    Task UpdateShowPoweredByNetCvAsync(bool showPoweredByNetCv);
}

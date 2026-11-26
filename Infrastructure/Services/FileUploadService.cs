using Imagekit;
using Imagekit.Models.Files;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Services;

public class FileUploadService(
    ILogger<FileUploadService> logger,
    ImageKitClient client)
{
    private readonly ILogger<FileUploadService> _logger = logger;
    private readonly ImageKitClient _client = client;

    public async Task<string?> UploadFileAsync(Stream stream, string fileName, int maxFileSize)
    {
        if (stream.Length > maxFileSize)
        {
            _logger.LogError(
                "Image could not be uploaded. File size ({} bytes) exceeds maximum size of {} bytes.", 
                stream.Length, maxFileSize);

            return null;
        }

        var parameters = new FileUploadParams
        {
            File = stream,
            FileName = fileName,
        };

        var result = await _client.Files.Upload(parameters);
        try
        {
            result.Validate();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while validating file upload result.");
            return null;
        }

        return result.FilePath;
    }
}

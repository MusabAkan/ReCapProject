using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers
{
    public interface IFileHelper
    {
        IResult UploadImageFile(IFormFile? file);
        IResult DeleteImageFile(string? path);
        IResult FileExists(string path);
    }
}

using Core.Utilities.Constants;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers
{
    public class FileHelper : IFileHelper
    {
        const string wwwrootPath = @"C:\inetpub\wwwroot\images\";
        public IResult DeleteImageFile(string? path)
        {
            if (string.IsNullOrEmpty(path))
                return new SuccessResult(Messages.NotFoundAddres );

            var result = FileExists(path);

            if (result.Success)
            {
                File.Delete(path);
                return new SuccessResult(Messages.RemovedImageFile);
            }
            else
                return new ErrorResult(result.Message);
        }
        public IResult FileExists(string path)
        {          
            if (File.Exists(path))
                return new SuccessResult(); 
            else
                return new ErrorResult(Messages.NotFoundImageFile);   
        }
        public IResult UploadImageFile(IFormFile? file)
        {
            if (file == null || file.Length == 0)
                return new ErrorResult(Messages.NotFoundSelectFile);

            if ((file.Length / 1024) > 3072)//3MB sınırı
                return new ErrorResult(Messages.MaxFileCount);

            if (file.ContentType != "image/jpeg" && file.ContentType != "image/jpg" && file.ContentType != "image/png")
                return new ErrorResult(Messages.NotFormatFile);

            var imageGuid = Guid.NewGuid();
            var imagePath = Path.Combine(@$"{wwwrootPath}{imageGuid}.jpg");

            using (var stream = new FileStream(imagePath, FileMode.Create))
            {
                file.CopyTo(stream);
                stream.Flush();
                return new SuccessResult(imagePath);
            }
        }
    }
}


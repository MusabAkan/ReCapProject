using Core.Utilities.Results;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers
{
    public class FileHelper : IFileHelper
    {

        const string wwwrootPath = @"C:\inetpub\wwwroot\images\";
        public IResult UploadImageFile(IFormFile? file)
        {
            if (file == null || file.Length == 0)
                return new ErrorResult("Dosya seçilmedi yada boş!!");

            if ((file.Length / 1024) > 3072)
                return new ErrorResult("Dosya boyutu aşılmıştır.");

            if (file.ContentType != "image/jpeg" && file.ContentType != "image/jpg" && file.ContentType != "image/png")
                return new ErrorResult("Dosya uygun formatta değildir.");

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


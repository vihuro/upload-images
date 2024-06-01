using Microsoft.AspNetCore.Mvc;
using upload_images.Application.Dtos;
using upload_images.Application.Interfaces;

namespace upload_images.Application.Services
{
    public class ImageService : IImageService
    {
        private static readonly string caminho = "./images/teste";

        public async Task InsertImage(ImageInsertDto request)
        {
            var fullPath = Path.Combine(caminho, $"{request.ImageName}.jpg");

            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await request.Image.CopyToAsync(stream);
            }
        }
        public FileResult GetByName(string name)
        {
            var fullPath = $"{caminho}/{name}.jpg";
            string mimeType = "image/jpg";
            if (!File.Exists(fullPath)) return null;

            var fileStream = File.OpenRead(fullPath);
            return new FileStreamResult(fileStream, mimeType);
        }
    }
}

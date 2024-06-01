using Microsoft.AspNetCore.Mvc;
using upload_images.Application.Dtos;

namespace upload_images.Application.Interfaces
{
    public interface IImageService
    {
        Task InsertImage(ImageInsertDto request);
        FileResult GetByName(string name);
    }
}

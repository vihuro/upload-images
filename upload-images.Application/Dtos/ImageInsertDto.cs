using Microsoft.AspNetCore.Http;

namespace upload_images.Application.Dtos
{
    public sealed record ImageInsertDto(IFormFile Image, string ImageName);
}

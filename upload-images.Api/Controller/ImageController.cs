using Microsoft.AspNetCore.Mvc;
using upload_images.Application.Dtos;
using upload_images.Application.Interfaces;

namespace upload_images.Api.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpPost]
        public async Task<ActionResult> InsertImage([FromForm] ImageInsertDto request)
        {
            try
            {
                await _imageService.InsertImage(request);

                return Ok("Aqui foi");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{name}")]
        public ActionResult GetByName(string name)
        {
            try
            {
                var result = _imageService.GetByName(name);
                if (result == null) return NotFound();

                return result;
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}

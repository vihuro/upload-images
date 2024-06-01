using Microsoft.Extensions.DependencyInjection;
using upload_images.Application.Interfaces;
using upload_images.Application.Services;

namespace upload_images.Application
{
    public static class ServiceExtensions
    {
        public static void ConfigureApplicationApp(this IServiceCollection services)
        {
            services.AddScoped<IImageService, ImageService>();
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces.AutoMapper;

namespace Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}

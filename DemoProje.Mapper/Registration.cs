using Microsoft.Extensions.DependencyInjection;
using DemoProje.Application.Interfaces.AutoMapper;


namespace DemoProje.Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}

using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using ThisneyTicket.Application.AutoMapper;

namespace ThisneyTicket.API.Configuration
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewMappingProfile), typeof(ViewToDomainMappingProfile));
        }
    }
}

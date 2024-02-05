using AutoMapper;
using Common.Entity;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped(typeof(IService<CategoryDto>), typeof(CategoryService));
            services.AddScoped(typeof(IService<UserDto>), typeof(UserService));
            services.AddScoped(typeof(IService<MeasureDto>), typeof(MeasureService));
            services.AddScoped(typeof(IService<IngredientDto>), typeof(IngredientService));
            services.AddScoped(typeof(IService<RecipeDto>), typeof(RecipeService));

            //services.AddScoped(<IService<UserDto>, UserService>());
            //services.AddScoped(<IService<MeasureDto>, MeasureService>());
            //services.AddScoped(<IService<IngredientDto>, IngredientService>());
            //services.AddScoped(<IService<RecipeDto>, RecipeService>());
            //services.AddScoped<IService<FollowerDto>, FollowerService>();
            //services.AddScoped<IService<CommentDto>, CommentService>();

            services.AddAutoMapper(typeof(MapperProfile));
            return services;
        }
    }
}

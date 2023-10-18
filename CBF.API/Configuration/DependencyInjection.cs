using CBF.API.Filters;
using CBF.Infra.Context;
using CBF.Service.Validation;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Scrutor;
using System.Text;
using System.Text.Json.Serialization;

namespace CBF.API.Configuration;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureAndServices(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .Scan(selector => selector
                                .FromAssemblies(
                                        Infra.AssemblyReference.Assembly,
                                        Service.AssemblyReference.Assembly)
                                .AddClasses(false)
                                .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                                .AsMatchingInterface()
                                .WithScopedLifetime());

        return services;
    }

    public static IServiceCollection AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("CBFConnection");
        services.AddDbContext<CBFContext>(options => options.UseSqlServer(connectionString));

        return services;
    }

    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation();
        services.AddValidatorsFromAssemblyContaining<BaseValidator>();
        services.Configure<ApiBehaviorOptions>(options =>
        {
            options.SuppressModelStateInvalidFilter = true;
        });

        services
            .AddControllers(options =>
            {
                options.Filters.Add(typeof(ValidationFilter));
            })
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });

        services.AddAutoMapper(cfg => cfg.AddMaps(Service.AssemblyReference.Assembly));

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "P2P", Version = "v1" });

            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer"
            });

            c.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        },
                        Scheme = "oauth2",
                        Name = "Bearer",
                        In = ParameterLocation.Header,
                    },
                    new List<string>()
                }
            });
        });



        return services;
    }
        //adicionado
    public static IServiceCollection AddAuthorization(this IServiceCollection services, IConfiguration configuration)
    {

            //var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var key = Encoding.ASCII.GetBytes(configuration.GetValue<string>("Secret"));

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(y =>
            {
                y.RequireHttpsMetadata = false;
                y.SaveToken = true;
                y.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                };

            });

            return services;

    }
}

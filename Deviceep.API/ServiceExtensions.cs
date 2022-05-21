using AspNetCoreRateLimit;
using Deviceep.API.DTOs;
using Deviceep.Data;
using Deviceep.Entity.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.API
{

    // WE CAN DEFINE OR CREATE SERVICES THAT MIGHT MAKE THE STARTUP.CS FILE TOO CROWDED
    public static class ServiceExtensions
    {

        // Identity User configuration
        // Identity user is a NughetPackage to manage the user better
        public static void ConfigureIdentity(this IServiceCollection services )
        {
            var builder = services.AddIdentityCore<User>(q => q.User.RequireUniqueEmail = true);

            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole),services);
            builder.AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
        }

        // Global Exception Handler
        // It eliminates the tiring code repetitions in the controllers

        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(error =>
            {
                error.Run(async context =>
                {
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        Log.Error($"Someting Went Wrog in the {contextFeature.Error}");

                        await context.Response.WriteAsync(new ErrorDTO
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = "Inernal Server Error. Please Try Again Later."
                        }.ToString());

                    }
                });
            });
        }

        // Creating the JWT
        public static void ConfigureJWT(this IServiceCollection services, IConfiguration Configuration)
        {
            // Appsetting.json 
            var jwtSettings = Configuration.GetSection("Jwt");
            
            //var key = Environment.GetEnvironmentVariable("KEY1");

            var key = jwtSettings.GetSection("KEY").Value;
            // JWT Creation Rules are defined below
            services.AddAuthentication(o =>
            {
                o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings.GetSection("Issuer").Value,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),

                };
            });

        }

        // APIS can have multiple version
        // With this function We can create multiple API's for our different clients
        // Who might be using different functions
        public static void ConfigureVersioning(this IServiceCollection services)
        {
            // Version rules and features
            services.AddApiVersioning(opt =>
            {
                opt.ReportApiVersions = true;
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = new ApiVersion(1, 0);
                opt.ApiVersionReader = new HeaderApiVersionReader("api-version");
            });
        }


        // Caching Service
        public static void ConfigureHttpCacheHeaders(this IServiceCollection services)
        {
            services.AddResponseCaching();
            services.AddHttpCacheHeaders();
        }

        // It limits how many times can a user send HTTP requeests
        public static void ConfigureRateLimiting(this IServiceCollection services)
        {
            var rateLimitRules = new List<RateLimitRule>
            {

                 new RateLimitRule
                {
                    // Can define specific end points to have much more control
                    Endpoint = "*",
                    Limit = 8,
                    Period = "1s"
                },
               

               
            };
            // Services needed
            services.Configure<IpRateLimitOptions>(opt =>
            {
                opt.GeneralRules = rateLimitRules;
            });
            services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
            services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
        }

        

    }
}

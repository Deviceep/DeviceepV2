using Deviceep.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using AutoMapper;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deviceep.API.Mapping;
using Deviceep.Core.UnitOfWorks;
using Deviceep.Data.UnitOfWorks;
using Deviceep.Core.Services;
using Deviceep.Service.Services;
using Deviceep.Core.Repositories;
using Deviceep.Data.Repositories;
using Deviceep.API.Authenticiation;
using AspNetCoreRateLimit;

namespace Deviceep.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Database COnnection Initialize here
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("sqlConnection"))

            );
            // Caching Service Added Here
            services.AddMemoryCache();

            // API Quotas are Initiallized here 
            services.ConfigureRateLimiting();
            services.AddHttpContextAccessor();
            services.AddSingleton<IProcessingStrategy, AsyncKeyLockProcessingStrategy>();
            // Caching Service Added Here
            services.AddResponseCaching();
            // DTO and Entity models services 
            services.AddAutoMapper(typeof(MapperInitializer));

            // Unit Of Work ve Servisler
            services.AddTransient<IUnitOfWork, UnitOfWorks>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            // Data Serviceleri
            services.AddScoped<IAttendanceService, AttendanceService>();
            services.AddScoped<IAttendanceHourService, AttendanceHourService>();
            services.AddScoped<IClassroomService, ClassroomService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ICourseTimeInfoService, CourseTimeInfoService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IFacultyService, FacultyService>();
            services.AddScoped<IUserService, UserService>();

            // Authentication for user
            services.AddScoped<IAuthManager, AuthManager>();

            // Authorization and Authentication services are Initialized here
            services.ConfigureHttpCacheHeaders();
            services.AddAuthentication();
            services.ConfigureIdentity();
            services.ConfigureJWT(Configuration);


            // Cache Time Definition
            services.AddControllers(config => {
                config.CacheProfiles.Add("120SecondDuration", new CacheProfile
                {
                    Duration = 120
                });
            }).AddNewtonsoftJson(op =>
            op.SerializerSettings.ReferenceLoopHandling =
            Newtonsoft.Json.ReferenceLoopHandling.Ignore);


            // Cross-Origin Resource Sharing
            // Defines who can access our application
            services.AddCors(o =>
            {
                o.AddPolicy("AllowAll", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            // API documentation framework
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Deviceep.API", Version = "v1" });
            });
            // Version Control for API
            services.ConfigureVersioning();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Defines which stage in this application
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // APIU documentation Framework
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Deviceep.API v1"));

            // Global Exception Handlling
            app.ConfigureExceptionHandler();

            app.UseHttpsRedirection();

            app.UseCors("AllowAll");

            // Caching
            //app.UseResponseCaching();
            app.UseHttpCacheHeaders();
            // API Quotas
            app.UseIpRateLimiting();

            app.UseRouting();

            // Authentication and Authorization for the User and Application
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

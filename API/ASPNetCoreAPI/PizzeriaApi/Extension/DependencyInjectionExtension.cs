using PizzeriaApi.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using pizzaApiDTO.Repositories;
using PizzeriaApi.Data;
using PizzeriaApi.Helpers;
using PizzeriaApi.Models;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace PizzeriaApi.Extension
{
    public static class DependencyInjectionExtension
    {

        public static void InjectDependancies(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.addSwagger();
            builder.AddRepositories();
            builder.AddDatabase();
            builder.AddAuthentication();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        private static void addSwagger(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "PizzeriaApi", Description = "On récupère des pizza" });
                c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using Bearer scheme",
                    Name = "Authorization",
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    Type = SecuritySchemeType.Http
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id= "Bearer"
                    }
                },
                new String[]{}
           }
                });


            }




         );
        }



        private static void AddRepositories(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IRepository<Pizza>, PizzaRepository>();
            builder.Services.AddScoped<IRepository<Ingredient>, IngredientRepository>();
        }


        private static void AddDatabase(this WebApplicationBuilder builder)
        {
            var conn = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(conn));
        }



        public static void AddAuthentication(this WebApplicationBuilder builder)
        {
            var appSettingSection = builder.Configuration.GetSection(nameof(AppSettings));

            builder.Services.Configure<AppSettings>(appSettingSection);

            AppSettings appSettings = appSettingSection.Get<AppSettings>();


            var key = Encoding.ASCII.GetBytes(appSettings.SecretKey);


            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateAudience = true,
                        ValidAudience = appSettings.ValidAudience,
                        ValidateIssuer = true,
                        ValidIssuer = appSettings.ValidIssuer,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero

                    };

                });

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy(Constants.PolicyAdmin, policy =>
                {
                    policy.RequireClaim(ClaimTypes.Role, Constants.RoleAdmin);
                    // policy.RequireClaim(ClaimTypes.Role, Constants.RoleUser);
                });

                options.AddPolicy(Constants.PolicyUser, policy =>
                {
                    policy.RequireClaim(ClaimTypes.Role, Constants.RoleUser);
                }
               );


            });



        }











    }
}

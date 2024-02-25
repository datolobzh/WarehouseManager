using Microsoft.EntityFrameworkCore;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Facade.Profiles;
using WarehouseManager.Repositories;
using WarehouseManager.Services.CommandServices;
using WarehouseManager.Services.Interfaces.Commands;
using WarehouseManager.Services.Interfaces.Queries;
using WarehouseManager.Services.QueryServices;
using WarehouseManager.Services.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Serilog;

namespace WarehouseManager.API.Startup
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<WarehouseDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MSSQLConnection"));
            });

            services.AddSerilog((configs) => configs.ReadFrom.Configuration(configuration));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ClockSkew = TimeSpan.Zero,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = "apiWithAuthBackend",
                ValidAudience = "apiWithAuthBackend",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SecretKey"))
            };
        });


            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //command services
            services.AddScoped<IEmployeeCommand, EmployeeCommandService>();
            services.AddScoped<IUserCommand, UserCommandService>();
            services.AddScoped<IProductCommand, ProductCommandService>();
            services.AddScoped<ICategoryCommand, CategoryCommandService>();
            services.AddScoped<IOperationSellCommand, OperationSellCommandService>();
            services.AddScoped<IOperationDisposalCommand, OperationDisposalCommandService>();
            services.AddScoped<IOperationPurchaseCommand, OperationPurchaseCommandService>();
            services.AddScoped<IOperationTransferCommand, OperationTransferCommandService>();
            services.AddScoped<ICustomerCommand, CustomerCommandService>();
            services.AddScoped<ICityCommand, CityCommandService>();
            services.AddScoped<ICountryCommand, CountryCommandService>();
            //query services
            services.AddScoped<IEmployeeQuery, EmployeeQueryService>();
            services.AddScoped<IUserQuery, UserQueryService>();
            services.AddScoped<IProductQuery, ProductQueryService>();
            services.AddScoped<ICategoryQuery, CategoryQueryService>();
            services.AddScoped<IOperationSellQuery, OperationSellQueryService>();
            services.AddScoped<IOperationDisposalQuery, OperationDisposalQueryService>();
            services.AddScoped<IOperationPurchaseQuery, OperationPurchaseQueryService>();
            services.AddScoped<IOperationTransferQuery, OperationTransferQueryService>();
            services.AddScoped<ICustomerQuery, CustomerQueryService>();
            services.AddScoped<ICityQuery, CityQueryService>();
            services.AddScoped<ICountryQuery,CountryQueryService>();

            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly); //assemblys igebs WarehouseManager.Facade.Profiles-dan

            services.AddScopedServices();

            return services;
        }
    }

}

using Microsoft.Extensions.DependencyInjection;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

public static class RepositoryRegistry
{
    public static void AddScopedServices(this IServiceCollection services)
    {
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<IOperationSellRepository, OperationSellRepository>();
        services.AddScoped<IOperationDisposalRepository, OperationDisposalRepository>();
        services.AddScoped<IOperationPurchaseRepository, OperationPurchaseRepository>();
        services.AddScoped<IOperationTransferRepository, OperationTransferRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IContractorRepository, ContractorRepository>();
        services.AddScoped<IPermissionRepository, PermissionRepository>();
        services.AddScoped<ISupplierRepository, SupplierRepository>();
        services.AddScoped<IWarehouseRepository, WarehouseRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
    }
}

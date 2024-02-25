namespace WarehouseManager.Facade.Interfaces.Repositories;

public interface IUnitOfWork
{
    ICategoryRepository CategoryRepository { get; }
    IProductRepository ProductRepository { get; }
    ICityRepository CityRepository { get; }
    ICountryRepository CountryRepository { get; }
    IContractorRepository ContractorRepository { get; }
    ICustomerRepository CustomerRepository { get; }
    IEmployeeRepository EmployeeRepository { get; }
    IOperationRepository OperationRepository { get; }
    IPermissionRepository PermissionRepository { get; }
    ISupplierRepository SupplierRepository { get; }
    IUserRepository UserRepository { get; }
    IWarehouseRepository WarehouseRepository { get; }
    IOperationPurchaseRepository OperationPurchaseRepository { get; }
    IOperationDisposalRepository OperationDisposalRepository { get; }
    IOperationSellRepository OperationSellRepository { get; }
    IOperationTransferRepository OperationTransferRepository { get; }
    IProductCategoryRepository ProductCategoryRepository { get; }

    void BeginTransaction();
    void Commit();
    void Rollback();
    void SaveChanges();
    Task SaveChangesAsync();
}

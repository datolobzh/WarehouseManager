using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private IDbContextTransaction? _transaction;
    private readonly WarehouseDbContext _context;
    private readonly ILogger<UnitOfWork> _logger;
    private readonly Lazy<ICategoryRepository> _categoryRepository;
    private readonly Lazy<IProductRepository> _productRepository;
    private readonly Lazy<ICityRepository> _cityRepository;
    private readonly Lazy<IContractorRepository> _contractorRepository;
    private readonly Lazy<ICountryRepository> _countryRepository;
    private readonly Lazy<ICustomerRepository> _customerRepository;
    private readonly Lazy<IEmployeeRepository> _employeeRepository;
    private readonly Lazy<IOperationRepository> _operationRepository;
    private readonly Lazy<IPermissionRepository> _permissionRepository;
    private readonly Lazy<ISupplierRepository> _supplierRepository;
    private readonly Lazy<IUserRepository> _userRepository;
    private readonly Lazy<IWarehouseRepository> _warehouseRepository;
    private readonly Lazy<IOperationPurchaseRepository> _operationPurchaseRepository;
    private readonly Lazy<IOperationDisposalRepository> _operationDisposalRepository;
    private readonly Lazy<IOperationSellRepository> _operationSellRepository;
    private readonly Lazy<IOperationTransferRepository> _operationTransferRepository;
    private readonly Lazy<IProductCategoryRepository> _productCategoryRepository;

    public UnitOfWork(WarehouseDbContext context, ILogger<UnitOfWork> logger)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(context));
        _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(context));
        _cityRepository = new Lazy<ICityRepository>(() => new CityRepository(context));
        _contractorRepository = new Lazy<IContractorRepository>(() => new ContractorRepository(context));
        _countryRepository = new Lazy<ICountryRepository>(() => new CountryRepository(context));
        _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(context));
        _employeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(context));
        _operationRepository = new Lazy<IOperationRepository>(() => new OperationRepository(context));
        _permissionRepository = new Lazy<IPermissionRepository>(() => new PermissionRepository(context));
        _supplierRepository = new Lazy<ISupplierRepository>(() => new SupplierRepository(context));
        _userRepository = new Lazy<IUserRepository>(() => new UserRepository(context));
        _warehouseRepository = new Lazy<IWarehouseRepository>(() => new WarehouseRepository(context));
        _operationPurchaseRepository = new Lazy<IOperationPurchaseRepository>(() => new OperationPurchaseRepository(context));
        _operationDisposalRepository = new Lazy<IOperationDisposalRepository>(() => new OperationDisposalRepository(context));
        _operationSellRepository = new Lazy<IOperationSellRepository>(() => new OperationSellRepository(context));
        _operationTransferRepository = new Lazy<IOperationTransferRepository>(() => new OperationTransferRepository(context));
        _productCategoryRepository = new Lazy<IProductCategoryRepository>(() => new ProductCategoryRepository(context));
    }

    public ICategoryRepository CategoryRepository => _categoryRepository.Value;
    public IProductRepository ProductRepository => _productRepository.Value;
    public ICityRepository CityRepository => _cityRepository.Value;
    public IContractorRepository ContractorRepository => _contractorRepository.Value;
    public ICountryRepository CountryRepository => _countryRepository.Value;
    public ICustomerRepository CustomerRepository => _customerRepository.Value;
    public IEmployeeRepository EmployeeRepository => _employeeRepository.Value;
    public IOperationRepository OperationRepository => _operationRepository.Value;
    public IPermissionRepository PermissionRepository => _permissionRepository.Value;
    public ISupplierRepository SupplierRepository => _supplierRepository.Value;
    public IUserRepository UserRepository => _userRepository.Value;
    public IWarehouseRepository WarehouseRepository => _warehouseRepository.Value;
    public IOperationPurchaseRepository OperationPurchaseRepository => _operationPurchaseRepository.Value;
    public IOperationDisposalRepository OperationDisposalRepository => _operationDisposalRepository.Value;
    public IOperationSellRepository OperationSellRepository => _operationSellRepository.Value;
    public IOperationTransferRepository OperationTransferRepository => _operationTransferRepository.Value;
    public IProductCategoryRepository ProductCategoryRepository => _productCategoryRepository.Value;

    public void BeginTransaction()
    {
        try
        {
            _transaction = _context.Database.BeginTransaction();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to begin transaction");
            throw;
        }
    }

    public void Commit()
    {
        try
        {
            _transaction?.Commit();
            _transaction?.Dispose();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to commit transaction");
            throw;
        }
    }

    public void Rollback()
    {
        _transaction?.Rollback();
        _transaction?.Dispose();
    }

    public void SaveChanges()
    {
        try
        {
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "DbContext error");
            throw;
        }

    }

    public void Dispose()
    {
        try
        {
            _transaction?.Rollback();
            _transaction?.Dispose();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to rollback transaction");
            throw;
        }
    }

    public async Task SaveChangesAsync()
    {
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "DbContext error");
            throw;
        }
    }
}

using WarehouseManager.API.Models;
using WarehouseManager.DTO;

namespace WarehouseManager.Services.Interfaces.Commands;

public interface ICategoryCommand : ICommandModel<CategoryModel, Category> { }

public interface IEmployeeCommand : ICommandModel<EmployeeModel, Employee> { }

public interface ICityCommand : ICommandModel<CityModel, City> { }

public interface ICountryCommand : ICommandModel<CountryModel, Country> { }

public interface ICustomerCommand : ICommandModel<CustomerModel, Customer> { }

public interface IProductCommand : ICommandModel<ProductModel, Product>
{
    int Insert(ProductModel model, int categoryId);
    void Delete(int productId, int categoryId);
}

public interface IUserCommand : ICommandModel<UserModel, User>
{
    void Activate(int id);
    void Deactivate(int id);
}

public interface IOperationSellCommand : ICommandModel<OperationSellModel, OperationSell> { }

public interface IOperationDisposalCommand : ICommandModel<OperationDisposalModel, OperationDisposal> { }

public interface IOperationPurchaseCommand : ICommandModel<OperationPurchaseModel, OperationPurchase> { }

public interface IOperationTransferCommand : ICommandModel<OperationTransferModel, OperationTransfer> { }

public interface IPermissionCommand : ICommandModel<PermissionModel, Permission> { }

public interface ISupplierCommand : ICommandModel<SupplierModel, Supplier> { }

public interface IWarehouseCommand : ICommandModel<WarehouseModel, Warehouse> { }


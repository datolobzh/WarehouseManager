using WarehouseManager.API.Models;
using WarehouseManager.DTO;

namespace WarehouseManager.Services.Interfaces.Queries;

public interface IEmployeeQuery : IQueryModel<EmployeeModel, Employee> { }

public interface IUserQuery : IQueryModel<UserModel, User> { }

public interface ICategoryQuery : IQueryModel<CategoryModel, Category> { }

public interface ICityQuery : IQueryModel<CityModel, City> { }

public interface ICustomerQuery : IQueryModel<CustomerModel, Customer> { }

public interface ICountryQuery : IQueryModel<CountryModel, Country> { }

public interface IProductQuery : IQueryModel<ProductModel, Product> { }

public interface IOperationQuery : IQueryModel<OperationModel, Operation> { }

public interface ISupplierQuery : IQueryModel<SupplierModel, Supplier> { }

public interface IWareHouseQuery : IQueryModel<WarehouseModel,Warehouse> { }

public interface IOperationSellQuery : IQueryModel<OperationSellModel, OperationSell> { }

public interface IOperationTransferQuery : IQueryModel <OperationTransferModel, OperationTransfer> { }

public interface IOperationPurchaseQuery : IQueryModel<OperationPurchaseModel, OperationPurchase> { }

public interface IOperationDisposalQuery : IQueryModel<OperationDisposalModel, OperationDisposal> { }
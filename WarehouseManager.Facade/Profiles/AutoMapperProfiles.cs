using AutoMapper;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;

namespace WarehouseManager.Facade.Profiles;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Employee, EmployeeModel>();
        CreateMap<EmployeeModel, Employee>();
        CreateMap<User, UserModel>();
        CreateMap<UserModel, User>();
        CreateMap<Category, CategoryModel>();
        CreateMap<CategoryModel, Category>();
        CreateMap<City, CityModel>();
        CreateMap<CityModel, City>();
        CreateMap<Contractor, ContractorModel>();
        CreateMap<ContractorModel, Contractor>();
        CreateMap<Country, CountryModel>();
        CreateMap<CountryModel, Country>();
        CreateMap<Customer, CustomerModel>();
        CreateMap<CustomerModel, Customer>();
        CreateMap<OperationSell, OperationSellModel>();
        CreateMap<OperationSellModel, OperationSell>();
        CreateMap<Product, ProductModel>();
        CreateMap<ProductModel, Product>();
        CreateMap<Supplier, SupplierModel>();
        CreateMap<SupplierModel, Supplier>();
        CreateMap<Warehouse, WarehouseModel>();
        CreateMap<WarehouseModel, Warehouse>();
    }
}

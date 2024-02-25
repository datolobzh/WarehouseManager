using AutoMapper;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.Services.Services;

public class CountryCommandService : BaseCommandService<CountryModel, Country>, ICountryCommand
{
    protected override IRepositoryBase<Country> Repository() => _unitOfWork.CountryRepository;

    public CountryCommandService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override int Insert(CountryModel model) => base.Insert(model);

    public override void Update(int id, CountryModel model) => base.Update(id, model);

    public override int Delete(int id) => base.Delete(id);
}

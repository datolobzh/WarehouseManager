using AutoMapper;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.Services.Services;

public class CityCommandService : BaseCommandService<CityModel, City>, ICityCommand
{
    protected override IRepositoryBase<City> Repository() => _unitOfWork.CityRepository;

    public CityCommandService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override int Delete(int id) => base.Delete(id);

    public override void Update(int id, CityModel model) => base.Update(id, model);

    new public int Insert(CityModel model)
    {
        if (model == null) throw new ArgumentNullException($"User cannot be null.");

        var country = _repository.Set(e => e.Id == model.CountryId).SingleOrDefault()
            ?? throw new ArgumentNullException($"Relevant country not found.");

        var city = _mapper.Map<City>(model);

        _repository.Insert(city);
        _unitOfWork.SaveChanges();

        return city.Id;
    }

}

using AutoMapper;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.Services.Services;

public class WareHouseCommandService : BaseCommandService<WarehouseModel, Warehouse>, IWarehouseCommand
{
    public WareHouseCommandService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    protected override IRepositoryBase<Warehouse> Repository() => _unitOfWork.WarehouseRepository;

    public override int Delete(int id) => base.Delete(id);

    public override void Update(int id, WarehouseModel model) => base.Update(id, model);

    public override int Insert(WarehouseModel model) => base.Insert(model);
}

using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.API.Models;

public sealed class OperationDisposalModel : OperationModel, IEntityModel
{
    public string? Comment { get; set; }
}


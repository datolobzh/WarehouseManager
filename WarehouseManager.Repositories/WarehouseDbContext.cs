using Microsoft.EntityFrameworkCore;
using WarehouseManager.DTO;

namespace WarehouseManager.Repositories;

public class WarehouseDbContext : DbContext
{
    public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Operation> Operations { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<Contractor> Contractors { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<UserPermission> UserPermissions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OperationPurchase>()
            .ToTable("PurchaseOperations")
            .HasBaseType<Operation>();

        modelBuilder.Entity<OperationTransfer>()
            .ToTable("TransferOperations")
            .HasBaseType<Operation>();

        modelBuilder.Entity<OperationTransfer>()
            .Ignore(o => o.WarehouseTo);

        modelBuilder.Entity<OperationSell>()
            .ToTable("SellOperations")
            .HasBaseType<Operation>();

        modelBuilder.Entity<OperationDisposal>()
            .ToTable("DisposalOperations")
            .HasBaseType<Operation>();

        modelBuilder.Entity<Customer>()
            .HasBaseType<Contractor>();

        modelBuilder.Entity<Supplier>()
            .HasBaseType<Contractor>();

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(WarehouseDbContext).Assembly);
    }
}
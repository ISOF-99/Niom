using Microsoft.EntityFrameworkCore;

using Turin.Entity;
using Turin.Entityes;

namespace Turin.Context
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<AdressEntity> Addresses { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ProductsEntity> Products { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
    }
}

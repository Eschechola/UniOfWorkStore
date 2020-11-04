using Store.UoW.Infra.Mapping;
using Store.UoW.Domain.Entities;
using Store.UoW.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Store.UoW.Infra.Context
{
    public class StoreContext : DbContext, IUnitOfWork
    {
        public StoreContext()
        { }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        { }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-652APCE\SQLEXPRESS;Initial Catalog=UoW_STORE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductMap());
        }

        public bool Commit()
        {
            return base.SaveChanges() > 0;
        }
    }
}

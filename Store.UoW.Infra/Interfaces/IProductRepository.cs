using Store.UoW.Domain.Entities;
using Store.UoW.Domain.Interfaces;
using System.Collections.Generic;

namespace Store.UoW.Infra.Interfaces
{
    public interface IProductRepository
    {
        IUnitOfWork UnitOfWork { get; }

        Product Create(Product product);
        IList<Product> GetByName(string name);
    }
}

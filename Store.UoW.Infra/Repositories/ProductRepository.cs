using System.Linq;
using Store.UoW.Domain.Entities;
using Store.UoW.Domain.Interfaces;
using Store.UoW.Infra.Context;
using Store.UoW.Infra.Interfaces;
using System.Collections.Generic;

namespace Store.UoW.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public Product Create(Product product)
        {
            _context.Products.Add(product);
            return product;
        }

        public IList<Product> GetByName(string name)
        {
            name = name.ToLower();

            return _context.Products
                           .Where(x => x.Name.ToLower() == name)
                           .ToList();
        }
    }
}

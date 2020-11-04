using System;
using Store.UoW.Domain.Entities;
using Store.UoW.Infra.Context;
using Store.UoW.Infra.Interfaces;
using Store.UoW.Infra.Repositories;

namespace Store.UoW.App
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreContext _storeContext = new StoreContext();
            IProductRepository _productRepository = new ProductRepository(_storeContext);

            var product = new Product
            {
                Name = "Playstation 5",
                Price = 5000,
                Stock = 10
            };

            var productExists = _productRepository.GetByName("Playstation 5");

            if (productExists.Count > 0)
            {
                Console.WriteLine("Já existe um produto com esse nome na base de dados.");
            }
            else
            {
                _productRepository.Create(product);
                _productRepository.UnitOfWork.Commit();

                Console.WriteLine("O produto {0} foi inserido com sucesso na base de dados.", product.Name);
            }


            Console.WriteLine("\n\n");


            var product2 = new Product
            {
                Name = "Playstation 5",
                Price = 5000,
                Stock = 10
            };

            var product2Exists = _productRepository.GetByName("Playstation 5");

            if (product2Exists.Count > 0)
            {
                Console.WriteLine("Já existe um produto com esse nome na base de dados.");
            }
            else
            {
                _productRepository.Create(product2);
                _productRepository.UnitOfWork.Commit();

                Console.WriteLine("O produto {0} foi inserido com sucesso na base de dados.", product2.Name);
            }
                
            Console.ReadKey();
        }
    }
}

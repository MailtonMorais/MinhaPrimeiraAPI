using MinhaPrimeiraApi.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaPrimeiraApi.Domain.Interface;
using MinhaPrimeiraApi.Domain.Model;

namespace MinhaPrimeiraApi.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IBancoDeDados _db;

        public ProductRepository(IBancoDeDados db)
        {
            _db = db;
        } 

        public void CreateProduct(Product product)
            => _db.CreateProduct(product);

        public List<Product> GetAllProducts()
            => _db.GetAllProducts();

        public Product GetByIdProduct(int id)
            => _db.GetByIdProduct(id);

    }
   
}

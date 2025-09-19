using MinhaPrimeiraApi.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Domain.Interface
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);

        List<Product> GetAllProducts();

        Product GetByIdProduct(int id);

    }
}

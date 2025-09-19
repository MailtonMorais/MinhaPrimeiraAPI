using MinhaPrimeiraApi.Aplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Aplication.Interface
{
    public interface IProductService
    {
        void CreateProduct(ProductDto product);
        List<ProductDto> GetAll();
        ProductDto GetById(int id);
    }
}

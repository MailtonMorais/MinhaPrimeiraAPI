using MinhaPrimeiraApi.Aplication.Dto;
using MinhaPrimeiraApi.Aplication.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaPrimeiraApi.Domain.Model;
using MinhaPrimeiraApi.Domain.Interface;
using System.Runtime.CompilerServices;

namespace MinhaPrimeiraApi.Aplication.Service
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void CreateProduct(ProductDto product)
        {
            var newProduct = new Product(product.Id, product.Name, product.Price, product.Quantity);
            _productRepository.CreateProduct(newProduct);
        }

        /*
         * modificador de acesso : public
         * retorno : List<ProductDto>
         * nome : GetAll
         * paramentros : nenhum
         * 
         */

        public List<ProductDto> GetAll()
        {
            var products = _productRepository.GetAllProducts();

            var productsDto = new List<ProductDto>();

            foreach (var product in products)
            {
                var productDtp = new ProductDto(product.Id, product.Name, product.Price, product.Quantity);
                productsDto.Add(productDtp);

            }
            return productsDto;
        }
        public ProductDto GetById(int id)
        {
            var product = _productRepository.GetByIdProduct(id);
            if (product == null) return null;
            var productDto = new ProductDto(product.Id, product.Name, product.Price, product.Quantity);
            return productDto;
        }

    }
}

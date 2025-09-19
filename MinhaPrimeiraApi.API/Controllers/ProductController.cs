using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Aplication.Dto;
using MinhaPrimeiraApi.Aplication.Interface;
using MinhaPrimeiraApi.Domain.Model;

namespace MinhaPrimeiraApi.API.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class ProductController : ControllerBase
        {
            private readonly IProductService _productService;
            public ProductController(IProductService productService)
            {
                _productService = productService;
            }


            [HttpPost]
            public IActionResult Gravar(ProductDto productdto)
            {
                if (!ModelState.IsValid)
                    return BadRequest("Produto inválido");
                _productService.CreateProduct(productdto);
                return Ok("Produto gravado com sucesso");
            }


            [HttpGet]
            public IActionResult GetAll()
            {
                var products = _productService.GetAll();
                if (products == null || products.Count == 0)
                    return NotFound("Nenhum produto encontrado");
                return Ok(products);
            }

            [HttpGet("{id:int}")]
            public IActionResult GetById(int id)
            {
                var product = _productService.GetById(id);
                if (product == null)
                    return NotFound("Produto não encontrado");
                return Ok(product);
        }

    }
}

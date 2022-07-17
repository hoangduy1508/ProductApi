using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using ProductApi.Services;
using ProductApi.Entities;
using AutoMapper;
using System.Text.Json;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductController(
            IProductRepository productRepository,
            IMapper mapper
            )
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {

            var productEntities = await _productRepository.GetProductsAsync();

            return Ok(_mapper.Map<IEnumerable<ProductDto>>(productEntities));
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProductById(int id)
        {
            var productEntitie = await _productRepository.GetProductByIdAsync(id);

            return Ok(_mapper.Map<ProductDto>(productEntitie));
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<ProductDto>>> CreateProduct(
            ProductCreationDto product
            )
        {


            var finalProduct = _mapper.Map<Entities.Product>(product);

            await _productRepository.AddProductAsync(finalProduct);

            await _productRepository.SaveChangesAsync();

            var createProductReturn = _mapper.Map<Models.ProductDto>(finalProduct);

            return CreatedAtRoute("GetProduct",
                new
                {
                    Id = createProductReturn.Id,
                },
                createProductReturn);
        }
    }
}

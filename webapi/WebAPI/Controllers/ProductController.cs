using KCMS.Interfaces;
using KCMS.Model;
using KCMS.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<List<Product>> Get() => _productService.Get();

        [HttpGet("{id:length(24)}")]
        public ActionResult<Product> Get(string id) => _productService.Get(id);

        [HttpPost]
        public ActionResult<Product> Create(Product product) => _productService.Create(product);

        [HttpPut("{id:length(24)}")]
        public ActionResult<Product> Update(string id, Product product)
        {
            var productExist = _productService.Get(id);

            if (productExist == null)
                return NotFound();

            _productService.Update(id, product);

            return product;
        }

        [HttpDelete("{id:length(24)}")]
        public ActionResult Delete(string id)
        {
            var productExist = _productService.Get(id);

            if (productExist == null)
                return NotFound();

            _productService.Remove(productExist);

            return Ok();
        }
    }
}

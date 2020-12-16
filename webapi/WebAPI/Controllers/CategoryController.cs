using KCMS.Interfaces;
using KCMS.Model;
using KCMS.Services;
using KCMS.ViewModel;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System.Collections;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get() => _categoryService.Get();

        [HttpGet("{id:length(24)}/products")]
        public ActionResult<List<Product>> GetProducts(string id) => _categoryService.GetProducts(id);

        [HttpGet("{id:length(24)}")]
        public ActionResult<Category> Get(string id)
        {
            var category = _categoryService.Get(id);

            if (category == null)
                return NotFound();

            return category;
        }

        [HttpPost]
        public ActionResult<Category> Create(CategoryViewModel category) => _categoryService.Create(new Category { Name = category.Name, Description = category.Description });

        [HttpPut("{id:length(24)}")]
        public ActionResult Update(string id, Category category)
        {
            var cat = _categoryService.Get(id);

            if (cat == null)
                return NotFound();

            _categoryService.Update(id, category);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public ActionResult Delete(string id)
        {
            var category = _categoryService.Get(id);

            if (category == null)
                return NotFound();

            _categoryService.Remove(id);

            return NoContent();
        }
    }
}

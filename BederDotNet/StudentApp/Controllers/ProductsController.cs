using Microsoft.AspNetCore.Mvc;
using StudentApp.Data;
using StudentApp.Data.Models;
using StudentApp.Data.VM;
using StudentApp.Services;

namespace StudentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private OnlineShop _onlineshop;
        public ProductsController(OnlineShop onlineshop)
        {
            _onlineshop = onlineshop;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_onlineshop.GetAllProducts());
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_onlineshop.GetProductById(id));
        }


        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductVM productVM)
        {
            return Created("", _onlineshop.AddProduct(productVM));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct([FromBody] ProductVM productVM, int id)
        {
            var shop = _onlineshop.UpdateProduct(productVM, id);

            return Ok($"Product with id = {id} was updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            _onlineshop.DeleteProductById(id);

            return Ok($"Product with id {id} deleted");
        }


    }
}

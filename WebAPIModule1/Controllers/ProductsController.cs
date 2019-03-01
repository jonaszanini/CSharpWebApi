using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIModule1.Module;

namespace WebAPIModule1.Controllers
{
    [Route("api/Products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        static List<Product> _products = new List<Product>()
        {
            new Product () {ProductID = 0, ProductName = "LapTop", ProductPrice = "100" },
            new Product () {ProductID = 1, ProductName = "Mouse", ProductPrice = "20" },
            new Product () {ProductID = 3, ProductName = "Monitor", ProductPrice = "50" }

        };

        public IActionResult Get()
        {
            return Ok(_products);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            _products.Add(product);
            
            return StatusCode(StatusCodes.Status201Created);
            
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product product)
        {
            _products[id] = product;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _products.RemoveAt(id);
        }
    }
}
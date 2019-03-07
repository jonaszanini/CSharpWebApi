using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIModule1.Module;

namespace WebAPIModule1.Controllers
{
    [Produces("application/json")]
    [Route("api/Customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        static List<Customer> _customer = new List<Customer>
        {
            new Customer() {Id = "01", Name = "João Santos", Email = "joao.santos@gmail.com", Phone = "99277-4453"},
            new Customer() {Id = "02", Name = "Jose Silva", Email = "jose.silva@gmail.com", Phone = "98364-8890"},
            new Customer() {Id = "03", Name = "Maria Jose", Email = "maria.jose@gmail.com", Phone = "97843-2366"}
        };

        [HttpGet]
        public IEnumerable<Customer> GetCustomer()
        {
            return _customer;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customer.Add(customer);
                return Ok();
            }
            return BadRequest(ModelState);
            
        }
    }
}
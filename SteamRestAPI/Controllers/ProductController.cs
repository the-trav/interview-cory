using BusinessLogic;
using BusinessLogic.Interface;
using DataLayer.DTO;
using DataLayer.Interface;
using DataLayer.Queries.Products;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SteamRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {     
        [HttpGet("{productCode}/{numberOfUnits}")]
        public IActionResult GetOptimizedPackaging(string productCode, int numberOfUnits)
        {
            var theProduct = new GetProductByCode(productCode).Get();
            var optimizedPackaging = new PackageSodaBottle(theProduct).Optimize(numberOfUnits);
            return Ok(optimizedPackaging);
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            var allProducts = new GetAllProducts().Get();
            return Ok(allProducts);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var theProduct = new GetProductById(id).Get();
            return Ok(theProduct);
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post([FromBody] Product value)
        {
            var newProduct = new CreateProduct().Create(value);
            return Ok(newProduct);
        }

        // PUT api/<ProductController>
        [HttpPut()]
        public IActionResult Put([FromBody] Product value)
        {
            var updatedProduct = new UpdateProduct().Update(value);
            return Ok(updatedProduct);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleteResult = new DeleteProduct().Delete(id);
            return Ok(deleteResult);
        }
    }
}

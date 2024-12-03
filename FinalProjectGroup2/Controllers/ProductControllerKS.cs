using FinalProjectGroup2.Data;
using FinalProjectGroup2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectGroup2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductControllerKS : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductControllerKS(AppDbContext context)
        {
            _context = context;
        }
        //GET *
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductKS>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }
        //GET by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _context.Products.SingleOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return StatusCode(404, $"Sorry you product with the id: {id} was not found.");
            }
            return StatusCode(200, product);
        }
        //POST 
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductKS product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ProductKS newProduct = new ProductKS
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price,
                        Category = product.Category,
                        ImageUrl = product.ImageUrl
                    };
                    _context.Products.Add(newProduct);
                    await _context.SaveChangesAsync();
                    return StatusCode(201, "Product Created");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            return StatusCode(400, "Could not add product.");
        }
        //UPDATE 
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductKS product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var prod = await _context.Products.FindAsync(id);
                    if (prod == null)
                    {
                        return StatusCode(404, $"Product with the id: {id} was not found.");
                    }
                    prod.Name = product.Name;
                    prod.Description = product.Description;
                    prod.Price = product.Price;
                    prod.Category = product.Category;
                    prod.ImageUrl = product.ImageUrl;
                    _context.Products.Update(prod);
                    await _context.SaveChangesAsync();
                    return StatusCode(200, prod.ToString());
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            return StatusCode(400, "Could not update product.");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return StatusCode(404, $"Product with the id: {id} could not be found.");
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return StatusCode(200, $"Product with the id: {id} was deleted.");
        }
    }
}


using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IMapper _map;
    private readonly Database _db;
    public ProductController(Database db, IMapper map)
    {
        _db = db;
        _map = map;
    }
    [HttpGet]
    public IActionResult GetProduct()
    {
        return Ok(_db.Products.ToList());
    }

    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        Product productNew = _map.Map<Product>(product);
        _db.Products.Add(productNew);
        _db.SaveChanges();
        return Ok();
    }

    // [HttpPut]
    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, Product product)
    {
        Product prod = _db.Products.Find(id);
        if (prod == null)
        {
            return NotFound($"id {id} not found");
        }
        prod.ProductName = product.ProductName;
        prod.Description = product.Description;
        prod.Price = product.Price;
        _db.SaveChanges();
        return Ok(prod);
    }

    // [HttpDelete]
    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var product = _db.Products.Find(id);
        if (product == null)
        {
            return NotFound($"Product with ID {id} not found");
        }

        _db.Products.Remove(product);
        _db.SaveChanges();

        return Ok(product);
    }
}
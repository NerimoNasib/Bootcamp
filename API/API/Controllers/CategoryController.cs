using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly IMapper _map;
    private readonly Database _db;
    public CategoryController(Database db, IMapper map)
    {
        _db = db;
        _map = map;
    }
    [HttpGet]
    public IActionResult GetCategory()
    {
        return Ok(_db.Categories.ToList());
    }

    [HttpPost]
    public IActionResult CreateCategory(CategoryDTO category)
    {
        Category categoryNew = _map.Map<Category>(category);
        _db.Categories.Add(categoryNew);
        _db.SaveChanges();
        return Ok();
    }
    
    // //Without AutoMapper
    // public IActionResult CreateCategory(CategoryDTO category)
    // {
    //     Category categoryNew = new()
    //     {
    //         CategoryName = category.CategoryName,
    //         Description = category.Description,
    //     };
    //     _db.Categories.Add(categoryNew);
    //     _db.SaveChanges();
    //     return Ok();
    // }

    // [HttpPut]
    [HttpPut("{id}")]
    public IActionResult UpdateCategory(int id, Category category)
    {
        Category cat = _db.Categories.Find(id);
        if (cat == null)
        {
            return NotFound($"id {id} not found");
        }
        cat.CategoryName = category.CategoryName;
        cat.Description = category.Description;
        _db.SaveChanges();
        return Ok(cat);
    }

    // [HttpDelete]
    [HttpDelete("{id}")]
    public IActionResult DeleteCategory(int id)
    {
        var category = _db.Categories.Find(id);
        if (category == null)
        {
            return NotFound($"Category with ID {id} not found");
        }

        _db.Categories.Remove(category);
        _db.SaveChanges();

        return Ok(category);
    }

}
using System.Data.Common;
using Microsoft.AspNetCore.Mvc;

public class CategoryController : Controller{
    private readonly Database _db;
    public CategoryController (Database db){
        _db = db;
    }

    public IActionResult Index(){
        List<Category> categories = _db.Categories.ToList();
        return View(categories);
    }

    public IActionResult Create(){
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Category category){
        _db.Categories.Add(category);
        await _db.SaveChangesAsync();
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int? id){
        if(id == null || id == 0) return NotFound();
        Category category = _db.Categories.Find(id);
        return View(category);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Category category){
        Category existingCategory = _db.Categories.Find(category.CategoryID);
        existingCategory.CategoryName = category.CategoryName;
        existingCategory.Description = category.Description;
        await _db.SaveChangesAsync();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(){
        return View();
    }
}
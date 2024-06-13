using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

class Program
{
    static void Main()
    {
        //Read
        // using (Northwind db = new())
        // {
        //     bool isActive = db.Database.CanConnect();
        //     System.Console.WriteLine(isActive);
        //     List<Category> categories = db.Categories.ToList();
        //     foreach (var category in categories)
        //     {
        //         System.Console.WriteLine(category.CategoryName);
        //     }
        // }

        //Read all
        // using (Northwind db = new())
        // {
        //     string filter = "Beverages";
        //     IQueryable<Category> category = db.Categories.Where(data => data.CategoryName.Contains(filter));
        //     //Category? result = db.Categories.Where(data => data.CategoryName.Contains(filter)).FirstOrDefault();
        //     foreach (var item in category)
        //     {
        //         Console.WriteLine(item.Description);
        //     }
        // }

        //Create
        // using (Northwind db = new())
        // {
        //     Category category = new();
        //     category.CategoryName = "Durian";
        //     category.Description = "Durian gunung pati";
        //     //Add to database but it has not been written
        //     db.Categories.Add(category);
        //     //Write the changes to the database
        //     db.SaveChanges();
        // }

        //Create with user input
        using (Northwind db = new())
        {
            bool isActive = true;
            while (isActive == true)
            {
                //Create a new instance whenever the program loops back!
                Category category = new Category();
                Console.WriteLine("Enter category: ");
                category.CategoryName = Console.ReadLine();
                Console.WriteLine("Enter description: ");
                category.Description = Console.ReadLine();
                Console.WriteLine("Do you want to continue adding? ");
                string question = Console.ReadLine();
                if (question == "y")
                {
                    db.Categories.Add(category);
                    isActive = true;
                }
                else
                {
                    isActive = false;
                    db.Categories.Add(category);
                    db.SaveChanges();
                    Console.WriteLine("Changes saved!");
                }
            }
        }

        // //Update
        // using (Northwind db = new())
        // {
        //     Category? category = db.Categories.Where(data => data.CategoryName == "Iwak").FirstOrDefault();
        //     category.Description = "Iwak Shiroko";
        //     db.SaveChanges();

        //     //using ID search!
        //     Category? category = db.Categories.Find(10);
        //     category.Description = "Iwak Shiroko";
        //     db.SaveChanges();
        // }

        //Delete
        // using (Northwind db = new())
        // {
        //     Category? category = db.Categories.Where(data => data.CategoryName == "Iwak").FirstOrDefault();
        //     db.Categories.Remove(category);
        //     db.SaveChanges();
        // }
    }
}
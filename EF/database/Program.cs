internal class Program
{
    static void Main(string[] args)
    {
        // Create
        using (Database db = new())
        {
            Student student = new();
            student.StudentName = "Shiroko Iwak";
            student.Description = "Iwak";
            //Add to database but it has not been written
            db.Students.Add(student);
            //Write the changes to the database
            db.SaveChanges();

            // School school = new School();
            // school.SchoolName = "Millenium";
            // school.Description = "";
            // school.StudentID = 6;
            // //Add to database but it has not been written
            // db.Schools.Add(school);
            // //Write the changes to the database
            // db.SaveChanges();
        }

        // using (Database db = new())
        // {
        //         Student? student = db.Students.Find(4);
        //         student.StudentName = "Ayane";
        //         student.Description = "Nerd";
        //         student.SchoolID = 1;
        //         db.SaveChanges();
        // }
    }
}
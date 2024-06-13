internal class Program
{
    public static void Main()
    {
        Console.WriteLine("/1.Create/2.Update/");
        string option = Console.ReadLine();

        if (option == "1")
        {
            CreateData();
        }
        else if (option == "2")
        {
            UpdateData();
        }
        else
        {
            Console.WriteLine("Invalid option");
        }
    }

    public static void CreateData()
    {
        Console.WriteLine("Creating data");
        using (Database db = new Database())
        {
            bool isActive = true;
            Console.WriteLine("1.School/2.Student");
            string option = Console.ReadLine();

            if (option == "1")
            {
                ReadSchoolData();
                Console.WriteLine("Creating data for school");
                while (isActive)
                {
                    School school = new School();
                    Console.WriteLine("Enter school: ");
                    school.SchoolName = Console.ReadLine();
                    Console.WriteLine($"Entered '{school.SchoolName}'");
                    Console.WriteLine("Enter description: ");
                    school.Description = Console.ReadLine();
                    Console.WriteLine($"Entered '{school.Description}'");
                    db.Schools.Add(school);
                    Console.WriteLine("Do you want to keep adding? (y/n)");
                    string add = Console.ReadLine();
                    isActive = add.ToLower() != "n";
                }
            }
            else if (option == "2")
            {
                ReadStudentData();
                Console.WriteLine("Creating data for student");
                while (isActive)
                {
                    Student student = new Student();
                    Console.WriteLine("Enter student's name: ");
                    student.StudentName = Console.ReadLine();
                    Console.WriteLine($"Entered '{student.StudentName}'");
                    Console.WriteLine("Enter student's description: ");
                    student.Description = Console.ReadLine();
                    Console.WriteLine($"Entered '{student.Description}'");
                    Console.WriteLine("Enter school's ID: ");
                    student.SchoolID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Entered '{student.SchoolID}'");
                    db.Students.Add(student);
                    Console.WriteLine("Do you want to keep adding? (y/n)");
                    string add = Console.ReadLine();
                    isActive = add.ToLower() != "n";
                }
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            db.SaveChanges();
        }
    }

    public static void UpdateData()
    {
        using (Database db = new Database())
        {
            Console.WriteLine("Enter student ID to update: ");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Student student = db.Students.Find(studentId);
            if (student != null)
            {
                Console.WriteLine("Enter new student's name: ");
                student.StudentName = Console.ReadLine();
                Console.WriteLine($"Entered '{student.StudentName}'");
                Console.WriteLine("Enter new student's description: ");
                student.Description = Console.ReadLine();
                Console.WriteLine($"Entered '{student.Description}'");
                Console.WriteLine("Enter new school's ID: ");
                student.SchoolID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Entered '{student.SchoolID}'");
                db.SaveChanges();
                Console.WriteLine("Student updated successfully");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }
    }

    public static void ReadStudentData()
    {
        using (Database db = new())
        {
            List<Student> students = db.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.StudentName}\nDesc: {student.Description}\nID: {student.StudentID}");
            }
        }
    }
    public static void ReadSchoolData()
    {
        using (Database db = new())
        {
            List<School> schools = db.Schools.ToList();
            foreach (var school in schools)
            {
                Console.WriteLine($"School: {school.SchoolName}\nDesc: {school.Description}\nID: {school.SchoolID}");
            }
        }
    }
}
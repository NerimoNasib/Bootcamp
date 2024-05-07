using System.Numerics;
using System.Runtime.InteropServices;

public class Program{
    public static void Main(){
        // Console.WriteLine("What is your name? ");
        // string name = Console.ReadLine();
        // Console.WriteLine("What is your current job ?");
        // string occupation = Console.ReadLine();
        // Console.WriteLine("Where do you live?");
        // string city = Console.ReadLine();
        // Console.WriteLine("What is your salary? ");
        // int salary = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("What is your working exp.? ");
        // int experience = Convert.ToInt32(Console.ReadLine());
        Employee employeeA = new Employee("Bob", "Homeless", "Detroit", 0, 0);
        Employee employeeB = new Employee("John", "Homeless", "Detroit", 10, 10);
        
        employeeA.PrintName();
        employeeA.PrintOccupation();
        employeeA.PrintCity();
        employeeA.PrintSalary();
        employeeA.PrintExperience();
        Console.WriteLine("\n");
        employeeB.PrintName();
        employeeB.PrintOccupation();
        employeeB.PrintCity();
        employeeB.PrintSalary();
        employeeB.PrintExperience();
    }
}

public class Employee{
    public string name;
    public string occupation;
    public string city;
    public int salary;
    public int experience;

    public Employee(string name, string occupation, string city, int salary, int experience){
        this.name = name;
        this.occupation = occupation;
        this.city = city;
        this.salary = salary;
        this.experience = experience;
    }
    
    public void PrintName(){
        Console.WriteLine("Hello My name is " + name);
    }

    public void PrintOccupation(){
        Console.WriteLine("Current job: " + occupation);
    }

    public void PrintCity(){
        Console.WriteLine("City: " + city);
    }

    public void PrintSalary(){
        Console.WriteLine("Salary: " + salary);
    }

    public void PrintExperience(){
        Console.WriteLine("Current experience: " + experience + " years");
    }
}
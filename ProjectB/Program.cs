public class Employee{
    public string name;
    public string occupation;
    public string city;
    public int salary;
    public int experience;
    

    public void printName(){
        Console.WriteLine("Input nama: ");
        name = Console.ReadLine();
        Console.WriteLine("Aku seorang " + name);
    }

    public void printOccupation(){
        Console.WriteLine("Input pekerjaan: ");
        occupation = Console.ReadLine();
        Console.WriteLine("Pekerjaan ku " + occupation);

    }

    public void printCity(){
        Console.WriteLine("Input kota: ");
        city = Console.ReadLine();
        Console.WriteLine("Aku tinggal di " + city);
    }

    public void printSalary(){
        Console.WriteLine("Input gaji: ");
        int salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Gaji ku Rp." + salary);
    }

    public void printExperience(){
        Console.WriteLine("Input pengalaman: ");
        int experience = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Telah bekerja selama " + experience + " Tahun");
    }
}

public class Program{
    public static void Main(){
        Employee emp = new Employee();
        emp.printName();
        emp.printOccupation();
        emp.printCity();
        emp.printSalary();
        emp.printExperience();
    }
}
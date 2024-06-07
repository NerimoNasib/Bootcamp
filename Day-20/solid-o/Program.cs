internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
interface IShape{
    public double CalculateArea();

}

class Rectangle : IShape{
    public double Width {get; set;}
    public double Height {get; set;}
    public double CalculateArea(){
        return Width * Height;
    }
}

class Circle: IShape{
    public double Radius {get; set;}
    public double CalculateArea(){
        return Radius * Radius * Math.PI;
    }
}

class Triangle: IShape{
    public double Width {get; set;}
    public double Height {get; set;}
    public double CalculateArea(){
        return 0.5 * Width * Height;
    }
}

class PrintShape{
    public void PrintShapeResult(IShape shape){
        var result = shape.CalculateArea();
        Console.WriteLine(result);
    }
}
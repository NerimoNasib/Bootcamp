internal class Program
{
    private static void Main(string[] args)
    {
        Box box1 = new Box(4, 4);
        Box box2 = new Box(5, 7);

        Box result = box1 + box2;
        System.Console.WriteLine(result.Length);
    }

    public class Box
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Box(int length, int width)
        {
            Width = width;
            Length = length;
        }

        public static Box operator +(Box b1, Box b2)
        {
            int length = b1.Length + b2.Length;
            int width = b1.Width + b2.Width;
            return new Box(length, width);
        }
    }
}

public class GenericClass<T1,T2,T3> {
    public void Waduh(T1 a, T2 b, T3 c){
        System.Console.WriteLine($"Siapa anda? {a}");
        System.Console.WriteLine($"Berapa uang anda? Rp. {b}");
        System.Console.WriteLine($"Apakah anda manusia? {c}");
    }
}

class Program{
    static void Main(){
        GenericClass<string, int, bool> waduh = new GenericClass<string, int, bool>{};
        waduh.Waduh("Waduh", 9000, true);
    }
}
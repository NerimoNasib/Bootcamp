using System;

public interface IHeavyweightService
{
    void PerformOperation();
}

public class HeavyweightService : IHeavyweightService
{
    public HeavyweightService()
    {
        Console.WriteLine("HeavyweightService initialized.");
    }

    public void PerformOperation()
    {
        Console.WriteLine("Operation performed by HeavyweightService.");
    }
}

public class HeavyweightServiceProxy : IHeavyweightService
{
    private readonly Lazy<IHeavyweightService> _service;

    public HeavyweightServiceProxy()
    {
        _service = new Lazy<IHeavyweightService>(() => new HeavyweightService());
    }

    public void PerformOperation()
    {
        _service.Value.PerformOperation();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IHeavyweightService service = new HeavyweightServiceProxy();
        // The service is not yet created
        Console.WriteLine("Proxy created.");

        // The service will be created here
        service.PerformOperation();

        // The service is already created and can be used again
        service.PerformOperation();
    }
}

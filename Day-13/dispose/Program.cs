class Program{
    static void Main(){

    }
}

public class Car : IDisposable{
    public List<int> totalCars;
    public List<object> allCars;

    public ExternalResource externalResource;
    private bool disposed = false;
    public void Dispose(){
        Dispose (true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing){
        if (!disposed){
            if (disposing){
                totalCars = null;
                allCars = null;
            }
            disposed = true;
        }
    }

    ~Car(){
        Dispose(disposing: false);
    }
}

public class ExternalResource{
    
}
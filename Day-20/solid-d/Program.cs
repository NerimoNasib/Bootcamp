internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}
interface IDevice{
    public void TurnOn();
}

public class LightBulb{
    public void TurnOn{
        //turn on the bulb
    }
}

public class DesktopPC : IDevice{
    public void TurnOn{

    }
}

public class Switch{
    private IDevice _device;

    public Switch(IDevice device){
        _device = device;
    }

    public void Operate(){
        _device.TurnOn();
    }
}
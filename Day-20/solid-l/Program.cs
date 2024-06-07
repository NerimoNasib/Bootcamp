internal class Program
{
    private static void Main(string[] args)
    {

    }
}

interface IFlying{
    void Fly(){

    }
}

class Bird{
    public void HaveSparrow(){

    }
}

class Ostrich : Bird{
    void HaveSparrow(){
        
    }
}

class Eagle : Bird, IFlying{
    void Fly(){

    }
    void HaveSparrow(){

    }
}


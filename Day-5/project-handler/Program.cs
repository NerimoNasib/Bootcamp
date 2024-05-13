using System;

public delegate void SusHandle(object sender, EventArgs e);

public class Sus{
    public event SusHandle SusChecked;

    public void OnSus(){
        if (SusChecked != null){
            SusChecked(this, EventArgs.Empty);
        }
        else{
            System.Console.WriteLine("Not sus");
        }
    }
}

public class Meeting{
    public void HandleSussy(object sender, EventArgs e){
        Console.WriteLine("SUS DETECTED");
    }
}

public class Program{
    public static void Main(){
        Meeting meet = new Meeting();
        Sus sus = new Sus();
        System.Console.WriteLine("Are you sus (yes/no)?");
        string impostorcheck = Console.ReadLine();
        if(impostorcheck == "yes"){
            sus.SusChecked += meet.HandleSussy;
            sus.OnSus();
            System.Console.WriteLine("Do you want to rebuke the allegation (yes/no)?");
            string rebuke = Console.ReadLine();
            if (rebuke == "yes"){
                sus.SusChecked -= meet.HandleSussy;
                sus.OnSus();
            }
            else{
                sus.OnSus();
            }
        }
        else{
            sus.SusChecked -= meet.HandleSussy;
            sus.OnSus();
        }
    }
}

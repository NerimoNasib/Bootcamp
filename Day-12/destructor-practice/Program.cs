using System;
using System.Diagnostics;

class Program{
    static void Main(){
        InstanceCreator();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        System.Console.WriteLine("Wait for the next order");
    }

    static void InstanceCreator(){
        Child child = new();
    }
}

public class GrandParent{
    ~GrandParent(){
        System.Console.WriteLine("Grandparent Eliminated");
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}
public class Parent : GrandParent{
    ~Parent(){
        System.Console.WriteLine("Parent Eliminated");
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}

public class Child : Parent{
    ~Child(){
        System.Console.WriteLine("Child Eliminated");
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}
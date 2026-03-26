namespace Events;

internal class Program
{
    //summary:
    //purpose: Prints “Method Invoked” and executes when process is completed.
    //return type: void
    static void Bl_ProcessCompleted()
    {
        Console.WriteLine("Method Invoked");
    }

    static void Main()
    {
        ProcessBusinessLogic b1 = new ProcessBusinessLogic();

        b1.ProcessCompleted += Bl_ProcessCompleted;

        b1.StartProcess();
    }
}
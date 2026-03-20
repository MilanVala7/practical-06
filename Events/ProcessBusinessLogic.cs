namespace Events;

internal class ProcessBusinessLogic
{
    public event Action ProcessCompleted;

    // summary:
    // Purpose: Starts the process and triggers event.
    // Return Type: void
    public void StartProcess()
    {
        Console.WriteLine("Process Started");

        OnProcessCompleted();
    }


    //summary:
    //purpose: Invokes the ProcessCompleted event.
    //return type: void
    protected virtual void OnProcessCompleted()
    {
        //if ProcessCompleted is not null then call delegate
        ProcessCompleted?.Invoke();
    }
}

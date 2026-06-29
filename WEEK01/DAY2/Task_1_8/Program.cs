//Task 1.8 Use #define TRIAL_VERSION + #if/#else/#endif to switch a printed message;
//use #region to group a class into Fields/Properties/Constructors/Methods.
//✓ Done when: toggling the #define changes the output.

#define TRIAL_VERSION

class Program
{

    #region Fields/Properties
    private static string appName = "Task1.8";
    internal int _count;
    #endregion

    #region Constructor
    public Program(int count)
    {
        _count = count;
    }
    #endregion

    #region Methods
    static void Main()
    {
#if TRIAL_VERSION

        Console.WriteLine("Trial Version: Validity-10 Days");
#else
        Console.WriteLine("Welcome");
#endif

        Console.WriteLine($"Running: {appName}");
    }
    #endregion

}

//Output:
//PS C:\Users\john.kiruba\JCode\LD\Assignment\WEEK01\DAY2\Task_1_8> dotnet run
//Trial Version: Validity - 10 Days
//Running: Task1.8
//PS C:\Users\john.kiruba\JCode\LD\Assignment\WEEK01\DAY2\Task_1_8> dotnet run
//Welcome
//Running: Task1.8
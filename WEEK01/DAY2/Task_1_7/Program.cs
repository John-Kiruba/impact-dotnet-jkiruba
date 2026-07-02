//Task 1.7 Declare 5 variables using correct conventions (camelCase locals,
//PascalCase types / methods). Try a variable named class, 
//observe the error, fix with @class. 
//✓ Done when: the @class version compiles and the error is noted.

class Program
{
    //PascalCase for enums, class types 
    enum ProgramCycle
    {
        Start,
        InProgress,
        End
    }

    static void Main()
    {
        // 5 local variables using camelCase conventions
        string currentCycle = "Start";
        bool isActive = false;
        int count = 0;
        char initialCharacter = 'M';
        float cost = 0.3f;

        // @class reversed keyword bypass
        double @class = 10.50;

        Console.WriteLine(@class);
    }
}

//Error:
//Error: CS1519: Invalid token "class" in member declaration
//Solution: prefix '@' to variable identifier

//Findings:
//Warning: CS0219: unused variable. 
// Task 1.10 DaysOfWeek enum: take a number 0–6, print the day name.
// [Flags] FilePermission { Read=1, Write=2, Execute=4 }: combine with |, test with &.
// ✓ Done when: combined permissions print correctly and a single permission check works.

class Program
{
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    [Flags]
    enum FilePermissions
    {
        Read = 1,
        Write = 2,
        Execute = 4,
    }

    static void Main()
    {
        if (int.TryParse(Console.ReadLine(), out int day) && day >= 0 && day < 7)
        {
            Console.WriteLine($"Day: {(DaysOfWeek)day}");
        }
        else
        {
            Console.WriteLine("Invalid Day Number");
        }

        FilePermissions permission = FilePermissions.Read | FilePermissions.Write;

        if ((permission & FilePermissions.Read) == FilePermissions.Read)
        {
            Console.WriteLine("Granted Read");
        }

        if ((permission & FilePermissions.Execute) == FilePermissions.Execute)
        {
            Console.WriteLine("Granted Execute");
        }
        else
        {
            Console.WriteLine("No Execution Permission");
        }
    }
}

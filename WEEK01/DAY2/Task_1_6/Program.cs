//Task 1.6 Create ModuleA and ModuleB, each with Helper.Greet().
//Call both from Main() and resolve the name clash with fully-qualified names.
//✓ Done when: both Greet()s run without ambiguity errors.

namespace Task_1_6;

class Program
{
    static void Main()
    {
        ModuleA.Helper.Greet();
        ModuleB.Helper.Greet();
    }
}
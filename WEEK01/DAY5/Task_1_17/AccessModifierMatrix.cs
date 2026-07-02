namespace Task_1_17
{
    public class AccessModifierMatrix
    {
        public string PublicField = "public: visible everywhere";
        private string _privateField = "private: this class only";
        protected string ProtectedField = "protected: this class + derived classes";
        internal string InternalField = "internal: anywhere in this assembly";
        protected internal string ProtectedInternalField =
            "protected internal: derived OR same assembly";
        private protected string PrivateProtectedField =
            "private protected: derived AND same assembly";

        public string RevealPrivate() => _privateField;

        public void PrintOwnView()
        {
            Console.WriteLine("-- AccessModifierMatrix, seen from inside itself --");
            Console.WriteLine(PublicField);
            Console.WriteLine(_privateField);
            Console.WriteLine(ProtectedField);
            Console.WriteLine(InternalField);
            Console.WriteLine(ProtectedInternalField);
            Console.WriteLine(PrivateProtectedField);
        }
    }

    internal class Sibling : AccessModifierMatrix
    {
        public void PrintDerivedView()
        {
            Console.WriteLine("-- Sibling (derived, same assembly) view --");
            Console.WriteLine(PublicField);
            // _privateField is NOT reachable here - private stays sealed to its own class.
            Console.WriteLine(ProtectedField);
            Console.WriteLine(InternalField);
            Console.WriteLine(ProtectedInternalField);
            Console.WriteLine(PrivateProtectedField);
        }
    }
}

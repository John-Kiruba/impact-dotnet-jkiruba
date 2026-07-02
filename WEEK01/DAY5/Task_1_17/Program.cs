// Task 1.17 Partial class Employee across two files with a partial method; an access-modifier matrix class;
// Address(Street, City, Pincode) record compared with == and copied with with;
// a Playlist indexer with bounds checking + a string indexer.
// ✓ Done when: the record prints True for value equality and with produces a changed copy.

namespace Task_1_17
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== 1. Partial class Employee ===");
            var emp = new Employee("Asha", 50000m);
            emp.GiveRaise(5000m);
            Console.WriteLine($"Final salary: {emp.Salary:C}");
            Console.WriteLine();

            Console.WriteLine("=== 2. Access modifier matrix ===");
            var matrix = new AccessModifierMatrix();
            matrix.PrintOwnView();
            Console.WriteLine($"Private field via public method: {matrix.RevealPrivate()}");
            var sibling = new Sibling();
            sibling.PrintDerivedView();
            Console.WriteLine();

            Console.WriteLine("=== 3. Address record: value equality + 'with' ===");
            var addr1 = new Address("12 MG Road", "Chennai", "600001");
            var addr2 = new Address("12 MG Road", "Chennai", "600001");
            var addr3 = addr1 with { City = "Bengaluru", Pincode = "560001" };

            Console.WriteLine($"addr1: {addr1}");
            Console.WriteLine($"addr2: {addr2}");
            Console.WriteLine($"addr3 (copy with changes): {addr3}");
            Console.WriteLine($"addr1 == addr2: {addr1 == addr2}");
            Console.WriteLine($"addr1 == addr3: {addr1 == addr3}");
            Console.WriteLine();

            Console.WriteLine("=== 4. Playlist indexers ===");
            var playlist = new Playlist();
            playlist.Add("Song A");
            playlist.Add("Song B");
            playlist.Add("Song C");

            Console.WriteLine($"playlist[1]: {playlist[1]}");
            Console.WriteLine($"playlist[\"song c\"]: {playlist["song c"]}");
            Console.WriteLine(
                $"playlist[\"Missing Song\"]: {playlist["Missing Song"] ?? "(null)"}"
            );

            try
            {
                var _ = playlist[10];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"playlist[10] threw as expected: {ex.Message}");
            }
        }
    }
}

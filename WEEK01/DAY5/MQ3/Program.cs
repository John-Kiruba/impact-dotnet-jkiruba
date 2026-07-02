// Mini Q3 — Contact Card: ContactCard struct array of 5;
// case-insensitive search by name.
//  ✓ Done when: a lowercase query finds a differently-cased name.

struct ContactCard
{
    public string Name;
    public string Phone;
}

class Program
{
    static void Main()
    {
        ContactCard[] contacts = new ContactCard[5];

        contacts[0].Name = "Rahul";
        contacts[0].Phone = "1111111111";

        contacts[1].Name = "Priya";
        contacts[1].Phone = "2222222222";

        contacts[2].Name = "Arun";
        contacts[2].Phone = "3333333333";

        contacts[3].Name = "Sneha";
        contacts[3].Phone = "4444444444";

        contacts[4].Name = "David";
        contacts[4].Phone = "5555555555";

        Console.Write("Enter name to search: ");
        string search = Console.ReadLine();

        bool found = false;

        foreach (ContactCard contact in contacts)
        {
            if (contact.Name.Equals(search, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Found");
                Console.WriteLine(contact.Name);
                Console.WriteLine(contact.Phone);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Contact Not Found");
        }
    }
}

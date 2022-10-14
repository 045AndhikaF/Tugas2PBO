using System;

namespace AccessModified
{
    class PublicPerson
    {
        public string name = "Muhammad";
    }
    class ProtectedPerson
    {
        protected string name = "Andhika";
    }
    class Program : ProtectedPerson
    {
        class PrivatePerson
        {
            private string name = "Fahrezzy";
            static void Main(String[] args)
            {
                Console.WriteLine("Access modified public");
                PublicPerson person = new PublicPerson();
                Console.WriteLine(person.name);
                Console.WriteLine("");
                Console.WriteLine("Access modified protected");
                Program program = new Program();
                Console.WriteLine(program.name);
                Console.WriteLine("");
                Console.WriteLine("Access modified private");
                PrivatePerson privatePerson = new PrivatePerson();
                Console.WriteLine(privatePerson.name);
            }
        }
    }
}
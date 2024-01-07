namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello, from another line.");

            Person person = new Person
            {
                FirstName = "Scott",
                LastName = "Gillen"
            };

            Person anotherPerson = new Person
            {
                FirstName = "John",
                LastName = "Jones"
            };

            Console.WriteLine(person.ToString());
            Console.WriteLine(anotherPerson.ToString());
        }
    }
}
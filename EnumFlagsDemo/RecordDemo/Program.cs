using System.Runtime.InteropServices;

namespace RecordDemo
{
    public interface IABC
    {
        void foo();
    }
    public record Person(string firstname, string lastname, string city);

    public record PersonX(string firstname, string lastname, string city) : IABC
    {
        public void foo()
        {
            throw new NotImplementedException();
        }
    }

    public record P2(string firstname, string lastname, string city, int age) : 
        Person(firstname, lastname, city)
    {
    }

    public record Foo(string firstname, int[] numbers);

    public record Person2
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string city { get; init; }   // immutable.
    }

    public class Person3
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string city { get; init; }   // immutable.
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Foo f = new Foo("some name", new int[] { 1, 2, 3 });
            //f.firstname = "John";
            //f.numbers = new int[] {5,6, 7};
            f.numbers[0] = 10;

            //PersonX px = new PersonX("abc", "cd", "ef");
            //px.foo();

            Person p1 = new Person("John", "Smith", "Boston");
            Console.WriteLine($"{p1.firstname} {p1.lastname} {p1.city}");
            //p1.city = "Detroit";

            Person2 p2 = new Person2 { city = "NYC" } ;
            p2.firstname = "Mary";
            p2.lastname = "Jane";
            Console.WriteLine($"{p2.firstname} {p2.lastname} {p2.city}");
            //p2.city = "NYC";

            Person3 p3 = new Person3(); // { city = "NYC" };
            p3.firstname = "Mary";
            p3.lastname = "Jane";
            Console.WriteLine($"{p3.firstname} {p3.lastname} {p3.city}");
            //p3.city = "Dallas";

            Console.WriteLine("Record Comparison...");
            Person p101 = new Person("John", "Smith", "Boston");
            Person p102 = new Person("John", "Smith", "Boston");
            Console.WriteLine($"{p101 == p102}");
            Console.WriteLine($"{p101 == p102}");

            //Person p103 = new Person("John", "Smith", "NYC");
            Person p103 = p101 with { city = "NYC" };

            Console.WriteLine("Record in a HashSet for duplicates...");
            HashSet<Person> people = new HashSet<Person>();
            people.Add(p101);
            people.Add(p102);
            people.Add(p103);

            Console.WriteLine($"There are {people.Count} objects.");
            foreach(var p in people)
            {
                Console.WriteLine($"{p.firstname} {p.lastname} {p.city}");
            }
        }
    }
}
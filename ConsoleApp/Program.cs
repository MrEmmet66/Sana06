using PeopleClassLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People[] peoples = CreatePeoples();
            foreach (People people in peoples)
            {
                System.Console.WriteLine(people.ShowInfo());
                System.Console.WriteLine("------------------------------");
            }
        }

        static People[] CreatePeoples()
        {
            People[] peoples = new People[4];
            peoples[0] = new People("Василь", "Петренко", new System.DateTime(2000, 12, 10));
            peoples[1] = new Student("Степан", "Василено", new System.DateTime(2000, 05, 01), 2, "КН-22-1", "ФІКТ", "Житомирська Політехніка");
            peoples[2] = new Entrant("Іван", "Сичов", new System.DateTime(2002, 01, 06), 200, 12, "ЗОШ №1");
            peoples[3] = new LibraryUser("Олександр", "Ковальчук", new System.DateTime(2000, 10, 10), 2, "ЕО-42", "ГЕФ", "Житомирська Політехніка", 123, new System.DateTime(2019, 10, 10), 100);
            return peoples;
        }
    }
}
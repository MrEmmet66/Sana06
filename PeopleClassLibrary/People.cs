namespace PeopleClassLibrary
{
    public class People
    {
        public People(string name, string surname, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }
        public People() { }

        public People(People people) : this(people.Name, people.Surname, people.BirthDate) { }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }


    }
}
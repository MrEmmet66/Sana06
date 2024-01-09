using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleClassLibrary
{
    public class Student : People
    {
        public Student(string name, string surname, DateTime birthDate, int course, string group, string faculty, string university) 
            : base(name, surname, birthDate)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public Student() { }

        public Student(Student student) : this(student.Name, student.Surname, student.BirthDate, student.Course, student.Group, student.Faculty, student.University) { }

        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }

        public override string ShowInfo()
        {
            string baseInfo = base.ShowInfo();
            StringBuilder sb = new StringBuilder(baseInfo);
            sb.AppendLine($"\nКурс: {Course}");
            sb.AppendLine($"Група: {Group}");
            sb.AppendLine($"Факультет: {Faculty}");
            sb.AppendLine($"Університет: {University}");
            return sb.ToString();
        }

    }
}

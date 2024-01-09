using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleClassLibrary
{
    public class LibraryUser : Student
    {
        public LibraryUser(string name, string surname, DateTime birthDate, int course, string group, string faculty, string university, int libraryCardId, DateTime dateOfEnrollment, int monthlyDeposit) 
            : base(name, surname, birthDate, course, group, faculty, university)
        {
            LibraryCardId = libraryCardId;
            DateOfEnrollment = dateOfEnrollment;
            MonthlyDeposit = monthlyDeposit;
        }
        public LibraryUser() { }

        public LibraryUser(LibraryUser libraryUser) : this(libraryUser.Name, libraryUser.Surname, libraryUser.BirthDate, libraryUser.Course, libraryUser.Group, libraryUser.Faculty, libraryUser.University, libraryUser.LibraryCardId, libraryUser.DateOfEnrollment, libraryUser.MonthlyDeposit) { }

        public int LibraryCardId { get; set; }
        public DateTime DateOfEnrollment { get; set; }
        public int MonthlyDeposit { get; set; }

        public override string ShowInfo()
        {
            string baseInfo = base.ShowInfo();
            StringBuilder sb = new StringBuilder(baseInfo);
            sb.AppendLine($"\nНомер читацького квитка: {LibraryCardId}");
            sb.AppendLine($"Дата вступу: {DateOfEnrollment}");
            sb.AppendLine($"Щомісячний внесок: {MonthlyDeposit}");
            return sb.ToString();
        }
    }
}

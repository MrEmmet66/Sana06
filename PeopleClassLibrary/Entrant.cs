using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleClassLibrary
{
    public class Entrant : People
    {
        public Entrant(string name, string surname, DateTime birthDate, int znoMark, int schoolCertificateMark, string schoolName) 
            : base(name, surname, birthDate)
        {
            ZnoMark = znoMark;
            SchoolCertificateMark = schoolCertificateMark;
            SchoolName = schoolName;
        }
        public Entrant() { }

        public Entrant(Entrant entrant) : this(entrant.Name, entrant.Surname, entrant.BirthDate, entrant.ZnoMark, entrant.SchoolCertificateMark, entrant.SchoolName) { }


        public int ZnoMark { get; set; }
        public int SchoolCertificateMark { get; set; }
        public string SchoolName { get; set; }

        public override string ShowInfo()
        {
            string baseInfo = base.ShowInfo();
            StringBuilder sb = new StringBuilder(baseInfo);
            sb.AppendLine($"\nКількість балів сертифікатів ЗНО: {ZnoMark}");
            sb.AppendLine($"Кількість балів за документ про освіту: {SchoolCertificateMark}");
            sb.AppendLine($"Назва загальноосвітнього навчального закладу: {SchoolName}");
            return sb.ToString();
        }

    }
}

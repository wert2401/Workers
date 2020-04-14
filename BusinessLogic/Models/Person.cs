using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Education Education { get; set; }
        public List<Course> Courses { get; set; }
        public DateTime HireDate { get; set; }
        public int WorkExperience { get; set; }
        public List<Contest> Contests { get; set; }
        public Qualification Qualification { get; set; }
        public bool IsFired { get; set; } = false;

        public List<string> GetArray(DateTime date)
        {
            List<string> p = new List<string>();
            p.Add(Name);
            p.Add(BirthDate.ToString("dd.MM.yyy"));
            p.Add(GetAge(date).ToString() + " лет");
            p.Add(Education.ToString());

            if (Courses.Count > 0)
            {
                p.Add(Courses.Last().ToString());
            }
            else
            {
                p.Add("");
            }

            p.Add(HireDate.ToString("dd.MM.yyy"));
            p.Add((GetExpirience(date)).ToString() + " лет");
            p.Add((GetExpirience(date)+WorkExperience).ToString() + " лет");

            if (Contests.Count > 0)
            {
                p.Add(Contests.Last().ToString());
            }
            else
            {
                p.Add("");
            }

            p.Add(Qualification.ToString());
            if (IsFired)
            {
                p.Add("Да");
            }
            else
            {
                p.Add("Нет");
            }

            return p;
        }

        public int GetAge(DateTime date)
        {
            return DateCalculator.DifferenceInYears(date, BirthDate);
        }

        public int GetExpirience(DateTime date)
        {
            return DateCalculator.DifferenceInYears(date, HireDate);
        }
    }
}

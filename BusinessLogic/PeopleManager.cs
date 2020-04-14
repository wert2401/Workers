using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PeopleManager
    {
        List<Person> people = new List<Person>();
        DataManager dataManager;

        public PeopleManager()
        {
            dataManager = new DataManager();
        }

        public async Task<List<Person>> Init()
        {
            await dataManager.Backup();
            people = await dataManager.Load();
            if (people == null)
            {
                people = new List<Person>();
            }
            return GetPeople();
        }

        public async Task<List<Person>> OpenFile(string path)
        {
            people = await dataManager.Load(path);
            return GetPeople();
        }

        public List<Person> GetPeople()
        {
            List<Person> p = new List<Person>();
            p.AddRange(people.Where(ps => ps.IsFired == false).ToList());
            return p;
        }

        //Return the same person, but with Id
        public async Task<Person> AddPerson(Person person)
        {
            if (people.Count > 0)
            {
                person.Id = people.Last().Id + 1;
            }
            else
            {
                person.Id = 0;
            }
            people.Add(person);
            await dataManager.Save(people);
            return person;
        }

        public async Task DeletePerson(Person person)
        {
            Person p = people.Where(prs => prs.Id == person.Id).FirstOrDefault();
            people.Remove(p);
            await dataManager.Save(people);
        }

        public async Task EditPerson(Person person)
        {
            Person p = people.Where(prs => prs.Id == person.Id).FirstOrDefault();
            int index = people.IndexOf(p);
            people[index] = p;
            await dataManager.Save(people);
        }

        public void Export(string path, List<Person> people, DateTime date)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Дата отсчета: " + date.ToString("dd.MM.yyyy"));
            if (people != null)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    List<string> ps = people[i].GetArray(date);
                    ps.Insert(0, (i + 1).ToString());
                    sb.AppendLine(string.Join(" ", ps));
                }
            }
            dataManager.Export(path, sb.ToString());
        }

        public List<Person> Search(SearchParams searchParams)
        {
            List<Person> p = new List<Person>();
            p.AddRange(people);

            //Name
            if (searchParams.Name != "")
            {
                p = p.Where(ps => ps.Name == searchParams.Name).ToList();
            }

            //Date
            p = p.Where(ps => ps.BirthDate < searchParams.Date && ps.HireDate < searchParams.Date).ToList();

            //Is Fired
            p = p.Where(ps => ps.IsFired == searchParams.IsFired).ToList();

            //Education
            if (searchParams.Education.Degree != Degree.none)
            {
                p = p.Where(ps => ps.Education.Degree == searchParams.Education.Degree).ToList();
            }
            if (searchParams.Education.Place != "")
            {
                p = p.Where(ps => ps.Education.Place == searchParams.Education.Place).ToList();
            }
            if (searchParams.EducationStart != new DateTime())
            {
                p = p.Where(ps => ps.Education.EndTime >= searchParams.EducationStart).ToList();
            }
            if (searchParams.EducationEnd != new DateTime())
            {
                p = p.Where(ps => ps.Education.EndTime <= searchParams.EducationEnd).ToList();
            }

            //Qualification 
            if (searchParams.Qualification.QualificationCategorie != QualificationCategorie.none)
            {
                p = p.Where(ps => ps.Qualification.QualificationCategorie == searchParams.Qualification.QualificationCategorie).ToList();
            }
            if (searchParams.QualificationStart != new DateTime())
            {
                p = p.Where(ps => ps.Qualification.Date >= searchParams.QualificationStart).ToList();
            }
            if (searchParams.QualificationEnd != new DateTime())
            {
                p = p.Where(ps => ps.Qualification.Date <= searchParams.QualificationEnd).ToList();
            }

            //Courses
            if (searchParams.Course.Theme != "")
            {
                p = p.Where(ps => ps.Courses.Where(c => c.Theme.Contains(searchParams.Course.Theme)).Count() > 0).ToList();
            }
            if (searchParams.CourseStart != new DateTime())
            {
                p = p.Where(ps => ps.Courses.Where(c => c.Date >= searchParams.CourseStart).Count() > 0).ToList();
            }
            if (searchParams.CourseEnd != new DateTime())
            {
                p = p.Where(ps => ps.Courses.Where(c => c.Date <= searchParams.CourseEnd).Count() > 0).ToList();
            }

            //Contests
            if (searchParams.Contest.Title != "")
            {
                p = p.Where(ps => ps.Contests.Where(c => c.Title.Contains(searchParams.Contest.Title)).Count() > 0).ToList();
            }
            if (searchParams.ContestStart != new DateTime())
            {
                p = p.Where(ps => ps.Contests.Where(c => c.Date >= searchParams.ContestStart).Count() > 0).ToList();
            }
            if (searchParams.ContestEnd != new DateTime())
            {
                p = p.Where(ps => ps.Contests.Where(c => c.Date <= searchParams.ContestEnd).Count() > 0).ToList();
            }

            //Age
            if (searchParams.AgeStart != -1)
            {
                p = p.Where(ps => ps.GetAge(searchParams.Date) >= searchParams.AgeStart).ToList();
            }
            if (searchParams.AgeEnd != -1)
            {
                p = p.Where(ps => ps.GetAge(searchParams.Date) <= searchParams.AgeEnd).ToList();
            }

            //All Expirience
            if (searchParams.AllExpirienceStart != -1)
            {
                p = p.Where(ps => ps.GetExpirience(searchParams.Date) + ps.WorkExperience >= searchParams.AllExpirienceStart).ToList();
            }
            if (searchParams.AllExpirienceEnd != -1)
            {
                p = p.Where(ps => ps.GetExpirience(searchParams.Date) + ps.WorkExperience <= searchParams.AllExpirienceEnd).ToList();
            }

            //Local Expirience
            if (searchParams.LocalExpirienceStart != -1)
            {
                p = p.Where(ps => ps.GetExpirience(searchParams.Date) >= searchParams.LocalExpirienceStart).ToList();
            }
            if (searchParams.LocalExpirienceEnd != -1)
            {
                p = p.Where(ps => ps.GetExpirience(searchParams.Date) <= searchParams.LocalExpirienceEnd).ToList();
            }

            return p;
        }
    }
}

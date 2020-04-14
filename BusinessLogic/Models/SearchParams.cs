using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class SearchParams
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Education Education { get; set; }
        public DateTime EducationStart { get; set; }
        public DateTime EducationEnd { get; set; }
        public Qualification Qualification { get; set; }
        public DateTime QualificationStart { get; set; }
        public DateTime QualificationEnd { get; set; }
        public Course Course { get; set; }
        public DateTime CourseStart { get; set; }
        public DateTime CourseEnd { get; set; }
        public Contest Contest { get; set; }
        public DateTime ContestStart { get; set; }
        public DateTime ContestEnd { get; set; }
        public int AgeStart { get; set; }
        public int AgeEnd { get; set; }
        public int AllExpirienceStart { get; set; }
        public int AllExpirienceEnd { get; set; }
        public int LocalExpirienceStart { get; set; }
        public int LocalExpirienceEnd { get; set; }
        public bool IsFired { get; set; }
    }
}

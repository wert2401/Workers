using System;

namespace BusinessLogic.Models
{
    public class Course
    {
        public DateTime Date{ get; set; }
        public string Theme { get; set; }

        public override string ToString()
        {
            return Date.ToString("dd.MM.yyyy") + " " + Theme;
        }
    }
}
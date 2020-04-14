using System;
using System.Text;

namespace BusinessLogic.Models
{
    public enum Degree
    {
        MiddleProf,
        HighProf,
        MiddleTeach,
        HighTeach,
        none
    }

    public class Education
    {
        public DateTime EndTime { get; set; }
        public string Place { get; set; }
        public Degree Degree { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            switch (Degree)
            {
                case Degree.MiddleProf:
                    sb.Append("Среднее профессиональное ");
                    break;
                case Degree.HighProf:
                    sb.Append("Высшее профессиональное ");
                    break;
                case Degree.MiddleTeach:
                    sb.Append("Среднее педагогическое ");
                    break;
                case Degree.HighTeach:
                    sb.Append("Высшее педагогическое ");
                    break;
                default:
                    break;
            }
            sb.Append(Place + " ");
            sb.Append(EndTime.ToString("dd.MM.yyy"));
            return sb.ToString();
        }
    }
}
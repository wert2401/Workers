using System;

namespace BusinessLogic.Models
{
    public class Contest
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return Date.ToString("dd.MM.yyyy") + " " + Title;
        }
    }
}
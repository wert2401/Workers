using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class DateCalculator
    {
        public static int DifferenceInYears(DateTime firstDate, DateTime secondDate)
        {
            int years;
            int months;
            int days;
            years = firstDate.Year - secondDate.Year - 1;
            months = firstDate.Month - secondDate.Month;
            days = firstDate.Day - secondDate.Day;
            if (months > 0)
            {
                years++;
            }
            else if (months == 0)
            {
                if (days > 0)
                {
                    years++;
                }
                else if (days == 0)
                {
                    years++;
                }
            }

            return years;
        }
    }
}

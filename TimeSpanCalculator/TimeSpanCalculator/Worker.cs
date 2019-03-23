using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanCalculator
{
    class Worker
    {
        /// <summary>
        /// Instantiates a new instance of the Worker class.
        /// </summary>
        /// <param name="date1">First Date</param>
        /// <param name="date2">Second Date</param>
        public Worker(string date1, string date2)
        {
            _date1string = date1;
            _date2string = date2;

            DateTime firstDate;
            bool firstDateComverted = DateTime.TryParse(_date1string, out firstDate);
            
            if (firstDateComverted)
            {
                Date1 = firstDate;
            }

            DateTime secondDate;
            bool secondDateConverted = DateTime.TryParse(_date2string, out secondDate);

            if (secondDateConverted)
            {
                Date2 = secondDate;
            }
        }

        private string _date1string;
        private string _date2string;

        public readonly DateTime? Date1 = null;
        public readonly DateTime? Date2 = null;


        /// <summary>
        /// Validates Date1 Input
        /// </summary>
        public bool IsDate1Valid
        {
            get
            {
                if (Date1.HasValue)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        /// <summary>
        /// Validates Date2 Input
        /// </summary>
        public bool IsDate2Valid
        {
            get
            {
                if (Date2.HasValue)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        /// <summary>
        /// Validates that Date1 is earlier than Date2
        /// </summary>
        public bool IsDate1Later
        {
            get
            {
                bool DateLater = Date1 > Date2;
                return DateLater;
            }
        }


        public TimeSpan Interval()   
        {
            //CalculateTotalDays()
            TimeSpan interval = (TimeSpan)(Date2 - Date1);
            return interval;
        }
        
        public int CalculateYears()
        {
            int years;

            if (Date1.Value.Month > Date2.Value.Month)
            {
                years = Date2.Value.Year - Date1.Value.Year - 1;
            }
            else
            {
                years = Date2.Value.Year - Date1.Value.Year;
            }
            return years;
        }

        public int CalculateTotalMonths()
        {
            // Calculate Months from Years
            int monthsfromYears = CalculateYears() * 12;
            int months = CalculateMonths();
            int totalMonths = monthsfromYears + months;
            return totalMonths;
        }

        public int CalculateMonths()
        {
            int months;

            if (Date1.Value.Month > Date2.Value.Month)
            {
                months = Date2.Value.Month + 12 - Date1.Value.Month;
            }
            else
            {
                months = Date2.Value.Month - Date1.Value.Month;
            }

            if (Date1.Value.Day > Date2.Value.Day)
            {
                months -= 1;
            }
            
            return months;
        }

        public int CalculateDays()
        {

            int days;
         
            // Calculate Days in Month
            int mdays = DateTime.DaysInMonth(Date1.Value.Year, Date1.Value.Month);

            // Calculate Days in Month1
            if (Date1.Value.Day > Date2.Value.Day)
            {
                days = (mdays - Date1.Value.Day) + Date2.Value.Day;
            }
            else
            {
                days = Date2.Value.Day - Date1.Value.Day;
            }

            return days;
        }

    }
}

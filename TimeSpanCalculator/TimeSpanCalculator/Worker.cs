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
            _date1 = date1;
            _date2 = date2;
        }

        private string _date1;

        private string _date2;

        /// <summary>
        /// Validates Date1 Input
        /// </summary>
        public bool IsDate1Valid
        {
            get
            {
                DateTime result;
                bool D1Valid = DateTime.TryParse(_date1, out result);
                return D1Valid;
            }
        }

        /// <summary>
        /// Validates Date2 Input
        /// </summary>
        public bool IsDate2Valid
        {
            get
            {
                DateTime result;
                bool D2Valid = DateTime.TryParse(_date2, out result);
                return D2Valid;
            }
        }

        /// <summary>
        /// Validates that Date1 is earlier than Date2
        /// </summary>
        public bool IsDate1Later
        {
            get
            {
                DateTime date1;
                DateTime.TryParse(_date1, out date1);
                DateTime date2;
                DateTime.TryParse(_date2, out date2);
                bool DateLater = date1 > date2;
                return DateLater;
            }
        }

        /// <summary>
        /// Provides Current Date in Month Day Year format
        /// </summary>
        /// <returns></returns>
        public static string TodaysDate()
        {
            string now = DateTime.Now.ToString("MMMM dd, yyyy");
            return now;
        }

        public string Date1()
        {
                DateTime date1;
                DateTime.TryParse(_date1, out date1);
                string fDate1 = date1.ToString("MMMM dd, yyyy");
                return fDate1; 
        }

        public string Date2()
        {
            DateTime date2;
            DateTime.TryParse(_date2, out date2);
            string fDate2 = date2.ToString("MMMM dd, yyyy");
            return fDate2;
        }

        public double CalculateTotalDays()
        {
            DateTime date1;
            DateTime.TryParse(_date1, out date1);
            DateTime date2;
            DateTime.TryParse(_date2, out date2);
            TimeSpan interval = date2 - date1;
            double intervalDays = interval.Days;
            return intervalDays; 
        }

        //public int CalculateTotalHours()
        //{
        //    DateTime date1;
        //    DateTime.TryParse(_date1, out date1);
        //    DateTime date2;
        //    DateTime.TryParse(_date2, out date2);
        //    TimeSpan interval = date2 - date1;
        //    int totalHours = interval.TotalHours;
        //    return totalHours;
        //}
        
        public int CalculateYears()
        {
            DateTime date1;
            DateTime.TryParse(_date1, out date1);
            DateTime date2;
            DateTime.TryParse(_date2, out date2);
            int date1Year = date1.Year;
            int date1Month = date1.Month;
            int date2Year = date2.Year;
            int date2Month = date2.Month;
            int years;

            if (date1Month > date2Month)
            {
                years = date2Year - date1Year - 1;
            }
            else
            {
                years = date2Year - date1Year;
            }
            return years;
        }

        public int CalculateTotalMonths()
        {
            DateTime date1;
            DateTime.TryParse(_date1, out date1);
            DateTime date2;
            DateTime.TryParse(_date2, out date2);

            int date1Year = date1.Year;
            int date1Month = date1.Month;
            int date1Day = date1.Day;
            int date2Year = date2.Year;
            int date2Month = date2.Month;
            int date2Day = date2.Day;

            // Calculate Years
            int years = date2Year - date1Year;

            // Calculate Months from Years
            int monthsfromYears = years * 12;
            int months;

            if (date1Month > date2Month)
            {
                months = date2Month + 12 - date1Month;
            }
            else
            {
                months = date2Month - date1Month;
            }

            int totalMonths = monthsfromYears + months;
            return totalMonths;
        }

        public int CalculateMonths()
        {
            DateTime date1;
            DateTime.TryParse(_date1, out date1);
            DateTime date2;
            DateTime.TryParse(_date2, out date2);

            int date1Month = date1.Month;
            int date1Day = date1.Day;
            int date2Month = date2.Month;
            int date2Day = date2.Day;

            int months;

            if (date1Month > date2Month)
            {
                months = date2Month + 12 - date1Month;
            }
            else
            {
                months = date2Month - date1Month;
            }

            if (date1Day > date2Day)
            {
                months -= 1;
            }
            
            return months;
        }

        public int CalculateDays()
        {
            DateTime date1;
            DateTime.TryParse(_date1, out date1);
            DateTime date2;
            DateTime.TryParse(_date2, out date2);

            int date1Year = date1.Year;
            int date1Month = date1.Month;
            int date1Day = date1.Day;
            int date2Month = date2.Month;
            int date2Day = date2.Day;
            int days;
         
            // Calculate Days in Month
            int mdays = DateTime.DaysInMonth(date1Year, date1Month);

            // Calculate Days in Month1
            if (date1Day > date2Day)
            {
                days = (mdays - date1Day) + date2Day;
            }
            else
            {
                days = date2Day - date1Day;
            }

            return days;
        }  
    }
}

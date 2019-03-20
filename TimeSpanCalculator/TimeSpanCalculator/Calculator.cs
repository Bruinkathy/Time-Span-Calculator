using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSpanCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            Initialize();
            
        }

        private void Initialize()
        {
            string Now = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            WelcomeNow.Text = "Welcome! Today is " + Now;
        }


        private void Today_Click(object sender, EventArgs e)
        {
            string Now = DateTime.Now.ToString("MM/dd/yyyy");
            DateBox2.Text = Now;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            CalculationBox1.Text = string.Empty;

            DateTime Date1;
            bool D1Valid = DateTime.TryParse(DateBox1.Text, out Date1);

            if (D1Valid == false)
            {
                CalculationBox1.Text = "Please enter a valid start date and try again.";
                return;
            }

            DateTime Date2;
            bool D2Valid = DateTime.TryParse(DateBox2.Text, out Date2);

            if (D2Valid == false)
            {
                CalculationBox1.Text = "Please enter a valid end date and try again.";
                return;
            }


            if (Date1 > Date2)
            {
                CalculationBox1.Text = "Please enter a new end date that is after your start date.";
            }

            int Date1Year = Date1.Year;
            int Date1Month = Date1.Month;
            int Date1Day = Date1.Day;

            int Date2Year = Date2.Year;
            int Date2Month = Date2.Month;
            int Date2Day = Date2.Day;

            int years = Date2Year - Date1Year;
            int months = 0;
            int days;

            int mdays = DateTime.DaysInMonth(Date1Year, Date1Month);

            if (Date1Month > Date2Month)
            {
                months = Date2Month + 12 - Date1Month;
                years = years - 1;
            }
            else
            {
                months = Date2Month - Date1Month;
            }

            

            if (Date1Day > Date2Day)
            {
                days = (mdays - Date1Day) + Date2Day;
            }
            else
            {
                days = Date2Day - Date1Day;
            }
            

            int leapYear = Date1Year - 1900;
            if (leapYear % 4 == 0)
            {
                if (Date1Month == 2)
                {
                    days += 1;
                }
            
        }

            int monthsDays = (years * 12) + months;

            TimeSpan interval = Date2 - Date1;

            string totalDays = interval.Days.ToString("N0");
            string totalHours = interval.TotalHours.ToString("N0");
            

            CalculationBox1.Text = "There are " + years + " years, " + months + " months, and " + days + " days between " + Date1.ToString("MMMM dd, yyyy") + " and " + Date2.ToString("MMMM dd, yyyy.") + Environment.NewLine +
                "That is " + totalDays + " total days, " + monthsDays + " months and " + days + " days, or approximately " + totalHours + " hours.";

        }

        private void CopyClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CalculationBox1.Text);
        }
    }
}

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
  
        // Header Welcome and Current Date
        private void Initialize()
        {
            string now = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            WelcomeNow.Text = "Welcome! Today is " + now;
        }

        private void Today_Click(object sender, EventArgs e)
        {
            DateBox2.Text = Worker.TodaysDate();
        }





        private void Calculate_Click(object sender, EventArgs e)
        {
            CalculationBox1.Text = string.Empty;

            // Instantiates instance of Worker class

            Worker worker = new Worker(DateBox1.Text, DateBox2.Text);

            // Validates Date 1

            if (worker.IsDate1Valid == false)
            {
                CalculationBox1.Text = "Please enter a valid start date and try again.";
                return;
            }

            // Validates Date 2

            if (worker.IsDate2Valid == false)
            {
                CalculationBox1.Text = "Please enter a valid end date and try again.";
                return;
            }

            // Validates that Date 1 is an earlier date than Date 2

            if (worker.IsDate1Later)
            {
                CalculationBox1.Text = "Please enter a new end date that is after your start date.";
            }

            int years = worker.CalculateYears();
            int months = worker.CalculateMonths();
            int days = worker.CalculateDays();
            double tDays = worker.CalculateTotalDays();
            string totalDays = tDays.ToString("N0");
            int totalHours = 0;
            //double tHours = worker.CalculateTotalHours();
            //string totalHours = tHours.ToString("N0");
            string date1 = worker.Date1();
            string date2 = worker.Date2();
            int monthsDays = worker.CalculateTotalMonths();


            CalculationBox1.Text = "There are " + years + " years, " + months + " months, and " + days + " days between " + date1 + " and " + date2 + "." +Environment.NewLine +
                "That is " + totalDays + " total days, " + monthsDays + " months and " + days + " days, or approximately " + totalHours + " total hours.";

        }



        // Copy to Clipboard onClick
        private void CopyClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CalculationBox1.Text);
        }
    }
}

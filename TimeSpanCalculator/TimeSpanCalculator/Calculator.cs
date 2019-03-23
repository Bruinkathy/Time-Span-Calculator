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

            toolTip1.SetToolTip(Calculate, "Click to calculate time interval between dates.");
            toolTip1.SetToolTip(Today, "Click to enter current date.");
            toolTip1.SetToolTip(buttonClear, "Click to do a new date calculation.");
            toolTip1.SetToolTip(CopyClipboard, "Click to save result to clipboard.");
        }
  
        // Header Welcome and Current Date
        private void Initialize()
        {
            string now = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            WelcomeNow.Text = "Welcome! Today is " + now;
        }

        private void Today_Click(object sender, EventArgs e)
        {
            DateBox2.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }





        private void Calculate_Click(object sender, EventArgs e)
        {
            CalculationBox1.Text = string.Empty;

            // Instantiates a new instance of Worker class

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

            // Return Calculations for CalculationBox1
            int years = worker.CalculateYears();
            int months = worker.CalculateMonths();
            int monthsDays = worker.CalculateTotalMonths();
            int days = worker.CalculateDays();
            TimeSpan interval = worker.Interval();



            // Text for CalculationBox1
            CalculationBox1.Text = string.Format("There are {0} years, {1} months, and {2} days between {3:MMMM dd, yyyy} and {4:MMMM dd, yyyy}."
                + Environment.NewLine
                + Environment.NewLine + "That is:                                                                                    "
                + Environment.NewLine + "{5:N0} total days"
                + Environment.NewLine + "{6} months and {7} days"
                + Environment.NewLine + "approximately {8:N0} hours"
                + Environment.NewLine + "approximately {9:N0} minutes"
                + Environment.NewLine + "approximately {10:N0} seconds", 
                years, months, days, worker.Date1, worker.Date2, interval.Days, monthsDays, days, interval.TotalHours, interval.TotalMinutes, interval.TotalSeconds);

            
        }



        // Copy to Clipboard onClick
        private void CopyClipboard_Click(object sender, EventArgs e)
        {
            bool isNull = String.IsNullOrWhiteSpace(CalculationBox1.Text);
               
            if (isNull == true)
            { 
                CalculationBox1.Text = "Nothing to copy.";
            }
            else
            { 
                Clipboard.SetText(CalculationBox1.Text);
            }
        }


        // Clear all Text Fields to Start Over
        private void buttonClear_Click(object sender, EventArgs e)
        {
            CalculationBox1.Text = String.Empty;
            DateBox1.Text = String.Empty;
            DateBox2.Text = String.Empty;
        }
    }
}

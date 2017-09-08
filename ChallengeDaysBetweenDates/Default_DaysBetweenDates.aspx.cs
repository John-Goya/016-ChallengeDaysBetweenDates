using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default_DaysBetweenDates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void firstCalendar_SelectionChanged(object sender, EventArgs e)
        {
            DateTime firstDate = firstCalendar.SelectedDate;
            selectedFirstDateLabel.Text = firstDate.ToShortDateString();
        }

        protected void secondCalendar_SelectionChanged(object sender, EventArgs e)
        {
            DateTime secondDate = secondCalendar.SelectedDate;
            selectedSecondDateLabel.Text = secondDate.ToShortDateString();
        }

        protected void calculateButton_Click(object sender, EventArgs e)
        {
            DateTime firstDate = firstCalendar.SelectedDate.Date;
            DateTime secondDate = secondCalendar.SelectedDate.Date;

            //TimeSpan timeDifference = secondDate.Subtract(firstDate);
            TimeSpan timeDifference = (secondDate - firstDate).Duration();
            //resultLabel.Text = timeDifference.ToString();
            resultLabel.Text = timeDifference.TotalDays.ToString();


            //TimeSpan timeDifference = new TimeSpan();
            //timeDifference = selectedFirstDateLabel - selectedSecondDateLabel;
            //resultLabel.Text = 
        }
    }
}
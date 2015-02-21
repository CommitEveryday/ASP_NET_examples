using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.TestControls
{
    public partial class Calendar : System.Web.UI.Page
    {
        Dictionary<DateTime, string> schedule = new Dictionary<DateTime, string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetSchedule();
            Calendar1.Style.Add(HtmlTextWriterStyle.Position, "absolute");
            Calendar1.Style.Add(HtmlTextWriterStyle.Left, "5px");
            Calendar1.Style.Add(HtmlTextWriterStyle.Top, "50px");
            Calendar1.Caption = "Special dates";
            Calendar1.FirstDayOfWeek = FirstDayOfWeek.Sunday;
            Calendar1.NextPrevFormat = NextPrevFormat.ShortMonth;
            Calendar1.TitleFormat = TitleFormat.MonthYear;
            Calendar1.ShowGridLines = true;
            Calendar1.DayStyle.HorizontalAlign = HorizontalAlign.Left;
            Calendar1.DayStyle.VerticalAlign = VerticalAlign.Top;
            Calendar1.DayStyle.Height = new Unit(75);
            Calendar1.DayStyle.Width = new Unit(100);
            Calendar1.OtherMonthDayStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            Calendar1.TodaysDate = new DateTime(2006, 12, 1);
            Calendar1.VisibleDate = Calendar1.TodaysDate;
        }

        private void GetSchedule()
        {
            schedule.Add(new DateTime(2006, 11, 23), "Thanksgiving");
            schedule.Add(new DateTime(2006, 12, 5), "Birthday");
            schedule.Add(new DateTime(2006, 12, 16), "First day of Chanukah");
            schedule.Add(new DateTime(2006, 12, 23), "Last day of Chanukah");
            schedule.Add(new DateTime(2006, 12, 24), "Christmas Eve");
            schedule.Add(new DateTime(2006, 12, 25), "Christmas");
            schedule.Add(new DateTime(2006, 12, 26), "Boxing Day");
            schedule.Add(new DateTime(2006, 12, 31), "New Year's Eve");
            schedule.Add(new DateTime(2007, 1, 1), "New Year's  Day");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Response.Write("Selection changed for: " +
                Calendar1.SelectedDate.ToShortDateString());
        }

        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            Response.Write("Month changed for: " +
                e.NewDate.ToShortDateString());
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            Literal lit = new Literal();
            lit.Visible = true;
            lit.Text = "<br />";
            e.Cell.Controls.Add(lit);
            if (schedule.ContainsKey(e.Day.Date))
            {
                Label lbl = new Label();
                lbl.Visible = true;
                lbl.Text = schedule[e.Day.Date];
                e.Cell.Controls.Add(lbl);
            }
        }
    }
}
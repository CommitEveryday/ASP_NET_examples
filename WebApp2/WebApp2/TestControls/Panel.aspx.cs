using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.TestControls
{
    public partial class Panel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Style.Add(HtmlTextWriterStyle.Position, "absolute");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = !Panel1.Visible;
        }

        protected void Button2_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Move")
            {
                double len;
                if (Double.TryParse(e.CommandArgument.ToString(), out len))
                {
                    Unit left = new Unit(Panel1.Style[HtmlTextWriterStyle.Left]);
                    left = new Unit(left.Value + len, left.Type);
                    Panel1.Style[HtmlTextWriterStyle.Left] = left.ToString();
                }
            }
        }
    }
}
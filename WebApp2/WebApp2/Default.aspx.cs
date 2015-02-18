using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImageButton1.ImageUrl = @"Images/chart.png";
            ImageButton1.AlternateText = "This is chart";
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Literal1.Text = String.Format("Click at ({0};{1})", e.X, e.Y);
        }
    }
}
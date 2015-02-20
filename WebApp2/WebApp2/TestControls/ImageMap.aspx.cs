using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.TestControls
{
    public partial class ImageMap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImageMap1.ImageUrl = @"~/Images/chart.png";
            ImageMap1.AlternateText = "This is chart";
            ImageMap1.HotSpotMode = HotSpotMode.PostBack;
            CircleHotSpot chs = new CircleHotSpot();
            chs.X = 75;
            chs.Y = 75;
            chs.Radius = 6;
            chs.PostBackValue = "Circle HotSpot";
            ImageMap1.HotSpots.Add(chs);

            RectangleHotSpot rhs = new RectangleHotSpot();
            rhs.Top = 101;
            rhs.Bottom = 110;
            rhs.Left = 74;
            rhs.Right = 110;
            rhs.PostBackValue = "RectangleHotSpot";
            ImageMap1.HotSpots.Add(rhs);

            PolygonHotSpot phs = new PolygonHotSpot();
            phs.Coordinates = "76,57,82,64,81,76,76,82,71,76,70,63";
            phs.PostBackValue = "PolygonHotSpot";
            ImageMap1.HotSpots.Add(phs);
        }

        protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        {
            Label1.Text = "You click: " + e.PostBackValue;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.TestControls
{
    public partial class BulletedList : System.Web.UI.Page
    {
        private List<Car> carList = Car.GetList();

        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.AutoPostBack = ListBox2.AutoPostBack = true;
            if (!IsPostBack)
            {
                BulletedList1.DataSource = carList;
                BulletedList1.DataTextField = "Make";
                BulletedList1.DataValueField = "Price";
                ListBox1.DataSource = Enum.GetNames(typeof(BulletStyle));
                ListBox2.DataSource = Enum.GetNames(typeof(BulletedListDisplayMode));
                DataBind();
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BulletedList1.BulletStyle = (BulletStyle)Enum.Parse(typeof(BulletStyle),
                ListBox1.SelectedValue);
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BulletedList1.DisplayMode = (BulletedListDisplayMode)Enum.Parse(typeof(BulletedListDisplayMode),
                ListBox2.SelectedValue);
        }
    }
}
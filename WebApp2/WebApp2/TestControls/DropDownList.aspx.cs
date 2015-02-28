using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.TestControls
{
    public partial class DropDownList : System.Web.UI.Page
    {
        private List<Car> carList = Car.GetList();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = carList;
                DropDownList1.DataTextField = "Price";
                DropDownList1.DataValueField = "Price";
                DropDownList1.DataTextFormatString = "Price: {0:C}";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue;
        }
    }
}
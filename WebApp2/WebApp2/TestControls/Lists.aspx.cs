using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.TestControls
{
    public partial class Lists : System.Web.UI.Page
    {
        private List<Car> carList = Car.GetList();

        protected void Page_Load(object sender, EventArgs e)
        {
            RadioButtonList1.RepeatColumns = 3;
            RadioButtonList1.RepeatDirection = RepeatDirection.Vertical;
            CheckBoxList1.RepeatColumns = 3;
            CheckBoxList1.RepeatDirection = RepeatDirection.Horizontal;
            if (!IsPostBack)
            {
                ListBox1.DataSource = carList;
                ListBox1.DataTextField = "Make";
                ListBox1.DataValueField = "Price";
                RadioButtonList1.DataSource = carList;
                RadioButtonList1.DataTextField = "Make";
                RadioButtonList1.DataValueField = "Price";
                CheckBoxList1.DataSource = carList;
                CheckBoxList1.DataTextField = "Make";
                CheckBoxList1.DataValueField = "Price";
                DataBind();
            }
        }
    }
}
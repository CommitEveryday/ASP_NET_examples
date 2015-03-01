using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.TestControls
{
    public partial class ListBox : System.Web.UI.Page
    {
        private List<Car> carList = Car.GetList();

        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.SelectionMode = ListBox2.SelectionMode = ListSelectionMode.Multiple;
            if (!IsPostBack)
            {
                ListBox1.DataSource = carList;
                ListBox1.DataTextField = "Price";
                ListBox1.DataValueField = "Price";
                ListBox1.DataTextFormatString = "Price: {0:C}";
                ListBox1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in ListBox1.Items)
            {
                if (item.Selected)
                    ListBox2.Items.Add(item);
            }
            //ListBox2.DataBind(); //не нужен?
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApp2.TestADO.NET
{
    public partial class WebFormDataTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private DataTable GetDataTable()
        {
            DataTable employee = new DataTable("Employee");

            return employee;
        }
    }
}
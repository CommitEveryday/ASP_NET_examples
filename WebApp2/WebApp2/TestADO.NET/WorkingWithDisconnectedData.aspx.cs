using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.TestADO.NET
{
    public partial class WorkingWithDisconnectedData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Sales salesDataSet = new Sales();
                Enumerable.Range(0, 10).ToList<int>().ForEach(x =>
                    salesDataSet.Customer.Rows.Add(Guid.NewGuid(), "Acme" + x));
                GridView.DataSource = salesDataSet;
                GridView.DataMember = "Customer";
                DataBind();
            }
        }
    }
}
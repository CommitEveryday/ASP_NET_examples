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

            DataColumn eid = new DataColumn("Eid");
            eid.DataType = typeof(string);
            eid.MaxLength = 10;
            eid.Unique = true;
            eid.AllowDBNull = false;
            eid.Caption = "EID";
            employee.Columns.Add(eid);

            DataColumn firstName = new DataColumn("FirstName");
            firstName.MaxLength = 35;
            firstName.AllowDBNull = false;
            employee.Columns.Add(firstName);

            DataColumn lastName = new DataColumn("LastName");
            lastName.AllowDBNull = false;
            employee.Columns.Add(lastName);

            DataColumn salary = new DataColumn("Salary", typeof(decimal));
            salary.DefaultValue = 0.00m;
            employee.Columns.Add(salary);

            DataColumn lastNameFirstName = new DataColumn("LastName and FirstName");
            lastNameFirstName.DataType = typeof(string);
            lastNameFirstName.MaxLength = 70;
            lastNameFirstName.Expression = "lastName + ', ' + FirstName";
            employee.Columns.Add(lastNameFirstName);

            employee.PrimaryKey = new DataColumn[] { eid };

            DataRow newEmployee = employee.NewRow();
            newEmployee["Eid"] = "123456789A";
            newEmployee["FirstName"] = "Nancy";
            newEmployee["LastName"] = "Davolio";
            newEmployee["Salary"] = 10.00m;
            employee.Rows.Add(newEmployee);

            employee.Rows.Add("987654321X", "Andrew", "Fuller", 15.00m);

            employee.LoadDataRow(new object[] { "987654321X", "Janet", "Leverling", 20.00m },
                LoadOption.OverwriteChanges);

            return employee;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView gv = new GridView();
            gv.Style.Add(HtmlTextWriterStyle.Position, "absolute");
            gv.Style.Add(HtmlTextWriterStyle.Left, "275px");
            gv.Style.Add(HtmlTextWriterStyle.Top, "20px");
            gv.EnableViewState = false;
            form1.Controls.Add(gv);

            gv.DataSource = GetDataTable();
            gv.DataBind();
        }
    }
}
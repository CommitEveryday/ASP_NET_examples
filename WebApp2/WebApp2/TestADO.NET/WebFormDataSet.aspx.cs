using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApp2.TestADO.NET
{
    public partial class WebFormDataSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private DataSet GetDataSet()
        {
            DataSet companyData = new DataSet("CompanyList");

            DataTable company = companyData.Tables.Add("company");
            company.Columns.Add("Id", typeof(Guid));
            company.Columns.Add("CompanyName", typeof(string));
            company.PrimaryKey = new DataColumn[] { company.Columns["Id"] };

            DataTable employee = companyData.Tables.Add("employee");
            employee.Columns.Add("Id", typeof(Guid));
            employee.Columns.Add("CompanyId", typeof(Guid));
            employee.Columns.Add("LastName", typeof(string));
            employee.Columns.Add("FirstName", typeof(string));
            employee.Columns.Add("Salary", typeof(decimal));
            employee.PrimaryKey = new DataColumn[] { company.Columns["Id"] };

            companyData.Relations.Add("Company_Employee",
                company.Columns["Id"],
                employee.Columns["CompanyId"]);

            return companyData;
        }
    }
}
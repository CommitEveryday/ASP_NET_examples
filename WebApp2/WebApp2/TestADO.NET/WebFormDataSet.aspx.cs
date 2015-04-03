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
            employee.PrimaryKey = new DataColumn[] { employee.Columns["Id"] };

            companyData.Relations.Add("Company_Employee",
                company.Columns["Id"],
                employee.Columns["CompanyId"]);

            return companyData;
        }

        private void PopulateDataSet(DataSet ds)
        {
            DataTable company = ds.Tables["Company"];
            DataTable employee = ds.Tables["Employee"];
            Guid coId, empId;
            coId = Guid.NewGuid();
            company.Rows.Add(coId, "Northwind Traders");
            empId = Guid.NewGuid();
            employee.Rows.Add(empId, coId, "JoeLast", "JoeFirst", 40.00);
            empId = Guid.NewGuid();
            employee.Rows.Add(empId, coId, "MaryLast", "MaryFirst", 70.00);
            empId = Guid.NewGuid();
            employee.Rows.Add(empId, coId, "SamLast", "SamFirst", 12.00);
            coId = Guid.NewGuid();
            company.Rows.Add(coId, "Contoso");
            empId = Guid.NewGuid();
            employee.Rows.Add(empId, coId, "SueLast", "SueFirst", 20.00);
            empId = Guid.NewGuid();
            employee.Rows.Add(empId, coId, "TomLast", "TomFirst", 68.00);
            empId = Guid.NewGuid();
            employee.Rows.Add(empId, coId, "MikeLast", "MikeFirst", 18.99);
        }

        private GridView GetGridView(int left, int top)
        {
            GridView gv = new GridView();
            gv.Style.Add(HtmlTextWriterStyle.Position, "absolute");
            gv.Style.Add(HtmlTextWriterStyle.Left, left.ToString()+"px");
            gv.Style.Add(HtmlTextWriterStyle.Top, top.ToString()+"px");
            gv.EnableViewState = false;
            form1.Controls.Add(gv);
            return gv;
        }

        private Label GetLabel(int left, int top)
        {
            Label lbl = new Label();
            lbl.Style.Add(HtmlTextWriterStyle.Position, "absolute");
            lbl.Style.Add(HtmlTextWriterStyle.Left, left.ToString() + "px");
            lbl.Style.Add(HtmlTextWriterStyle.Top, top.ToString() + "px");
            lbl.EnableViewState = false;
            form1.Controls.Add(lbl);
            return lbl;
        }

        protected void btCreateBind_Click(object sender, EventArgs e)
        {
            GridView gvCompany = GetGridView(275, 20);
            GridView gvEmployee = GetGridView(275, 125);
            DataSet companyList = GetDataSet();
            PopulateDataSet(companyList);
            gvCompany.DataSource = companyList;
            gvCompany.DataMember = "Company";
            gvEmployee.DataSource = companyList;
            gvEmployee.DataMember = "Employee";
            gvCompany.DataBind();
            gvEmployee.DataBind();
        }

        protected void btDataRelation_Click(object sender, EventArgs e)
        {
            Label lbl = GetLabel(275, 20);
            DataSet companyList = GetDataSet();
            PopulateDataSet(companyList);
            DataRelation dr = companyList.Relations["Company_Employee"];
            DataRow companyParent = companyList.Tables["company"].Rows[1];
            lbl.Text = companyParent["CompanyName"] + "<br />";
            foreach (DataRow employeeChild in companyParent.GetChildRows(dr))
            {
                lbl.Text += "&nbsp;&nbsp;&nbsp;" + employeeChild["Id"] + " "
                    + employeeChild["LastName"] + " "
                    + employeeChild["FirstName"] + " "
                    + string.Format("{0:C}", employeeChild["Salary"]) + "<br />";
            }
            lbl.Text += "<br /><br />";

            DataRow employeeParent = companyList.Tables["employee"].Rows[1];
            lbl.Text += employeeParent["Id"] + " "
                    + employeeParent["LastName"] + " "
                    + employeeParent["FirstName"] + " "
                    + string.Format("{0:C}", employeeParent["Salary"]) + "<br />";
            DataRow companyChild = employeeParent.GetParentRow(dr);
            lbl.Text += "&nbsp;&nbsp;&nbsp;" + companyChild["CompanyName"] + "<br />";
        }

        protected void btWriteXml_Click(object sender, EventArgs e)
        {
            DataSet companyList = GetDataSet();
            PopulateDataSet(companyList);
            string fileName = "CompanyList.xml";
            companyList.WriteXml(MapPath(fileName));
            Response.Redirect(fileName);
        }
    }
}
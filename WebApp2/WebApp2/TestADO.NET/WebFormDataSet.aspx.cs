using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

        protected void btWriteNestedXml_Click(object sender, EventArgs e)
        {
            DataSet companyList = GetDataSet();
            PopulateDataSet(companyList);
            companyList.Relations["Company_Employee"].Nested = true;
            foreach (DataTable dt in companyList.Tables)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    dc.ColumnMapping = MappingType.Attribute;
                }
            }
            string fileName = "CompanyListNested.xml";
            companyList.WriteXml(MapPath(fileName), XmlWriteMode.WriteSchema);
            companyList.WriteXmlSchema(MapPath("CompanyListNested.xsd"));
            Response.Redirect(fileName);
        }

        protected void btWriteDiffGram_Click(object sender, EventArgs e)
        {
            DataSet companyList = GetDataSet();
            DataTable company = companyList.Tables["company"];
            company.Rows.Add(Guid.NewGuid(), "Unchanged Company");
            company.Rows.Add(Guid.NewGuid(), "Modifed Company");
            company.Rows.Add(Guid.NewGuid(), "Deleted Company");
            company.AcceptChanges();
            company.Rows[1]["CompanyName"] = "Modifed Company 1";
            company.Rows[2].Delete();
            company.Rows.Add(Guid.NewGuid(), "Added Company");

            companyList.Relations["Company_Employee"].Nested = true;
            foreach (DataTable dt in companyList.Tables)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    dc.ColumnMapping = MappingType.Attribute;
                }
            }
            string fileName = "CompanyListDiffGram.xml";
            companyList.WriteXml(MapPath(fileName), XmlWriteMode.DiffGram);
            Response.Redirect(fileName);
        }

        protected void btReadNestedXml_Click(object sender, EventArgs e)
        {
            GridView gvCompany = GetGridView(275, 20);
            GridView gvEmployee = GetGridView(275, 125);
            DataSet companyList = new DataSet();
            string fileNameWithoutEnd = "CompanyListNested";
            companyList.ReadXmlSchema(MapPath(fileNameWithoutEnd + ".xsd"));
            companyList.ReadXml(MapPath(fileNameWithoutEnd + ".xml"));
            gvCompany.DataSource = companyList;
            gvCompany.DataMember = "Company";
            gvEmployee.DataSource = companyList;
            gvEmployee.DataMember = "Employee";
            gvCompany.DataBind();
            gvEmployee.DataBind();
        }

        protected void btSerializeToBinary_Click(object sender, EventArgs e)
        {
            DataSet companyList = GetDataSet();
            PopulateDataSet(companyList);
            companyList.RemotingFormat = SerializationFormat.Binary;
            string fileName = "CompanyList.bin";
            using (FileStream fs = new FileStream(MapPath(fileName),
                FileMode.Create))
            {
                BinaryFormatter fmt = new BinaryFormatter();
                fmt.Serialize(fs, companyList);
            }
            Label lbl = GetLabel(275, 20);
            lbl.Text = "File Saved as " + fileName;
        }

        protected void btDeserializeFromBinary_Click(object sender, EventArgs e)
        {
            GridView gvCompany = GetGridView(275, 20);
            GridView gvEmployee = GetGridView(275, 125);
            DataSet companyList;
            string fileName = "CompanyList.bin";
            using (FileStream fs = new FileStream(MapPath(fileName),
                FileMode.Open))
            {
                BinaryFormatter fmt = new BinaryFormatter();
                companyList = (DataSet)fmt.Deserialize(fs);
            }
            gvCompany.DataSource = companyList;
            gvCompany.DataMember = "Company";
            gvEmployee.DataSource = companyList;
            gvEmployee.DataMember = "Employee";
            gvCompany.DataBind();
            gvEmployee.DataBind();
        }

        protected void btTestMerge_Click(object sender, EventArgs e)
        {
            GridView gvCompany = GetGridView(275, 20);
            GridView gvEmployee = GetGridView(275, 125);
            DataSet original = GetDataSet();

            PopulateDataSet(original);

            original.Tables["Company"].Rows.Add(
                Guid.NewGuid(), "AdventureWorks");
            DataSet copy = original.Copy();
            DataRow aw = copy.Tables["Company"].Rows[0];
            aw["CompanyName"] = "AdventureWorks Changed";
            Guid empId;
            empId = Guid.NewGuid();
            copy.Tables["Employee"].Rows.Add(empId, aw["Id"],
                "MarkLast", "MarkFirst", 90.00m);
            empId = Guid.NewGuid();
            copy.Tables["Employee"].Rows.Add(empId, aw["Id"],
                "SueLast", "SueFirst", 41.00m);

            original.Merge(copy, false, MissingSchemaAction.Error);
            //MissingSchemaAction.AddWithKey);

            gvCompany.DataSource = original;
            gvCompany.DataMember = "Company";
            gvEmployee.DataSource = original;
            gvEmployee.DataMember = "Employee";
            gvCompany.DataBind();
            gvEmployee.DataBind();
        }
    }
}
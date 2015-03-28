using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

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
            GridView gv = AddGridView(form1);

            gv.DataSource = GetDataTable();
            gv.DataBind();
        }

        private string GetDataRowInfo(DataRow row, string columnName)
        {
            string retVal = string.Format("RowState: {0}<br />",
                row.RowState);
            foreach (DataRowVersion version in Enum.GetValues(typeof(DataRowVersion)))
            {
                if (row.HasVersion(version))
                {
                    retVal += string.Format("Version: {0} Value: {1}<br />",
                        version, row[columnName, version]);
                }
                else
                {
                    retVal += string.Format("Version: {0} does not exist.<br />",
                        version);
                }
            }
            return retVal;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Style.Add(HtmlTextWriterStyle.Position, "absolute");
            lbl.Style.Add(HtmlTextWriterStyle.Left, "275px");
            lbl.Style.Add(HtmlTextWriterStyle.Top, "20px");
            lbl.EnableViewState = false;
            form1.Controls.Add(lbl);
            DataRow dr = GetDataTable().Rows[0];
            dr.AcceptChanges();
            dr["FirstName"] = "Marie";
            dr.BeginEdit();
            dr["FirstName"] = "Marge";
            lbl.Text = GetDataRowInfo(dr, "Firstname");
            dr.EndEdit();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            GridView gv = AddGridView(form1);
            gv.DataSource = GetDataTable().Copy();
            gv.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView gv = AddGridView(form1);
            DataTable employee = GetDataTable();
            DataTable clone = employee.Clone();
            clone.ImportRow(employee.Rows[0]);
            gv.DataSource = clone;
            gv.DataBind();
        }

        private GridView AddGridView(HtmlForm form)
        {
            GridView gv = new GridView();
            gv.Style.Add(HtmlTextWriterStyle.Position, "absolute");
            gv.Style.Add(HtmlTextWriterStyle.Left, "275px");
            gv.Style.Add(HtmlTextWriterStyle.Top, "20px");
            gv.EnableViewState = false;
            form.Controls.Add(gv);
            return gv;
        }

        protected void btCreateXML_Click(object sender, EventArgs e)
        {
            DataTable employee = GetDataTable();
            string fileName = "employee.xml";
            employee.WriteXml(Server.MapPath(fileName));
            Response.Redirect(fileName);
        }

        protected void btCreateFormXML_Click(object sender, EventArgs e)
        {
            DataTable employee = GetDataTable();
            employee.TableName = "Person";
            employee.Columns["Eid"].ColumnMapping = MappingType.Attribute;
            employee.Columns["FirstName"].ColumnMapping = MappingType.Attribute;
            employee.Columns["LastName"].ColumnMapping = MappingType.Attribute;
            employee.Columns["Salary"].ColumnMapping = MappingType.Attribute;
            employee.Columns["LastName and FirstName"].ColumnMapping = MappingType.Hidden;
            string fileName = "Person.xml";
            employee.WriteXml(Server.MapPath(fileName));
            Response.Redirect(fileName);
        }

        protected void btCreateXMLwSchema_Click(object sender, EventArgs e)
        {
            DataTable employee = GetDataTable();
            employee.TableName = "Person";
            employee.Columns["Eid"].ColumnMapping = MappingType.Attribute;
            employee.Columns["FirstName"].ColumnMapping = MappingType.Attribute;
            employee.Columns["LastName"].ColumnMapping = MappingType.Attribute;
            employee.Columns["Salary"].ColumnMapping = MappingType.Attribute;
            employee.Columns["LastName and FirstName"].ColumnMapping = MappingType.Hidden;
            string fileName = "PersonWithSchema.xml";
            employee.WriteXml(Server.MapPath(fileName), XmlWriteMode.WriteSchema);
            Response.Redirect(fileName);
        }
    }
}
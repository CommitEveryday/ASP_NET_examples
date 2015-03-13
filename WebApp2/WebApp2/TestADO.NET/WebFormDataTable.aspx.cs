﻿using System;
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
            lastNameFirstName.Expression = "lastName + ', ' + firstName";
            employee.Columns.Add(lastNameFirstName);

            return employee;
        }
    }
}
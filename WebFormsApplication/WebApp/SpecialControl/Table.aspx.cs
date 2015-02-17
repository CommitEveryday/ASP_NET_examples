using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SpecialControl
{
    public partial class Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Table1.BorderWidth = 1;
            for (int row = 0; row < 5; row++)
            {
                TableRow tr = new TableRow();
                for (int column = 0; column < 3; column++)
                {
                    TableCell tc = new TableCell();
                    tc.Text = string.Format("Строка:{0} Ячейка:{1}", row, column);
                    tc.BorderWidth = 1;
                    tr.Cells.Add(tc);
                }
                Table1.Rows.Add(tr);
            }
        }
    }
}
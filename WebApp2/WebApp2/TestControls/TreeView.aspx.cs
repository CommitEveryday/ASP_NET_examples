using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.TestControls
{
    public partial class TreeView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TreeViewTest_SelectedNodeChanged(object sender, EventArgs e)
        {
            Response.Write("Value:" + TreeViewTest.SelectedNode.Value);
        }
    }
}
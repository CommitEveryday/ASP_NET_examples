using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.TestControls
{
    public partial class XmlControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Xml1.DocumentSource = @"~/XmlData/person.xml";
            Xml1.TransformSource = @"~/XmlData/person.xsl";
        }
    }
}
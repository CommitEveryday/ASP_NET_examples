using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;

namespace WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Default)); 

        protected void Page_Load(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
            Div1.InnerText = Text1.Value;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
            Div1.InnerText = Text1.Value;
        }
    }
}
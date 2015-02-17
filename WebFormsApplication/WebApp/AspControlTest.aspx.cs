using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class AspControlTest : System.Web.UI.Page
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 

        protected void Page_Load(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
            Label1.Text = Server.HtmlEncode(TextBox1.Text);
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
            CheckBox cb = sender as CheckBox;
            if (cb == null)
                return;
            if (cb.Checked)
                cb.Text = DateTime.Now.ToString();
        }

        protected void RadioChanged(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
            RadioButton rb = sender as RadioButton;
            if (rb == null)
                return;
            TextBox1.Text = rb.Text;
        }
    }
}
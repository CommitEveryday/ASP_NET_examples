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

        protected void Page_Init(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
            TextBox tb = new TextBox();
            tb.Visible = true;
            tb.ID = "tbID";
            tb.Text = "This is textbox!";
            tb.AccessKey = "Q";
            form1.Controls.Add(tb);
            log.Debug("TextBox created!");
            this.Button3.Style.Add(HtmlTextWriterStyle.Position, "absolute");
            this.Button3.Style.Add(HtmlTextWriterStyle.Top, "200px");
            this.Button3.Style.Add(HtmlTextWriterStyle.Left, "300px");
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
            TextBox txb = (TextBox)FindControl("tbID");
            txb.BackColor = System.Drawing.Color.Red;
        }
    }
}
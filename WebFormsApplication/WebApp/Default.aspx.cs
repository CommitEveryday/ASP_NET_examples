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
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            Literal lit1 = new Literal();
            Literal lit2 = new Literal();
            Literal lit3 = new Literal();
            string text = @"This is <font size=7>cool</font>";//<script>alert('hi!');</script>";
            lit1.Text = lit2.Text = lit3.Text = text;
            lit1.Mode = LiteralMode.Transform;
            lit2.Mode = LiteralMode.PassThrough;
            lit3.Mode = LiteralMode.Encode;
            DivLiteral.Controls.Add(lit1);
            DivLiteral.Controls.Add(lit2);
            DivLiteral.Controls.Add(lit3);
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            TextBox tb = new TextBox();
            tb.Visible = true;
            tb.ID = "tbID";
            tb.Text = "This is textbox! " + default(double).ToString();
            tb.AccessKey = "Q";
            form1.Controls.Add(tb);
            log.Debug("TextBox created!");
            this.Button3.Style.Add(HtmlTextWriterStyle.Position, "absolute");
            this.Button3.Style.Add(HtmlTextWriterStyle.Top, "200px");
            this.Button3.Style.Add(HtmlTextWriterStyle.Left, "300px");

            ListBox1.Items.Clear();
            foreach (TextBoxMode tbm in Enum.GetValues(typeof(TextBoxMode)))
            {
                ListBox1.Items.Add(tbm.ToString());
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
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

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
            CheckBox cb = sender as CheckBox;
            if (cb == null)
                return;
            cb.Text = cb.Checked ? "Checked" : "NotChecked";
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox1.SelectedItem == null)
                return;
            foreach (TextBoxMode tbm in Enum.GetValues(typeof(TextBoxMode)))
            {
                if (tbm.ToString() == ListBox1.SelectedItem.ToString())
                {
                    TextBox1.TextMode = tbm;
                    break;
                }
            }
            
        }

        protected void Button4_Command(object sender, CommandEventArgs e)
        {

        }
    }
}
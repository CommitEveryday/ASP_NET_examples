using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.TestControls
{
    public partial class Wizard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Wizard1.ActiveStepIndex = 0;
        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (Wizard1.WizardSteps[e.NextStepIndex].Title == "Summary")
            {
                Label1.Text = String.Empty;
                foreach (WizardStep ws in Wizard1.WizardSteps)
                    foreach (Control ctrl in ws.Controls)
                        if (ctrl is CheckBox)
                        {
                            CheckBox cb = (CheckBox)ctrl;
                            if (cb.Checked)
                                Label1.Text += cb.Text + "<br />";
                        }
            }
        }
    }
}
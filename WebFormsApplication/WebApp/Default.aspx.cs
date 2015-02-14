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

        private void Page_Init(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                ArgumentException argEx = new ArgumentException("inner agrument exception");
                NullReferenceException nullEx = new NullReferenceException("null ref exception", argEx);
                throw nullEx;
            }
            catch (Exception ex)
            {
                log.Error("Exception on Page_Init", ex);
            }
        }

        protected void Button1_Init(object sender, EventArgs e)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
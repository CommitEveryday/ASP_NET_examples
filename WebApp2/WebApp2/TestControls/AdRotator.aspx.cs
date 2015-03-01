using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.TestControls
{
    public partial class AdRotator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AdRotator1.AdvertisementFile = @"~/XmlData/ads.config";
            AdRotator1.Height = 256;
            AdRotator1.Width = 256;
        }
    }
}
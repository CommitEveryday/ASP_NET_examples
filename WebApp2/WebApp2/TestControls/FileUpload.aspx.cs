using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.TestControls
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                Label1.Text = "File length: " + FileUpload1.FileBytes.Length + "<br/>" +
                    "File name: " + FileUpload1.FileName + "<br/>" +
                    "MIME type: " + FileUpload1.PostedFile.ContentType;
                FileUpload1.SaveAs(MapPath("~/Uploads/" + FileUpload1.FileName));
            }
            else
            {
                Label1.Text = "No file received";
            }
        }
    }
}
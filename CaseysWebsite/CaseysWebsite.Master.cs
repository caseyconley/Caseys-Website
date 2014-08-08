using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CaseysWebsite1
{
    public partial class CaseysWebsite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNavHome_Click(object sender, EventArgs e)
        {
            ContentPlaceHolder masterBody = (ContentPlaceHolder)FindControl("MasterBody");
            if (masterBody != null)
            {
                masterBody.ID = "Default";
            }
            
        }
        protected void btnNavBlog_Click(object sender, EventArgs e)
        {

        }
        protected void btnNavContact_Click(object sender, EventArgs e)
        {

        }
        protected void btnNavOther_Click(object sender, EventArgs e)
        {

        }
    }
}
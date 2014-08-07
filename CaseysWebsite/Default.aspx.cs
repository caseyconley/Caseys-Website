using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CaseysWebsite1.Controls;

namespace CaseysWebsite1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BlogPost bp = (BlogPost)LoadControl("~/Controls/BlogPost.ascx");
            bp.Body = "i really like music";
            bp.Title = "music";
            bp.Date = DateTime.Now;
            BlogPost bp2 = (BlogPost)LoadControl("~/Controls/BlogPost.ascx");
            bp2.Body = "movies are cool";
            bp2.Title = "movies";
            bp2.Date = DateTime.Now;
            BlogPostPlaceholder.Controls.Add(bp);
            BlogPostPlaceholder.Controls.Add(bp2);
        }
    }
}
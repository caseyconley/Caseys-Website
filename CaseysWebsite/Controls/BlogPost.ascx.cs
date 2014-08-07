using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CaseysWebsite1.Controls
{
    public partial class BlogPost : System.Web.UI.UserControl
    {

        private string _blogTitle;
        private string _blogBody;
        public DateTime _blogDate;

        public BlogPost()
        {
        }

        public string Title
        {
            get
            {
                return _blogTitle;
            }
            set
            {
                _blogTitle = value;
            }
        }

        public string Body
        {
            get
            {
                return _blogBody;
            }
            set
            {
                _blogBody = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _blogDate;
            }
            set
            {
                _blogDate = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            lblBlogDate.Text = this.Date.ToShortDateString() + " " + this.Date.ToShortTimeString();
            lblBlogTitle.Text = this.Title;
            lblBlogBody.Text = this.Body;
        }
    }
}
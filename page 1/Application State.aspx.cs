using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace page_1
{
    public partial class Application_State : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblVisitors.Text = "Number Visitros : "+Application["Visitors"].ToString();
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Application["FirstName"] = txt1.Text;
            Application["LastName"] = txt2.Text;
            Response.Redirect("~/Session.aspx");
        }
    }
}
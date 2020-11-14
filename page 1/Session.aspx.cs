using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace page_1
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblVisitors.Text = "Number Visitros : " + Application["Visitors"].ToString();
        }

        protected void btnSessionTimeOut_Click(object sender, EventArgs e)
        {
            DisplaySessionTimeOut.Text = ": "+Session.Timeout.ToString()+ " Minutes ";
        }

        protected void btnSessionId_Click(object sender, EventArgs e)
        {
            DisplaySessionId.Text = "ID : " + Session.SessionID;
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Session["Location"] = txt5.Text;
            Session["Number"] = txt6.Text;
            Response.Redirect("~/MoveText.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace page_1
{
    public partial class Query_String : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblVisitors.Text = "Number Visitros : " + Application["Visitors"].ToString();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MoveText.aspx?name=" + txt3.Text);
        }
    }
}
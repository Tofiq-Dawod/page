using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace page_1
{
    public partial class page_2 : System.Web.UI.Page
    {
        static bool x = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblVisitors.Text ="Number Visitors : "+ Application["Visitors"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!chk1.Checked)
            {
                chk1.Checked = x;
                x = false;
            }
            else {
                chk1.Checked = x;
                x = true;
                    }
            Response.Write(Session.Timeout.ToString());
        }

        protected void btnset_Click(object sender, EventArgs e)
        {
            ViewState["FirstName"] = txt4.Text;
            ViewState["LastName"] = txt5.Text;
            txt4.Text = txt5.Text = "";
        }

        protected void btnrestore_Click(object sender, EventArgs e)
        {
            if (ViewState["FirstName"] != null && ViewState["LastName"] != null)
            {
                txt4.Text = ViewState["FirstName"].ToString();
                txt5.Text = ViewState["LastName"].ToString();
            }
        }
    }
}
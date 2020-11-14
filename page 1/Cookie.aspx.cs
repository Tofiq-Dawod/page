using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace page_1
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            HttpCookie Cookie = new HttpCookie("PhoneEmail");
            Cookie["Phone"] = txtphone.Text;
            Cookie["Email"] = txtemail.Text;
            Response.Cookies.Add(Cookie);
            Response.Redirect("~/Application State.aspx");
        }
    }
}
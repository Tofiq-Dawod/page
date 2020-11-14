using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace page_1
{
    public partial class page_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie Cookie = Request.Cookies["PhoneEmail"];
            if (Cookie!=null)
            {
                lblPhone.Text = "NumberPhone : "+Cookie["Phone"];
                lblEmail.Text = "Email : "+Cookie["Email"];
            }
            lblVisitors.Text = "Number Visitros : " + Application["Visitors"].ToString();
            if (!IsPostBack)
            {
                if (Session["Location"] != null && Session["Number"] != null)
                {
                    lblName1.Text = "Location : " + Session["Location"].ToString();
                    lblAge1.Text = "Your Age :" + Session["Number"].ToString();
                }
                string name = Request.QueryString.Get("name");
                txt1.Text = name;
                if (Application["FirstName"] != null && Application["LastName"] != null)
                {
                    lblFirstName.Text = "Hello Mr. " + Application["FirstName"].ToString();
                    lblLastName.Text = "How Are You : " + Application["LastName"].ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {  
                txt2.Text = txt1.Text;
                txt1.Text = "";   
        }
    }
}
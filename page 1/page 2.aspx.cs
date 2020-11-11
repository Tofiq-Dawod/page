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
            
        }
    }
}
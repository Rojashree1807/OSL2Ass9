using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAss9
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            Label1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label1.Text = "Customer Name : " + TextBox1.Text;
            Label1.Text += "Mobile No : " + TextBox2.Text;
            Label1.Text += "Email Id : " + TextBox3.Text;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
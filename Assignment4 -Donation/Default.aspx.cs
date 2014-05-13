using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogIn_Click(object sender, EventArgs e)
    {
        LogIn login = new LogIn(txtUserName.Text, txtPassword.Text);
        int personKey = login.ValidateLogin();
        if (personKey != 0)
        {
            Session["personkey"] = personKey;
            Response.Redirect("Welcome.aspx");
        }
        else
        {
            lblError.Text = "Invalid login";
        }
    }
}
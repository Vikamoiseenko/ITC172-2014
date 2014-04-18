using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AddPeople"] != null)
        {
            People people = (People)Session["AddPeople"];
            txtbLastName.Text = people.LastName;
            txtbEmail.Text = people.Email;
            txtbStreetAddress.Text = people.StreetAddress;
            txtbCity.Text = people.City;
            
            txtbZipCode.Text = people.ZipCode;
            txtbHomePhone.Text = people.HomePhone;
            /*txtbPassword.Text = people.Password.Tostring("c");*/

        }
            
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       /* string last = tx*/
        Response.Redirect("Default2.aspx" + txtbLastName.Text);
    }
}
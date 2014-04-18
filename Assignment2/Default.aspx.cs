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
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
            People people = new People();
            people.FirstName = txtbFirstName.Text;
            people.LastName = txtbLastName.Text;
            people.Email = txtbEmail.Text;
            people.StreetAddress = txtbStreetAddress.Text;
            people.City = txtbCity.Text;
            people.State = txtbState.Text;
            people.ZipCode = txtbZipCode.Text;
            people.HomePhone = txtbHomePhone.Text;
            people.Password = double.Parse(txtbPassword.Text);
            people.ConfirmPassword = double.Parse(txtbConfirmPassword.Text);

            Session["AddPeople"] = people;

            Response.Redirect("Default2.aspx");

        
       }
   
}

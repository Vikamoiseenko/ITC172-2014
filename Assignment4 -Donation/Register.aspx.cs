using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Person c = new Person();
        c.LastName = txtLastName.Text;
        c.FirstName = txtFirstName.Text;
        c.Email = txtEmail.Text;
        c.Password = txtPassword.Text;
        c.Address = txtAddress.Text;
        c.Apartment = txtApartment.Text;
        c.State = txtState.Text;
        c.Zipcode = txtZip.Text;
        c.DonationAmount = txtDonation.Text;
        c.DonationDate = txtDate.Text;
       

        //this 
        ManagePerson mc = new ManagePerson();
        try
        {
            mc.WriteCustomer(c);
            lblError.Text = "Thanks for registering";
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
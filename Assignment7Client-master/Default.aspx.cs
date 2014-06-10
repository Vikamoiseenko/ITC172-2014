using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeReference;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGetEmployee_Click(object sender, EventArgs e)
    {
        EmployeeReference.EmployeeServiceClient esc = new EmployeeServiceClient();
        Employee emp = esc.GetEmployee(int.Parse(txtID.Text));
        txtFirstName.Text = emp.FirstName;
        txtLastName.Text = emp.LastName;
        txtStatus.Text = emp.Status;
        txtSalary.Text = emp.MonthlySalary.ToString();
    }
}
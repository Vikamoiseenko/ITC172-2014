﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string LastName = Request.QueryString["LastName"];
        lblThankYou.Text = "Thank you for Registering" + LastName;
    }
}
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Registration</h1>
        <table>
            <tr>
                <td>First Name</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
            </tr>
               <tr>
                <td>Last Name</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
                   </tr>
                   <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                       <td>
                           <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtEmail" runat="server" ErrorMessage="Invalid Email"></asp:RegularExpressionValidator>
            </td>
               </tr>
            <tr>
                <td>Create Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
               </tr>
            <tr>
                <td>Confirm Password</td>
                <td>
                    <asp:TextBox ID="txtConfirm" runat="server" TextMode="Password"></asp:TextBox><br /></td>
               </tr>
            <tr>
                <td>Enter Street</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
                <td> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtAddress" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                </td>
               </tr>
            <tr>
                <td>Enter Apartment</td>
                <td>
                    <asp:TextBox ID="txtApartment" runat="server"></asp:TextBox></td>
               </tr>
            <tr>
                <td>Enter State</td>
                <td>
                    <asp:TextBox ID="txtState" runat="server"></asp:TextBox></td>
               </tr>
            <tr>
                <td>Enter Zipcode</td>
                <td>
                    <asp:TextBox ID="txtZip" runat="server"></asp:TextBox></td>
               </tr>
            <tr>
                <td>Enter Donation Amount</td>
                <td>
                    <asp:TextBox ID="txtDonation" runat="server"></asp:TextBox></td>
               </tr>
             <tr>
                <td>Enter Donation Date</td>
                <td>
                    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox></td>
               </tr>

            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Regist" OnClick="btnSubmit_Click" /></td>
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </tr>
        </table>
        <p>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Default.aspx" OnClick="LinkButton1_Click">Register>Log in</asp:LinkButton>
        </p>
    </div>
    </form>
</body>
</html>

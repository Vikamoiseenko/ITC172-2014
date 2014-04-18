<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>People</h2>
    <table>
        <tr>
            <td>First Name</td>
            <td>
                <asp:TextBox ID="txtbFirstName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Last Name</td>
            <td>
                <asp:TextBox ID="txtbLastName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtbLastName" ErrorMessage="Last Name is required" ></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="txtbEmail" runat="server"></asp:TextBox></td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtbEmail" ErrorMessage="Invalid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Street Address</td>
            <td>
                <asp:TextBox ID="txtbStreetAddress" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ControlToValidate="txtbStreetAddress" ErrorMessage="Street Address is Required" ></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>City</td>
            <td>
                <asp:TextBox ID="txtbCity" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                    ControlToValidate="txtbCity" ErrorMessage="City is Required" ></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>State</td>
            <td>
                <asp:TextBox ID="txtbState" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Zip Code</td>
            <td>
                <asp:TextBox ID="txtbZipCode" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                    ControlToValidate="txtbZipCode" ErrorMessage="Zip code is Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Home Phone</td>
            <td>
                <asp:TextBox ID="txtbHomePhone" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                    ControlToValidate="txtbHomePhone" ErrorMessage="Home phone is Required" ></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtbPassword" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Confirm Password</td>
            <td>
                <asp:TextBox ID="txtbConfirmPassword" runat="server"></asp:TextBox></td>
        </tr>
 <tr>
     <td>
         <asp:Button ID="btnSubmit" runat="server" Text="Next" OnClick="btnSubmit_Click"  />
     </td>
     <td>&nbsp;</td>
 </tr>

    </table>
</asp:Content>


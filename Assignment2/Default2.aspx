<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Is is correct information?</h3>
        <table>
        <tr>
            <td>Last Name</td>
            <td>
                <asp:TextBox ID="txtbLastName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="txtbEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Street Address</td>
            <td>
                <asp:TextBox ID="txtbStreetAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>City</td>
            <td>
                <asp:TextBox ID="txtbCity" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Zip Code</td>
            <td>
                <asp:TextBox ID="txtbZipCode" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Home Phone</td>
            <td>
                <asp:TextBox ID="txtbHomePhone" runat="server"></asp:TextBox>
            </td>
        </tr>
 <tr>
     <td>
         <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"  />
     </td>
     <td>
      <td>
         <asp:Label ID="lblError" runat="server" Text=""></asp:Label>     </td>

         <td>&nbsp;</td>
 </tr>
    </table>

</asp:Content>


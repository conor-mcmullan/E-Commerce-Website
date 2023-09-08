<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="adminLogin.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            font-weight: normal;
            text-decoration: underline;
            font-size: x-large;
        }
        .auto-style5 {
            width: 440px;
            float: left;
            margin-left:20%;
            margin-bottom:50px;
        }
        .newDiv{
            float:left;
        }
        .auto-style6 {
            width: 136px;
        }
        .auto-style7 {
            width: 355px;
            margin-left: 269px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 class ="auto-style3">
        <strong style="color: #64BFF0">Logon Page</strong></h3>

    <div class="newDiv"></div>
    <table class="auto-style5" style="color: #64BFF0; font-family: Calibri; font-size: medium; font-style: normal">
      <tr>
        <td>
          E-mail address:</td>
        <td>
          <asp:TextBox ID="txtEmail" runat="server" /></td>
        <td class="auto-style6">
          <asp:RequiredFieldValidator ID="rfvEmail" 
            ControlToValidate="txtEmail"
            Display="Dynamic" 
            ErrorMessage="Cannot be empty." 
            runat="server" ForeColor="Red" />
        </td>
      </tr>
      <tr>

        <td>
          Password:</td>
        <td>
          <asp:TextBox ID="txtPassword" TextMode="Password" 
             runat="server" />
        </td>
        <td class="auto-style6">
          <asp:RequiredFieldValidator ID="rfvPassword" 
            ControlToValidate="txtPassword"
            ErrorMessage="Cannot be empty." 
            runat="server" ForeColor="Red" />
        </td>
      </tr>
      <tr>
        <td>
          Remember me?</td>
        <td>
          <asp:CheckBox ID="chkPersist" runat="server" /></td>
      </tr>
    </table>



    <br />
    <br />
    <br />


    <div class="auto-style7">
    <asp:ImageButton ID="btnSubmit" runat="server" onclick="btnSubmit_Click" Height="30px" Width="80px" ImageUrl="~/images/extra/buttons/btnLogin.png" />
    &nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblMsg" ForeColor="Red" runat="server" />
    </div>
    <br /><br />

</asp:Content>




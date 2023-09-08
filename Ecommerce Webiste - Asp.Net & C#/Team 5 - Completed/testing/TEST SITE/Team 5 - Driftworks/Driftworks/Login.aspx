<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

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
            margin-right: 75px;
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
        .auto-style8 {
            width: 130px;
            height: 100px;
        }
        .auto-style10 {
            margin-left: 0px;
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



    <br /><br />
    
    
    <div class="auto-style8" style="border: thin solid #64BFF0; margin-right:0px; margin-left:700px;">
    <asp:Label ID="lblAdminAccess" runat="server" Text="Admin Facility"></asp:Label>
    <br />
    <asp:ImageButton ID="imgAdminAcess" runat="server" ImageUrl="~/images/extra/maintenance.jpg" height="79" width="126" OnClick="imgAdminAcess_Click" CssClass="auto-style10" />
    <br />
    </div>
    <br />

    <div class="auto-style7">
    <asp:ImageButton ID="btnSubmit" runat="server" onclick="btnSubmit_Click" Height="30px" Width="80px" ImageUrl="~/images/extra/buttons/btnLogin.png" />
    &nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="hylRegister" runat="server" OnClick="hylRegister_Click" Height="30px" Width="95px" ImageUrl="~/images/extra/buttons/btnRegister.png"  />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblMsg" ForeColor="Red" runat="server" />
    </div>
    <br /><br />

</asp:Content>




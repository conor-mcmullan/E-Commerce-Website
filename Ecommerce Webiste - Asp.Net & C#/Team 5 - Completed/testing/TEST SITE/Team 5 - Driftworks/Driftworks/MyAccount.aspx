<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="MyAccount.aspx.cs" Inherits="MyAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            height: 22px;
            width: 133px;
        }
        .table {
            width: 949px;
        }
        .auto-style5 {
            width: 356px;
            margin-left: 302px;
            margin-right: 0px;
        }
        .auto-style6 {
            width: 263px;
            color: #000000;
        }
        .auto-style7 {
            height: 22px;
            width: 263px;
        }
        .auto-style8 {
            width: 133px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>


    <br />


</div>
    <div>


        <table class="auto-style5">
            <tr>
                <td class="auto-style8">
    <asp:Label ID="lblIdentLastName" runat="server" Text="LastName:"></asp:Label>
                    <br />
                    <br />
                </td>
                <td class="auto-style6">
    <asp:Label ID="lblLastName" runat="server"></asp:Label>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
    <asp:Label ID="lblIdentFName" runat="server" Text="FirstName:"></asp:Label>
                    <br />
                    <br />
                </td>
                <td class="auto-style6">
    <asp:Label ID="lblFirstName" runat="server"></asp:Label>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
    <asp:Label ID="lblIdentEmail" runat="server" Text="Email:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
    </td>
                <td class="auto-style6">
    <asp:Label ID="lblEmail" runat="server"></asp:Label>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
    <asp:Label ID="lblIdentAddress" runat="server" Text="Address:"></asp:Label>
                    <br />
                    <br />
                </td>
                <td class="auto-style7">
    <asp:Label ID="lblCustAddress" runat="server"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
    <asp:Label ID="lblIdentCity" runat="server" Text="City:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;<br />
                    <br />
                </td>
                <td class="auto-style6">
    <asp:Label ID="lblCity" runat="server"></asp:Label>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
    <asp:Label ID="lblIdentPostode" runat="server" Text="PostCode:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
    </td>
                <td class="auto-style7">
    <asp:Label ID="lblPostCode" runat="server"></asp:Label>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
    <asp:Label ID="lblIdentPassword" runat="server" Text="Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    <br />
                </td>
                <td class="auto-style7">
    <asp:Label ID="lblPassword" runat="server"></asp:Label>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
    <asp:Label ID="lblIdentPhone" runat="server" Text="PhoneNumber:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
    </td>
                <td class="auto-style6">
    <asp:Label ID="lblPhone" runat="server"></asp:Label>
                    <br />
                    <br />
                </td>
            </tr>
        </table>


    </div>
    <br />
</asp:Content>


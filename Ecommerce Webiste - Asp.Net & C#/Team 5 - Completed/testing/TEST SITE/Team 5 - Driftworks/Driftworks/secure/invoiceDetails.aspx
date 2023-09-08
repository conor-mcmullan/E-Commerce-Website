<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="invoiceDetails.aspx.cs" Inherits="secure_invoiceDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblTitle" runat="server" Text="Invoice Details" ForeColor="Black"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblInvoiceNum" runat="server" ForeColor="Black"></asp:Label>
    <br />
    <br />
    <br />
    <asp:ImageButton ID="btnComplete" runat="server" OnClick="btnComplete_Click" Height="30px" Width="90px" ImageUrl="~/images/extra/buttons/btnCheckout.png" />
    <br />
</asp:Content>


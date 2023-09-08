<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="confirmProductEdit.aspx.cs" Inherits="secure_checkout" Trace="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style3 {
        color: #000000;
    }
    .auto-style5 {
        border-style: none;
        border-color: inherit;
        border-width: 0px;
        margin: 10px 10px 10px 171px;
        width: 350px;
        background-repeat: no-repeat;
        background-position: 0px 0px;
        background-color: #ffcccc;
        float: left;
        width: 609px;
    }
    .auto-style6 {
        border-style: none;
        border-color: inherit;
        border-width: 0px;
        padding: 7px;
        margin: 0px;
        width: 593px;
        background-repeat: no-repeat;
        background-position: 0px 100%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="pagetitle">
    
        <asp:Label ID="lblTitle" runat="server" Text="Checkout Page"></asp:Label>
    
    </div>
     <div class="auto-style5" style="background-color: #64bff0">
        <div class="auto-style6">
            <asp:Label ID="lblBasket" runat="server" CssClass="columntitle" 
                Text="Updated Product Details" ForeColor="Black"></asp:Label>
            <br />
            <asp:Label ID="lblItems" runat="server" CssClass="auto-style3"></asp:Label>
            <br />
            &nbsp;
            <br />
        </div>
    </div>

    <div class="clearfloat" style="background-color: white">
        &nbsp;<asp:ImageButton ID="btnCancel" runat="server" OnClick="btnCancel_Click" Height="30px" Width="70px" ImageUrl="~/images/extra/buttons/btnCancel.png" />
        &nbsp;<asp:ImageButton ID="btnInvoice" runat="server" OnClick="btnInvoice_Click" Height="30px" Width="70px"  ImageUrl="~/images/extra/buttons/btnConfirm.png" />
    </div>
</asp:Content>




<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            font-size: x-large;
            font-family: Arial, Helvetica, sans-serif;
            color: #000080;
            text-align: left;
        }
        .auto-style5 {
            text-align: center;
        }

        

        .auto-style6 {
            color: #64BFF0;
        }

        

        .auto-style7 {
            border-style: none;
            border-color: inherit;
            border-width: 0px;
            background-color: #ffcccc;
            margin: 10px 10px 10px 213px;
            width: 512px;
            background-position: 0px 0px;
            float: left;
        }

        

        .auto-style8 {
            border-style: none;
            border-color: inherit;
            border-width: 0px;
            padding: 7px;
            margin: 0px;
            width: 495px;
            background-position: 0px 100%;
        }

        

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <p>
        <asp:Label ID="lblTitle" runat="server" CssClass="pagetitle" 
            Text="Shopping Cart"></asp:Label>
        <br />
    </p>
    <div class="auto-style7" style="background-color: #64bff0">
        <div class="auto-style8">
            
            <asp:Label ID="lblName" runat="server" ForeColor="White"></asp:Label>
            <br />
            <asp:ListBox ID="lstName" runat="server" Width="497px"></asp:ListBox>
            
        </div>
    </div>
    <br /><br /><br /><br /><br />
    <%--<div class="threeColumnbox" style="background-color: #64bff0">
        <div class="threeColumninnerbox">
            
            <asp:Label ID="lblPrice" runat="server" Text="Price" ForeColor="White"></asp:Label>
            <br />
            <asp:ListBox ID="lstPrice" runat="server"></asp:ListBox>
            
        </div>
    </div>
    <div class="threeColumnbox" style="background-color: #64bff0">
        <div class="threeColumninnerbox">
            
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" ForeColor="White"></asp:Label>
            <br />
            <asp:ListBox ID="lstQuantity" runat="server"></asp:ListBox>
            
        </div>
    </div>--%>
    <p>
        <asp:Label ID="lblTotal" runat="server" CssClass="auto-style4" BackColor="#64BFF0" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Text-Align="left" ForeColor="Black"></asp:Label>
    </p>
    <p class="auto-style5">
        <asp:ImageButton ID="btnEmpty" runat="server" OnClick="btnEmpty_Click" Height="35px" Width="120px" ImageUrl="~/images/extra/buttons/btnEmptyBasket.png" />
&nbsp;&nbsp;
        <asp:ImageButton ID="btnRemove" runat="server" OnClick="btnRemove_Click" Height="35px" Width="120px" ImageUrl="~/images/extra/buttons/btnRemoveItem.png" />
&nbsp;&nbsp;
        <asp:ImageButton ID="btnPurchase" runat="server" OnClick="btnPurchase_Click" ImageUrl="~/images/extra/buttons/btnContinue.png" Height="35px" Width="100px" />
    </p>

</asp:Content>


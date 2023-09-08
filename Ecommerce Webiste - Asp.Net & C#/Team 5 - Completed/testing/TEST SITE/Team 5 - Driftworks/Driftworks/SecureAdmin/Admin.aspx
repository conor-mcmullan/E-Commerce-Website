<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="SecureAdmin_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css">
        
        .btnStyles {
        background-color:#64BFF0;
        width:150px;
        color:white;
        font-family:Calibri;
        font-size:medium;
        }
        .auto-style3 {
            font-size: medium;
            font-family: Arial, Helvetica, sans-serif;
            color: #000000;
            text-align: center;
            align-content: center;
            margin-left: 200px;
            text-align:left;
        }
        .auto-style4 {
            text-align: left;
        }
    </style>

    <br /><br />
        <div class="auto-style4">
        <asp:Table ID="Table1" runat="server" CssClass="auto-style3" CellPadding="1" CellSpacing="1" GridLines="Both" Width="540px" >
                <asp:TableRow >
                    <asp:TableCell ColumnSpan="2" Font-Size="Large" ForeColor="Black" Font-Underline="True" Font-Bold="True">
                        <p align="center">Admin Products Page</p>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Button will open a page that is designed for the ability to view,
                        select and re order stock for an item that has a stock level lower 
                        that its re order level.
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:ImageButton ID="btnReOrders" runat="server" OnClick="btnReOrders_Click" ImageUrl="~/images/extra/buttons/btnReOrderAProduct.png" Height="30px" Width="150px" />
                    </asp:TableCell>
                </asp:TableRow>
            <asp:TableRow>
                    <asp:TableCell>
                     Button will open a page that will display only the products 
                     that have been removed from the websites product listings.
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:ImageButton ID="btnRemoved" runat="server" OnClick="btnRemoved_Click" ImageUrl="~/images/extra/buttons/btnRemovedProducts.png" Height="30px" Width="150px" />
                    </asp:TableCell>
                </asp:TableRow>
            <asp:TableRow>
                    <asp:TableCell>
                    Button will open a page that will show all of the products that can be removed 
                    from the current product listings.
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:ImageButton ID="btnDeleteProduct" runat="server" OnClick="btnDeleteProduct_Click" ImageUrl="~/images/extra/buttons/btnRemoveAProduct.png" Height="30px" Width="150px" />
                    </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                    <asp:TableCell>
                     Button will open a page that will allow a new product to be added to the database
                     aswell as the product listings.
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:ImageButton ID="btnAddProduct" runat="server" OnClick="btnAddProduct_Click" ImageUrl="~/images/extra/buttons/btnNewProduct.png" Height="30px" Width="100px" />
                    </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                    <asp:TableCell>
                    Button will open a page that shall allow all product details to be edited.
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:ImageButton ID="btnEditProduct" runat="server" OnClick="btnEditProduct_Click" ImageUrl="~/images/extra/buttons/btnEditAProduct.png" Height="30px" Width="120px" />
                    </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div> 
    <br /><br />

       </asp:Content>

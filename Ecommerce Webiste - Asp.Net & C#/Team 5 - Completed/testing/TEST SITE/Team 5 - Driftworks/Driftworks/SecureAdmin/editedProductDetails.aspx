<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="editedProductDetails.aspx.cs" Inherits="productDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style3 {
            font-size: medium;
            font-family: Arial, Helvetica, sans-serif;
            color: #000000;
            text-align:left;
            width:400px;
            text-wrap:avoid;
        }
        .auto-style4 {
            margin-left: 23px;
            text-align: left;
        }

        .prodets {
            float: left;
            margin-left: 20px;
        }
        
        #imgProduct {
        float: right;
        margin-right: 20px;
        }


        .auto-style5 {
            text-decoration: underline;
            color:#64bff0
        }


    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>
        <asp:Label ID="lblPageTitle" runat="server" Text="Edit Product Details" CssClass="auto-style5"></asp:Label>
    </h1>
    <div class="prodets">
    <asp:Table ID="Table1" runat="server" CssClass="auto-style4" Width="555px" Font-Size="Medium">

            <asp:TableRow>
                <asp:TableCell>Product ID: </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtProductID" runat="server" CssClass="auto-style3" ReadOnly="True"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Product Name: </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtProductName" runat="server" CssClass="auto-style3" ></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>Description: </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtProductDesc" runat="server" CssClass="auto-style3" ></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>Unit Price: £</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtUnitPrice" runat="server" CssClass="auto-style3" ReadOnly="True"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>Retail Price: £</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtRetailPrice" runat="server" CssClass="auto-style3" ></asp:TextBox>
                </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>Stock Level: </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtStockLevel" runat="server" CssClass="auto-style3" ReadOnly="True"></asp:TextBox>
                </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>Re-Order Level: </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtReOrderLevel" runat="server" CssClass="auto-style3" ></asp:TextBox>
                </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>Category ID: </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtCategoryID" runat="server" CssClass="auto-style3"  ReadOnly="True"></asp:TextBox>
                </asp:TableCell>
        </asp:TableRow>
        
    </asp:Table>
    <br /><br /><br />
    </div>
    
    <asp:Image ID="imgProduct" class="proImage" runat="server" Height="200px" Width="200px" BorderStyle="Solid" BorderWidth="1px" />
    
    
    <br />
    <asp:DropDownList ID="ddlStock" runat="server" ForeColor="#64BFF0" Visible="False">
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>10</asp:ListItem>
        <asp:ListItem>15</asp:ListItem>
        <asp:ListItem>20</asp:ListItem>
        <asp:ListItem>25</asp:ListItem>
        <asp:ListItem>30</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="btnAdd" runat="server" Text="Add to Cart" OnClick="btnAdd_Click" ImageUrl="~/images/extra/buttons/btnChange.png" Height="30px" />
    <br />
    <p>
    </p>
</asp:Content>


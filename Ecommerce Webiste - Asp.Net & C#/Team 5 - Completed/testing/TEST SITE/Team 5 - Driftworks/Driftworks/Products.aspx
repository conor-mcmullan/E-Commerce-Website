<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <link href="~/styles/StyleMaster.css" rel="stylesheet" type="text/css" />
    
    <style type="text/css">
        .midGrid 
        {
            /*margin: 5% 10% 5% 10%;*/
            margin-left:25%;
            margin-right:25%;
            align-content:center;
            align-items:center;
            text-align: center;
        }

    </style>
    
    <p>
        <br />


        <div class="midGrid">
        <asp:GridView ID="dgvProducts" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="dgvProducts_PageIndexChanging" OnSelectedIndexChanged="dgvProducts_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            
            <Columns>
            
            <asp:CommandField ShowSelectButton="True" SelectText="<img src='images/extra/buttons/btnAddToCart.png' border=0 title='Add to cart'>"></asp:CommandField>
                <asp:BoundField DataField="ProductID" HeaderText="ID" >
                </asp:BoundField>
                <asp:BoundField DataField="ProductName" HeaderText="Name">
                <ControlStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="RetailPrice" DataFormatString="{0:c}" HeaderText="Price" />
                <asp:BoundField DataField="ImageFile" HeaderText="Image File" Visible="False" />
                
                <asp:ImageField DataImageUrlField="ImageFile" HeaderText="Image">
                    <ControlStyle Height="50px" Width="50px" />
                </asp:ImageField>
            
            </Columns>
            
            <FooterStyle BackColor="White" ForeColor="#64bff0" />
            <HeaderStyle BackColor="#64bff0" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#64bff0" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle ForeColor="Black" />
            <SelectedRowStyle BackColor="#64bff0" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#64bff0" />
            <SortedAscendingHeaderStyle BackColor="#64bff0" />
            <SortedDescendingCellStyle BackColor="#64bff0" />
            <SortedDescendingHeaderStyle BackColor="#64bff0" />
        
        </asp:GridView>
        </div>


    <p>
    </p>
</asp:Content>


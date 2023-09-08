<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="createProduct.aspx.cs" Inherits="createAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <style type="text/css">
        .auto-style3 {
            text-align:left;
            font-size:medium;
            color: #000000;
            margin-left: 50px;
            width: 185px;
        }
        .auto-style4 {
            width: 110px;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style6 {
            width: 110px;
            height: 26px;
        }
        .auto-style7 {
            margin-left: 50px;
            width: 185px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
            text-align: left;
            width: 158px;
        }
        .auto-style9 {
            text-align: left;
            width: 158px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div class="regTable">
    <table style="width: 744px" >
        <tr>
            <td class="tabHeader" colspan="4">
                Please enter the product details below: 
            </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="auto-style9">Product ID:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtProductID" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNewpassword" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="auto-style9">Product Name:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtProductName" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNewpassword" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="auto-style9">Product Description:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtProductDescription" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNewpassword" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="auto-style9">Unit Price: £</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtUnitPrice" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNewpassword" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="auto-style9">Retail Price: £</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtRetailPrice" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNewpassword" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>--%>
           </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="auto-style9">Image File:</td>
            <td class="auto-style4">
                <asp:FileUpload ID="fulProductImage" runat="server" />
            </td>
            <td class="auto-style3">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNewpassword" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>--%>
                <asp:Label ID="lblImgUrl" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="auto-style9">Stock Level:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtStockLevel" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNewpassword" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style8">Re Order Level:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtReOrderLevel" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style7">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNewpassword" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">Category ID:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtCategoryID" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="tabHeader" colspan="3">
            
            <asp:CheckBox ID="chkAgree" runat="server" Text=" Agree to terms &amp; conditions:" TextAlign="Left" /> <!-- ADD A CHECK BOX & A BUTTON AND VALIDATORS-->
            
            </td>
            <td class="auto-style3">
                <asp:Label ID="lblAgree" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="tabHeader" colspan="4">
                <asp:ImageButton ID="btnRegister" runat="server" OnClick="btnRegister_Click" ImageUrl="~/images/extra/buttons/btnAddProduct.png" Height="35px" Width="105px" />
            </td>
        </tr>
        
    </table>

        </div>

    

    <br />


</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="createAccount.aspx.cs" Inherits="createAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <style type="text/css">
        .auto-style3 {
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
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div class="regTable">
    <table style="width: 744px" >
        <tr>
            <td class="tabHeader" colspan="4">
                Please enter your details below: 
            </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="fieldName">Email:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtNewemail" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter a valid email address" ValidationExpression="^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"></asp:RegularExpressionValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="fieldName">Last Name:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtNewlastname" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNewlastname" ErrorMessage="Please enter your last name"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="fieldName">First Name:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtNewfirstName" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNewlastname" ErrorMessage="Please enter your last name"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="fieldName">Address:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtNewaddress" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNewaddress" ErrorMessage="Please enter your address"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="fieldName">City:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtNewcity" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtNewcity" ErrorMessage="Please enter your city"></asp:RequiredFieldValidator>--%>
           </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="fieldName">Postcode:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtNewpostcode" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtNewpostcode" ErrorMessage="Please enter your postcode" ValidationExpression="[A-Z][A-Z]\d{1,2}\s\d{1}[A-Z][A-Z]"></asp:RegularExpressionValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="emptyCol"></td>
            <td class="fieldName">Phone Number:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtNewphonenumber" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator" runat="server" ControlToValidate="txtNewphonenumber" ErrorMessage="Please enter a valid phone number" ValidationExpression="^((\(?0\d{4}\)?\s?\d{3}\s?\d{3})|(\(?0\d{3}\)?\s?\d{3}\s?\d{4})|(\(?0\d{2}\)?\s?\d{4}\s?\d{4}))(\s?\#(\d{4}|\d{3}))?$"></asp:RegularExpressionValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style5">Password:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtNewpassword" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style7">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNewpassword" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>--%>
            </td>
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
                <asp:ImageButton ID="btnRegister" runat="server" OnClick="btnRegister_Click" ImageUrl="~/images/extra/buttons/btnContinue.png" Height="30px" Width="85px" />
            </td>
        </tr>
        
    </table>

        </div>

    

    <br />


</asp:Content>


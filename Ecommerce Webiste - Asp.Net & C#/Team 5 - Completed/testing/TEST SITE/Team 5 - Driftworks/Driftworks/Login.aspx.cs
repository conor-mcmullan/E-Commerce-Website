using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        Customer custObj = Customer.checkLogin(txtEmail.Text,
                  
                                        txtPassword.Text);

        //********
        // custObj.storeEmail(txtEmail.Text);
        //********


        if (custObj != null)
        {
            Session["customerObj"] = custObj;

            System.Web.Security.FormsAuthentication.
                        RedirectFromLoginPage(custObj.getFullName(), chkPersist.Checked);

        }
        //else if (txtEmail.Text=="ADMIN" && txtPassword.Text=="ADMIN")
        //{
        //    Session["ADMIN"] = "ADMIN";
        //    Response.Redirect("~/SecureAdmin/Admin.aspx");
        //}
        else
        {
            lblMsg.Text = "Invalid credentials. Please try again.";
        }

    }

    protected void hylRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/createAccount.aspx");
    }

    protected void imgAdminAcess_Click(object sender, ImageClickEventArgs e)
    {
      // Response.Redirect("~/SecureAdmin/adminLogin.aspx");
        Response.Redirect("~/adminLogin.aspx");
    }
}
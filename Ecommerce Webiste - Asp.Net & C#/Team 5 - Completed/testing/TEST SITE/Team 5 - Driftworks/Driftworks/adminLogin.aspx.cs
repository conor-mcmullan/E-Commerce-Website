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
        if (Session["customerObj"] != null || Session["ShoppingBasket"] != null)
        {
            Response.Redirect("~/Home.aspx");
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        Admin adminObj = Admin.checkAdminLogin(txtEmail.Text,txtPassword.Text);

        if (adminObj != null)
        {
            Session["ADMIN"] = adminObj;
            System.Web.Security.FormsAuthentication.
                        RedirectFromLoginPage(adminObj.getEmail(), chkPersist.Checked);
        }     
        else
        {
            lblMsg.Text = "Invalid credentials. Please try again.";
        }

    }

}
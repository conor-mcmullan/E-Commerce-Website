using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Template : System.Web.UI.MasterPage
{

   protected void Page_Load(object sender, EventArgs e)
   {
        btnCart.Text = "Cart (" + CartItem.getInCartCount()+ ")";

        if (Session["customerObj"] != null)
        {
            btnLogin.Visible = false;
            btnLogout.Visible = true;
            btnAdminProducts.Visible = false;
        }
        else if (Session["ADMIN"] != null)
        {
            // set the stuff that needs to be invisible 
            btnCheckout.Visible = false;
            btnCart.Visible = false;
            btnProducts.Visible = false;
            // set the visible stuff 
            btnLogout.Visible = true;
            btnAdminProducts.Visible = true;
            btnLogin.Visible = false;
        }
        else {
            btnLogout.Visible = false;
            btnAdminProducts.Visible = false;
            btnLogin.Visible = true;
        }
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Home.aspx");
    }

    protected void btnAdminProducts_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/SecureAdmin/Admin.aspx");
    }
    
    protected void btnCart_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/ShoppingCart.aspx");
    }

    protected void btnCheckout_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/secure/Checkout.aspx");
    }
    
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        if (Session["customerObj"] != null)
        { Session.Remove("customerObj"); }

        if (Session["ADMIN"] != null)
        { Session.Remove("ADMIN"); }

        if (Session["ShoppingBasket"] != null)
        { Session.Remove("ShoppingBasket"); }

        Response.Redirect("~/Home.aspx");
    }
    
    protected void btnProducts_Click(object sender, EventArgs e)
    {
        GlobalVar.setSpecificCategory(0, true, false);
        Response.Redirect("~/Products.aspx");
    }

    protected void btnCoilovers_Click(object sender, EventArgs e)
    {
        GlobalVar.setSpecificCategory(1, false, false);
        Response.Redirect("~/Products.aspx");
    }

    protected void btnFlyWheels_Click(object sender, EventArgs e)
    {
        GlobalVar.setSpecificCategory(2, false, false);
        Response.Redirect("~/Products.aspx");
    }

    protected void btnHandBrakes_Click(object sender, EventArgs e)
    {
        GlobalVar.setSpecificCategory(3, false, false);
        Response.Redirect("~/Products.aspx");
    }

    protected void btnSeats_Click(object sender, EventArgs e)
    {
        GlobalVar.setSpecificCategory(4, false, false);
        Response.Redirect("~/Products.aspx");
    }

    protected void btnSteeringWheels_Click(object sender, EventArgs e)
    {
        GlobalVar.setSpecificCategory(5, false, false);
        Response.Redirect("~/Products.aspx");
    }

    protected void btnWheelNuts_Click(object sender, EventArgs e)
    {
        GlobalVar.setSpecificCategory(6, false, false);
        Response.Redirect("~/Products.aspx");
    }

    protected void btnWheels_Click(object sender, EventArgs e)
    {
        GlobalVar.setSpecificCategory(7, false, false);
        Response.Redirect("~/Products.aspx");
    }



    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Login.aspx");
    }
}

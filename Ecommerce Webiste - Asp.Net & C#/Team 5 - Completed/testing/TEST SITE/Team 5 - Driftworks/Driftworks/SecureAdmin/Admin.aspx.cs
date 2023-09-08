using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SecureAdmin_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ADMIN"] == null || Session["customerObj"] != null)
        {
            Response.Redirect("~/Login.aspx");
        }
    }

    protected void btnReOrders_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/SecureAdmin/ReOrderStock.aspx");
    }

    protected void btnDeleteProduct_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/SecureAdmin/removeAProduct.aspx");
    }

    protected void btnRemoved_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/SecureAdmin/removedProducts.aspx");
    }

    protected void btnAddProduct_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/SecureAdmin/createProduct.aspx");
    }
    
    protected void btnEditProduct_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/SecureAdmin/editProducts.aspx");
    }









}
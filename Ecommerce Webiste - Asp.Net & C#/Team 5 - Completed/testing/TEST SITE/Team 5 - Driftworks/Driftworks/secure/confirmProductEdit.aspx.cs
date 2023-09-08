using System;
using System.Collections.Generic;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secure_checkout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["EditProduct"] == null)
        {
            Response.Redirect("~/secureAdmin/Admin.aspx");
        }

        if (!IsPostBack)
        {
            ArrayList cartItems = (ArrayList)Session["EditProduct"];
            string output = "";
            foreach (CartItem item in cartItems)
            {
                output +=
                    item.getID() + " " + item.getName() + " " +
                    item.getProductDesc() + " " + item.getReOrderLevel() + " " +
                    "£"+ item.getPrice().ToString("##.00") + " " + "<br/>";
            }
            lblItems.Text = output;
        }
    }// Page_Load

    
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Session.Remove("EditProduct");
        Response.Redirect("~/secureAdmin/Admin.aspx");

    }

    
    protected void btnInvoice_Click(object sender, EventArgs e)
    {
        ArrayList basket = null; //create an ArrayList called basket
        if (Session["EditProduct"] != null)
        {
            basket = (ArrayList)Session["EditProduct"];
        } 
        //updateStock method returns the number of changed records
        int updated = Product.editProduct(basket);


        //Shopping basket is now emptied
        Session.Remove("EditProduct");
        //Open the invoice details page and pass across query string
        Response.Redirect("~/secureAdmin/Admin.aspx");//?recordsUpdated=" + Server.UrlEncode(updated.ToString()));
        
    }
}
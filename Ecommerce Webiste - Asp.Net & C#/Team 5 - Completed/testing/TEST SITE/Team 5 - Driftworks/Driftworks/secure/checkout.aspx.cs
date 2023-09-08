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

        if (Session["customerObj"] == null)
        {
            Response.Redirect("~/login.aspx");
        }

        if (Session["ShoppingBasket"] == null)
        {
            Response.Redirect("~/products.aspx");
        }

        if (!IsPostBack)
        {
            ddlDelivery.Items.Add("Standard");
            ddlDelivery.Items.Add("Next day");
            ddlDelivery.Items.Add("Two days");

            Customer custObj = (Customer)Session["customerObj"];
            ArrayList cartItems = (ArrayList)Session["ShoppingBasket"];

            lblDetails.Text = custObj.getFullName() + "<br/>" +
                                                   custObj.getAddress();

            string output = "";
            double total = 0;
            foreach (CartItem item in cartItems)
            {
                double lineCost = item.getQty() * item.getPrice();
                total += lineCost;
                output += item.getName() + " " + item.getQty() + " " +
                                   lineCost.ToString("##.00") + "<br/>";
            }

            lblItems.Text = output;

            lblBasketCost.Text = total.ToString("£##.00");
            lblHiddenCost.Text = total.ToString();
            lblTotal.Text = total.ToString("£##.00");
        }
    }// Page_Load



    protected void ddlDelivery_SelectedIndexChanged(object sender, EventArgs e)
    {
        double totalCost = 0;

        switch (ddlDelivery.SelectedIndex)
        {
            case 0:
                lblTotal.Text = lblBasketCost.Text;
                lblDelCost.Text = "0";
                break;
            case 1:
                totalCost = Convert.ToDouble(lblHiddenCost.Text) + 5;
                lblTotal.Text = totalCost.ToString("£##.00");
                lblDelCost.Text = "5";
                break;
            case 2:
                totalCost = Convert.ToDouble(lblHiddenCost.Text) + 2.5;
                lblTotal.Text = totalCost.ToString("£##.00");
                lblDelCost.Text = "2.5";
                break;
        }//switch

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Session.Remove("ShoppingBasket");
        Response.Redirect("~/products.aspx");

    }

    
        protected void btnInvoice_Click(object sender, EventArgs e)
    {
        Customer custObj = (Customer)Session["customerObj"];
        Invoice myInvoice = new Invoice(custObj.Email,
                               Convert.ToDouble(lblHiddenCost.Text),
                               Convert.ToDouble(lblDelCost.Text),
                               ddlDelivery.Text);
        myInvoice.createInvoice();
        Session["invObj"] = myInvoice;

        ArrayList basket = null; //create an ArrayList called basket
        if (Session["ShoppingBasket"] != null)
        {
            basket = (ArrayList)Session["ShoppingBasket"];
            // go through each item in basket and add to tblOrderItems
            foreach (CartItem item in basket)
            {
                // Add item to tblOrderItems
                item.createOrderItem(myInvoice.getInvoice());
            }//for each
        } // if

        //updateStock method returns the number of changed records
        int updated = Product.updateStock(basket);

        //Shopping basket is now emptied
        Session.Remove("ShoppingBasket");

        //Open the invoice details page and pass across query string
        Response.Redirect("invoiceDetails.aspx?recordsUpdated=" +
                                    Server.UrlEncode(updated.ToString()));



       


    }
}
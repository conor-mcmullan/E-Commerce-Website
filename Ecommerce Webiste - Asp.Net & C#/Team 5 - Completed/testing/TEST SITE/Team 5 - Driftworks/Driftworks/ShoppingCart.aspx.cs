using System;
using System.Collections.Generic;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShoppingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            displayItems();
        }

    }
    public void displayItems()
    {
        ArrayList basket;

        if (Session["ShoppingBasket"] != null)
        {
            basket = (ArrayList)Session["ShoppingBasket"];
            int size = basket.Count;
            double totalCost = 0;

            foreach (CartItem item in basket)
            {
                double lineCost = item.getPrice() * item.getQty();
                totalCost = totalCost + lineCost;
                //lstName.Items.Add(item.getName());

                //** try ing to add everything at once
                
        lstName.Items.Add(item.getName()+" £"+item.getPrice().ToString()+" "+item.getQty().ToString());
                //**

                //lstPrice.Items.Add(item.getPrice().ToString());
                //lstQuantity.Items.Add(item.getQty().ToString());
            }
            lblName.Text = "Product Name"+"&nbsp;&nbsp;&nbsp;&nbsp;"+"Price"+"&nbsp;&nbsp;&nbsp;&nbsp;"+"Quantity";
            //lblName.Text = String.Format("{0}\t{1}", "Name", "Price");
            lblTotal.Text = totalCost.ToString();
        }
        else
        {
            lblTotal.Text = "No items in shopping basket";
        }
    }//

    private void clearListboxes()
    {
        lstName.Items.Clear();
        //lstPrice.Items.Clear();
        //lstQuantity.Items.Clear();
    }// 

    protected void btnEmpty_Click(object sender, EventArgs e)
    {
        Session.Remove("ShoppingBasket");
        displayItems();
        // set cart size back to zero
        CartItem.setInCartCount(0);
        clearListboxes();
        Response.Redirect("~/ShoppingCart.aspx");
    }// btnEmpty_Click

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        if (lstName.SelectedIndex != -1)
        {
            ArrayList basket = (ArrayList)Session["ShoppingBasket"];
            basket.RemoveAt(lstName.SelectedIndex);
            Session["ShoppingBasket"] = basket;
            clearListboxes();
            displayItems();

            int size = basket.Count;
            CartItem.setInCartCount(size);
            Response.Redirect("~/ShoppingCart.aspx");
        }
    }//





    protected void btnPurchase_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/secure/checkout.aspx");
    }
}
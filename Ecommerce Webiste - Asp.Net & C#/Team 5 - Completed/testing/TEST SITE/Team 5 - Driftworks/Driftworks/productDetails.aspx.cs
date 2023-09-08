using System;
using System.Collections.Generic;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class productDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if(Session["SelectedProductID"] == null)
            {
                Response.Redirect("Products.aspx");
            }
            else
            {
                lblProductID.Text = (string)Session["SelectedProductID"];
                Product tmpProduct = new Product();
                tmpProduct.loadProduct(Session["SelectedProductID"].ToString());
                lblProductName.Text = tmpProduct.getStrProductName();
                lblProductDesc.Text = tmpProduct.getStrProductDesc();
                imgProduct.ImageUrl = tmpProduct.getStrImageFile();
                lblPrice.Text = tmpProduct.getDblPrice().ToString("##.00");
                ddlStock.Items.Clear(); //ensure drop down list is empty
                for (int index = 1; index <= tmpProduct.getIntStock(); index++)
                {
                    ddlStock.Items.Add(index.ToString());
                }
            }
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        ArrayList basket;
        CartItem item = new CartItem(lblProductID.Text,
                   lblProductName.Text, Convert.ToDouble(lblPrice.Text),
                   Convert.ToInt32(ddlStock.SelectedValue.ToString()));

        if (Session["ShoppingBasket"] != null)
        {
            basket = (ArrayList)Session["ShoppingBasket"];
        }
        else
        {
            basket = new ArrayList();
        }

        basket.Add(item);

        //create ShoppingBasket session variable
        Session["ShoppingBasket"] = basket;

        // set size of cart atm 
        CartItem.setInCartCount(basket.Count);


        Response.Redirect("Products.aspx");
    }//btnAdd_Click


}
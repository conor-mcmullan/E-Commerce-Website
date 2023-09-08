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
        if (Session["ADMIN"] == null || Session["customerObj"] != null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!IsPostBack)
        {
            if(Session["SelReOrderProduct"] == null)
            {
                Response.Redirect("ReOrderStock.aspx");
            }
            else
            {
                lblProductID.Text = (string)Session["SelReOrderProduct"];
                Product tmpProduct = new Product();
                tmpProduct.loadProduct(Session["SelReOrderProduct"].ToString());
                lblProductName.Text = tmpProduct.getStrProductName();
                lblProductDesc.Text = tmpProduct.getStrProductDesc();
                imgProduct.ImageUrl = tmpProduct.getStrImageFile();
                lblPrice.Text = tmpProduct.getDblPrice().ToString("##.00");
                
            }
        }
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        ArrayList basket;
        CartItem item = new CartItem(lblProductID.Text,
                   lblProductName.Text, Convert.ToDouble(lblPrice.Text),
                   Convert.ToInt32(ddlStock.SelectedValue.ToString()));
        if (Session["updateProduct"] != null)
        {
            basket = (ArrayList)Session["updateProduct"];
        }
        else
        {
            basket = new ArrayList();
        }
        basket.Add(item);
        //create ShoppingBasket session variable
        Session["updateProduct"] = basket;

        // admin page
        Response.Redirect("~/secure/confirmStockUpdate.aspx");
        
    }//btnAdd_Click


}
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
            if(Session["SelEditedProduct"] == null)
            {
                Response.Redirect("editProducts.aspx");
            }
            else
            {

                txtProductID.Text = (string)Session["SelEditedProduct"];
                Product tmpProduct = new Product();
                tmpProduct.loadProduct(Session["SelEditedProduct"].ToString());


                txtProductName.Text = tmpProduct.getStrProductName();
                txtProductDesc.Text = tmpProduct.getStrProductDesc();
                txtUnitPrice.Text = tmpProduct.getUnitPrice().ToString("##.00");
                txtRetailPrice.Text = tmpProduct.getDblPrice().ToString("##.00");

                imgProduct.ImageUrl = tmpProduct.getStrImageFile();

                txtStockLevel.Text = tmpProduct.getIntStock().ToString();
                txtReOrderLevel.Text = tmpProduct.getReOrderLevel().ToString();
                txtCategoryID.Text = tmpProduct.getCategoryID().ToString();


            }
        }
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        ArrayList basket;
        CartItem item = new CartItem(txtProductID.Text,txtProductName.Text,txtProductDesc.Text, 
            Convert.ToDouble(txtRetailPrice.Text),Convert.ToInt32(txtReOrderLevel.Text));
        
        if (Session["EditeProduct"] != null){
            basket = (ArrayList)Session["EditProduct"];
        }
        else{
            basket = new ArrayList();
        }
        basket.Add(item);
        //create ShoppingBasket session variable
        Session["EditProduct"] = basket;
        // admin page
        
        Response.Redirect("~/secure/confirmProductEdit.aspx");
    }//btnAdd_Click


}
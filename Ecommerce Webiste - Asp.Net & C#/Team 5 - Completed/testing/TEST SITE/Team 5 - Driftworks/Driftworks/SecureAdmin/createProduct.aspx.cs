using System;
using System.Collections.Generic;
using System.Collections;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.IO;

public partial class createAccount : System.Web.UI.Page
{
    Boolean newCust = false;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ADMIN"] == null || Session["customerObj"] != null)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
    
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (chkAgree.Checked == true)
        {
            //Product productObj = (Product)Session["productObj"];
            Product productObj = new Product();

            int cat = 0;
            string catName = "";

            // UPLOADING THE ACTUAL IMAGE TO THE FOLDER
            if (fulProductImage.HasFile)
            {
                if (fulProductImage.PostedFile.ContentType == "image/jpeg")
                {
                    string filename = Path.GetFileName(fulProductImage.FileName);
                    cat = Convert.ToInt32(txtCategoryID.Text);
                    // NEED TO GET THE CATEGORY NAME FOR THE SELECTED CATEGORY ID ENTERED  
                    catName = productObj.getCategoryName(cat);
                    // catName = newProduct.getCategoryName(cat);
                    // THE CATEGORY NAME NEEDS APPENDED TO THE SAVE ADDRESS FOR THE IMAGE
                    string directory = Server.MapPath("~/images/categories/" + catName + "/");                
                    DirectoryInfo dir = new DirectoryInfo(directory);
                    int count = dir.GetFiles().Length;
                    filename = (count+1)+".jpg";
                    fulProductImage.SaveAs(Server.MapPath("~/images/categories/"+catName+"/") + filename);
                    lblImgUrl.Text = "~/images/categories/" + catName + "/" + filename;
                }
            }

            //Product newProduct 
              productObj = new Product
            (
                txtProductID.Text,
                txtProductName.Text,
                txtProductDescription.Text,
                Convert.ToDouble(txtUnitPrice.Text),
                Convert.ToDouble(txtRetailPrice.Text),
                lblImgUrl.Text.ToString(),
                Convert.ToInt32(txtStockLevel.Text),
                Convert.ToInt32(txtReOrderLevel.Text),
                Convert.ToInt32(txtCategoryID.Text)
            );
            //newProduct.createProduct();
            //Session["invObj"] = newProduct;
            productObj.createProduct();
            Session["invObj"] = productObj;
            //Open the invoice details page and pass across query string
            Response.Redirect("~/SecureAdmin/Admin.aspx?recordsUpdated=1");
        }
        else
        {
            lblAgree.Text = "Invalid Product Details !";
        }
    }


} 

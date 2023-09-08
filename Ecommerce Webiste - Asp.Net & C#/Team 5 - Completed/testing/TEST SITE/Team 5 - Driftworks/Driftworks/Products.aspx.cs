using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Products : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = ProductList.getProducts();
        //dgvProducts.DataSource = ds.Tables["dtProducts"];
        DataView dv = new DataView(ds.Tables["dtProducts"]);
        dgvProducts.DataSource = dv;

        
            dv.RowFilter = "categoryid > 0 and instock > 0";
        

        //dv.RowFilter = "categoryid > 0";
        if ((GlobalVar.allCategories() == true) && (GlobalVar.editAProduct() == false))
        {
            dv.RowFilter = "categoryid > " + GlobalVar.getSpecificCategory() + " and instock > 0";
        }
        else if ((GlobalVar.allCategories() == false) && (GlobalVar.editAProduct() == false))
        {
            dv.RowFilter = "categoryid = " + GlobalVar.getSpecificCategory() + " and instock > 0";
        }
        else if ((GlobalVar.allCategories() == true) && (GlobalVar.editAProduct() == true))
        {
            // for the amdin only !
            dv.RowFilter = "instock < reorderlevel";

            
        }

        dgvProducts.AllowPaging = true;
        dgvProducts.PageSize = 6;

        dgvProducts.DataBind();
    }

    protected void dgvProducts_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dgvProducts.PageIndex = e.NewPageIndex;
        dgvProducts.DataBind();
    }

    protected void dgvProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["SelectedProductID"] =
  dgvProducts.Rows[dgvProducts.SelectedIndex].Cells[1].Text;

        Response.Redirect("productDetails.aspx");

    }
}
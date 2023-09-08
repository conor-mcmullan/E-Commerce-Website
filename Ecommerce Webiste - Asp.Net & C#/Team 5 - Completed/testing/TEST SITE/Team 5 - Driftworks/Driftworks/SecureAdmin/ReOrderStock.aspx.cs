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
        if (Session["ADMIN"] == null || Session["customerObj"] != null)
        {
            Response.Redirect("~/Login.aspx");
        }

        DataSet ds = ProductList.getProducts();
        DataView dv = new DataView(ds.Tables["dtProducts"]);
        dgvProducts.DataSource = dv;
        // dv.RowFilter = "instock >-1 and instock <= reorderlevel";
        dv.RowFilter = "instock >-1 and instock <= reorderlevel";
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
        Session["SelReOrderProduct"] =
        dgvProducts.Rows[dgvProducts.SelectedIndex].Cells[1].Text;
        Response.Redirect("reOrderDetails.aspx");
    }
}
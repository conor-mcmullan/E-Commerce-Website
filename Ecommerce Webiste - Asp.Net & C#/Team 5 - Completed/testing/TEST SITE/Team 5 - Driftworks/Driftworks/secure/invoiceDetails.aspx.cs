using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class secure_invoiceDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["invObj"] != null)
            {
                Invoice myInvoice = (Invoice)Session["invObj"];
                lblInvoiceNum.Text = myInvoice.getInvoice().ToString();
            }
        }

    }

    protected void btnComplete_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/products.aspx");
    }
}
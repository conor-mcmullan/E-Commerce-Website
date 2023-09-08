using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
                if (!IsPostBack)
        {
            if(Session["SelectedEmail"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblEmail.Text = (string)Session["SelectedEmail"];
                //create a tmpProduct object using the loadProduct method 
                Customer tmpCustomer = new Customer();
                tmpCustomer.loadCustomer(Session["SelectedEmail"].ToString());

                // display the data within the tmpProduct object 
                lblLastName.Text = tmpCustomer.getlastName();
                lblFirstName.Text = tmpCustomer.getFirstName();
                lblEmail.Text = tmpCustomer.getEmail();
                lblCustAddress.Text = tmpCustomer.getAddress();
                lblCity.Text = tmpCustomer.getCity();
                lblPostCode.Text = tmpCustomer.getPostcode();
                lblPassword.Text = tmpCustomer.getPwd();
                lblPhone.Text = tmpCustomer.getPhone();

                //ddlStock.Items.Clear(); //ensure drop down list is empty

                //using the inStock value to populate the drop down list
                /*
                for (int index = 1; index <= tmpProduct.getIntStock(); index++)
                {
                    ddlStock.Items.Add(index.ToString());
                }
                 * */
                //for


            }
        }
    }
    /*
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

        Response.Redirect("Products.aspx");
    }//btnAdd_Click
    */

    }

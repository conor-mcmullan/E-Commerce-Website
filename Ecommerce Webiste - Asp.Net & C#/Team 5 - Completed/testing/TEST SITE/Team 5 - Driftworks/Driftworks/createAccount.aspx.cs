using System;
using System.Collections.Generic;
using System.Collections;
using System.Web;
using System.Data;
using System.Data.OleDb;

public partial class createAccount : System.Web.UI.Page
{
    Boolean newCust = false;


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {   

        if(chkAgree.Checked==true)
        { 
        Customer custObj = (Customer)Session["customerObj"];
        Customer myCustomer = new Customer(txtNewemail.Text, txtNewlastname.Text,
                     txtNewfirstName.Text, txtNewaddress.Text, txtNewcity.Text,
                     txtNewpostcode.Text, txtNewphonenumber.Text, txtNewpassword.Text);


        myCustomer.createCustomer();
        Session["invObj"] = myCustomer;
        //Open the invoice details page and pass across query string
        Response.Redirect("MyAccount.aspx?recordsUpdated=");

        }else{
            lblAgree.Text = "Invalid Details.";
        }

    }





} 

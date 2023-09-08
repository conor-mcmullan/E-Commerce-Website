using System;
using System.Collections.Generic;
using System.Collections;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess
{
    public DataAccess()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private static OleDbConnection openConnection()
    {
        // path to the root of the web site where the web.config file exists
        string configPath = "~";
        // access to web.config file
        System.Configuration.Configuration rootWebConfig =
         System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(configPath);
        // declaring the connection string
        string conStr = null;

        // get the value(s) in the connection string
        if (rootWebConfig.ConnectionStrings.ConnectionStrings.Count > 0)
        {
            try
            {
                conStr = rootWebConfig.ConnectionStrings.ConnectionStrings["conStrBMC"].ToString();
            }
            catch (Exception ex)
            {
                conStr = null;
            }

            if (conStr != null)
            {
                HttpContext.Current.Trace.Warn("BMC connection string = \"{0}\"", conStr);

                //Create an OleDbConnection object using the Connection String
                OleDbConnection cn = new OleDbConnection(conStr);
                //Open the connection.
                cn.Open();
                return cn;
            }
            else
            {
                HttpContext.Current.Trace.Warn("No BMC connection string");
                return null;
            }
        }

        return null;
    }// openConnection

    private static void closeConnection(OleDbConnection cn)
    {
        cn.Close();
    } //closeConnection

    public static DataSet getProducts()
    {
        OleDbConnection conn = openConnection();
        //create dataset (virtual database)
        DataSet dsBMC = new DataSet();

        string strSQL = "SELECT * FROM tblProducts";

        //data adapter is bridge between database and dataset
        OleDbDataAdapter daProducts = new OleDbDataAdapter(strSQL, conn);

        //populate the data table in the dataset 
        //with records from the database table
        daProducts.Fill(dsBMC, "dtProducts");

        conn.Close();

        return dsBMC;
    }//getProducts



    // **********************___________
    public static DataSet getMyProducts(String email)
    {
        OleDbConnection conn = openConnection();
        //create dataset (virtual database)
        DataSet dsBMC = new DataSet();



        string strSQL = "SELECT tblCustomers.Email, tblProducts.ProductName, " +
            "tblProducts.RetailPrice, tblProducts.ProductID FROM tblProducts " +
            "INNER JOIN ((tblCustomers INNER JOIN tblInvoices ON tblCustomers.[Email] " +
            "= tblInvoices.[CustEmail]) INNER JOIN tblOrderItems ON tblInvoices.[InvoiceNumber]" +
            "= tblOrderItems.[InvoiceNumber]) ON tblProducts.[ProductID] = tblOrderItems.[ProductID]"
            ;
            //+ "WHERE tblCustomers.Email =" + email;
            // EMAIL OF LOGGED IN USER

            
        
        //data adapter is bridge between database and dataset
        OleDbDataAdapter daProducts = new OleDbDataAdapter(strSQL, conn);

        //populate the data table in the dataset 
        //with records from the database table
        daProducts.Fill(dsBMC, "dtProducts");

        conn.Close();

        return dsBMC;
    }//getProducts



    public static Product getProduct(string pProductID)
    {
        Product productObj = new Product();

        OleDbConnection conn = openConnection();

        string strSQL = "select * FROM tblProducts WHERE ProductID='"
                        + pProductID + "'";

        OleDbCommand cmd = new OleDbCommand(strSQL, conn);

        OleDbDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            productObj.setStrProductID(reader["ProductID"].ToString());
            productObj.setStrProductName(reader["ProductName"].ToString());
            productObj.setStrProductDesc(reader["ProductDesc"].ToString());
            productObj.setUnitPrice(Convert.ToDouble(reader["UnitPrice"]));
            productObj.setDblPrice(Convert.ToDouble(reader["RetailPrice"]));
            productObj.setStrImageFile(reader["ImageFile"].ToString());
            productObj.setIntStock(Convert.ToInt32(reader["InStock"]));
            productObj.setReOrderLevel(Convert.ToInt32(reader["ReOrderLevel"]));
            productObj.setCategoryID(Convert.ToInt32(reader["CategoryID"]));
        }//while

        reader.Close();
        closeConnection(conn);

        return productObj;
    }//getProduct

    
    // add below here
    //code below added for MyAccount page-----------------------

    //gettig customer details
    public static Customer getCustomer(string CusEmail)
    {
        Customer customerObj = new Customer();

        OleDbConnection conn = openConnection();

        string strSQL = "select * FROM tblCustomers WHERE Email='"
                        + CusEmail + "'";

        OleDbCommand cmd = new OleDbCommand(strSQL, conn);

        OleDbDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {

            customerObj.setEmail(reader["Email"].ToString());
            customerObj.setLastName(reader["LastName"].ToString());
            customerObj.setFirstName(reader["FirstName"].ToString());
            customerObj.setHomeAddress(reader["Address"].ToString());
            customerObj.setCity(reader["City"].ToString());
            customerObj.setPostcode(reader["PostCode"].ToString());
            customerObj.setPhone(reader["PhoneNumber"].ToString());
            customerObj.setPwd(reader["pwd"].ToString());

        }//while

        reader.Close();
        closeConnection(conn);

        return customerObj;
    }//end of getting cutomer details


    //code above added for my account page--------------------------
    // add above here



    public static Customer checkLogin(string email, string pwd)
    {
        OleDbConnection conn = openConnection();
        string strSQL = "select * FROM tblCustomers WHERE Email='" +
                                     email + "' and pwd='" + pwd + "'";

        OleDbCommand cmd = new OleDbCommand(strSQL, conn);
        OleDbDataReader reader = cmd.ExecuteReader();
        Customer custObj = null;

        while (reader.Read())
        {
            string lastname = reader["LastName"].ToString();
            string firstname = reader["FirstName"].ToString();
            string address = reader["Address"].ToString();
            string postcode = reader["Postcode"].ToString();
            string city = reader["City"].ToString();
            string phone = reader["PhoneNumber"].ToString();
            string password = reader["pwd"].ToString();
            custObj = new Customer(email, lastname, firstname, address,
                                                city, postcode, phone, password);
        }

        reader.Close();
        closeConnection(conn);
        return custObj;
    }//checkLogin



    // **** admin
    public static Admin checkAdminLogin(string email, string pwd)
    {
        OleDbConnection conn = openConnection();
        string strSQL = "select * FROM tblAdmins WHERE AdminEmail='" + email + "' and AdminPwd='" + pwd + "'";

        OleDbCommand cmd = new OleDbCommand(strSQL, conn);
        OleDbDataReader reader = cmd.ExecuteReader();
        Admin adminObj = null;

        while (reader.Read())
        {           
      //      string password = reader["pwd"].ToString();
            adminObj = new Admin(email, pwd);
        }

        reader.Close();
        closeConnection(conn);
        return adminObj;
    }//checkLogin
    // *** admin






    public static int createNewInvoice(string strEmail,
             string strShipping, DateTime orderDate, double subTotal,
             double total, double shippingPrice)
    {
        OleDbConnection conn = openConnection();

        string strSQL = "INSERT INTO tblInvoices(CustEmail, " +
                       " Orderdate, subTotal, shipMethod, shipping, total)" +
                       " VALUES('" + strEmail + "', '" + orderDate + "'," +
                        subTotal + ",'" + strShipping + "',"
                        + shippingPrice + ", " + total + ")";

        //create the command object using the SQL
        OleDbCommand cmd = new OleDbCommand(strSQL, conn);

        cmd.ExecuteNonQuery(); // execute the insertion command

        //change the SQL to return the new invoice number
        cmd.CommandText = "Select @@Identity";

        int intInvoiceNum = Convert.ToInt32(cmd.ExecuteScalar());

        closeConnection(conn); // close connection
        return intInvoiceNum; // return the invoice number

    } //createNewInvoice




    // add below here 
    public static int createNewCustomer(string email, string lastname,
                     string firstname, string address, string city,
                     string postcode, string phone, string pwd)
    {
        OleDbConnection conn = openConnection();

        string strSQL = "INSERT INTO tblCustomers(Email, " +
                       " LastName, FirstName, Address, City, PostCode, PhoneNumber, pwd)" +
                       " VALUES('" + email + "', '" + lastname + "', '" +
                        firstname + "', '" + address + "', '"
                        + city + "', '" + postcode + "', '" + phone + "', '" + pwd + "')";

        //create the command object using the SQL
        OleDbCommand cmd = new OleDbCommand(strSQL, conn);

        cmd.ExecuteNonQuery(); // execute the insertion command

        //change the SQL to return the new invoice number
        cmd.CommandText = "Select @@Identity";

        int intCustomerNum = Convert.ToInt32(cmd.ExecuteScalar());

        closeConnection(conn); // close connection
        return intCustomerNum; // return the customer number

    }    // add above here






    //********************************************************************************************************
    //********************************************************************************************************
    //********************************************************************************************************

    public static string getCategoryName(int catID)
    {
        string catName = null;
        switch (catID)
        {
            case 1:
                catName = "coilovers";
                break;
            case 2:
                catName = "flywheels";
                break;
            case 3:
                catName = "handbrakes";
                break;
            case 4:
                catName = "seats";
                break;
            case 5:
                catName = "steeringwheels";
                break;
            case 6:
                catName = "wheelnuts";
                break;
            case 7:
                catName = "wheels";
                break;
            default: catName = "";
                break;
        }
        return catName;
    }//get a products category name 


    // add below here 
    public static int createNewProduct(string newID, string newName, string newDesc, double newUprice, 
                                       double newRprice, string newImgUrl, int newStockLevel, 
                                       int newReOrderLevel, int newCatID)
    {
        OleDbConnection conn = openConnection();

        string strSQL = "INSERT INTO tblProducts(ProductID, " +
                       " ProductName, ProductDesc, UnitPrice, RetailPrice, ImageFile, InStock, ReOrderLevel, CategoryID)" +
                       " VALUES('" + newID + "', '" + newName + "', '" +
                        newDesc + "', '" + newUprice + "', '"
                        + newRprice + "', '" + newImgUrl + "', '" + newStockLevel + "', '" + newReOrderLevel + "', '" + newCatID + "')";

        //create the command object using the SQL
        OleDbCommand cmd = new OleDbCommand(strSQL, conn);

        cmd.ExecuteNonQuery(); // execute the insertion command

        //change the SQL to return the new invoice number
        cmd.CommandText = "Select @@Identity";

        int intProductNum = Convert.ToInt32(cmd.ExecuteScalar());

        closeConnection(conn); // close connection
        return intProductNum; // return the customer number

    }    // add above here


    //********************************************************************************************************
    //********************************************************************************************************
    //********************************************************************************************************
    



    public static void createOrderItem(CartItem item, int intInvoiceNum)
    {
        OleDbConnection conn = openConnection();
        double lineTotal = item.getQty() * item.getPrice();

        string strSQL = "INSERT INTO tblOrderItems(InvoiceNumber,ProductID, UnitPrice, Quantity, LineTotal)" +
                  " VALUES('" + intInvoiceNum + "', '" + item.getID()
                  + "'," + item.getPrice() + "," + item.getQty() +
                  "," + lineTotal + ")";

        OleDbCommand cmd = new OleDbCommand(strSQL, conn);

        int inv = cmd.ExecuteNonQuery();
        closeConnection(conn);
    } //createOrderItem



    public static int updateStock(ArrayList parBasket)
    {
        OleDbConnection cn = openConnection();
        string strSQL = "SELECT Instock FROM tblProducts";
        OleDbCommand cmd = new OleDbCommand(strSQL, cn);

        int updated = 0;

        foreach (CartItem itemLine in parBasket)
        {
            //change SQL in command object to select only the required Product
            cmd.CommandText =
                  "SELECT Instock FROM tblProducts WHERE ProductID = '" +
                                                   itemLine.getID() + "'";

            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //access the InStock value in the selected record
            int stock = Convert.ToInt32(reader["Instock"]);

            //substract the quantity ordered from the current stock level
            stock = stock - itemLine.getQty();

            reader.Close();

            //Perform update to stock value in tblProducts
            cmd.CommandText = "UPDATE tblProducts SET InStock ="
               + stock + "  WHERE ProductID = '" + itemLine.getID() + "'";

            //the number of records updated are returned as an iteger 
            //(only 1 record should match Product ID)
            int recordsUpdated = cmd.ExecuteNonQuery();
            updated = updated + recordsUpdated;
        }//foreach   
        cn.Close();
        return updated; //return number of product records updated
    } // updateStock





    // *********************************************************************
    
    public static int updateProductDetails(ArrayList parBasket)
    {
        OleDbConnection cn = openConnection();
        string strSQL = "SELECT * FROM tblProducts";
        OleDbCommand cmd = new OleDbCommand(strSQL, cn);

        int updated = 0;

        foreach (CartItem itemLine in parBasket)
        {
            //change SQL in command object to select only the required Product
        cmd.CommandText ="SELECT * FROM tblProducts WHERE ProductID = '" + itemLine.getID() + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //access the InStock value in the selected record

            //string productName = (string)reader["ProductName"];
            //string productDesc = (string)reader["ProductDesc"];
            //double retailPrice = Convert.ToDouble(reader["RetailPrice"]);
            //int reOrderLevel = Convert.ToInt32(reader["ReOrderLevel"]);

            string productID = (string)itemLine.getID();
            string productName = (string)itemLine.getName();
            string productDesc = (string)itemLine.getProductDesc();
            double retailPrice = Convert.ToDouble(itemLine.getPrice());
            int reOrderLevel = Convert.ToInt32(itemLine.getReOrderLevel());


            reader.Close();

            //Perform update to stock value in tblProducts

        cmd.CommandText ="UPDATE tblProducts SET "+ "ProductName = '" + productName + "'"
        + ",ProductDesc = '" + productDesc + "'"+ ",RetailPrice = '" + retailPrice + "'"
        + ",ReOrderLevel = '" + reOrderLevel + "'"+ "  WHERE ProductID = '" + productID + "'";
            //the number of records updated are returned as an iteger 
            //(only 1 record should match Product ID)
            int recordsUpdated = cmd.ExecuteNonQuery();
            updated = updated + recordsUpdated;
        }//foreach   
        cn.Close();
        return updated; //return number of product records updated
    } // updateStock

    // *********************************************************************

    public static int addStock(ArrayList parBasket)
    {
        OleDbConnection cn = openConnection();
        string strSQL = "SELECT Instock FROM tblProducts";
        OleDbCommand cmd = new OleDbCommand(strSQL, cn);
        int updated = 0;
        foreach (CartItem itemLine in parBasket)
        {
            cmd.CommandText = "SELECT Instock FROM tblProducts WHERE ProductID = '" + itemLine.getID() + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int stock = Convert.ToInt32(reader["Instock"]);
            stock = stock + itemLine.getQty();
            reader.Close();
            cmd.CommandText = "UPDATE tblProducts SET InStock ="
               + stock + "  WHERE ProductID = '" + itemLine.getID() + "'";
            int recordsUpdated = cmd.ExecuteNonQuery();
            updated = updated + recordsUpdated;
        }//foreach   
        cn.Close();
        return updated; //return number of product records updated
    } // updateStock

    
    public static int removeProduct(ArrayList parBasket)
    {
        OleDbConnection cn = openConnection();
        string strSQL = "SELECT Instock FROM tblProducts";
        OleDbCommand cmd = new OleDbCommand(strSQL, cn);
        int updated = 0;
        foreach (CartItem itemLine in parBasket)
        {
            cmd.CommandText = "SELECT Instock FROM tblProducts WHERE ProductID = '" + itemLine.getID() + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int stock = Convert.ToInt32(reader["Instock"]);
            stock = stock + itemLine.getQty();
            reader.Close();
            cmd.CommandText = "UPDATE tblProducts SET InStock = -1 WHERE ProductID = '" + itemLine.getID() + "'";
            int recordsUpdated = cmd.ExecuteNonQuery();
            updated = updated + recordsUpdated;
        }//foreach   
        cn.Close();
        return updated; //return number of product records updated
    } // removing a product




}//class
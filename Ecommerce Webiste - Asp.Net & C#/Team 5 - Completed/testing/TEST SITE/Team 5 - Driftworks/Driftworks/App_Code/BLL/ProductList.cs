using System;
using System.Collections.Generic;
using System.Collections;
using System.Web;
using System.Data;
using System.Data.OleDb;

public class ProductList
{
    
    public ProductList()
    {
        
    }

    public static DataSet getProducts()
    {
        return DataAccess.getProducts();
    }


    public static DataSet getMyProducts(string test)
    {
        return DataAccess.getMyProducts(test);
    }

}
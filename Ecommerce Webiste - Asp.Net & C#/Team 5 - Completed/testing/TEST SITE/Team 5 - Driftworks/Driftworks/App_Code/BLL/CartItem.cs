using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartItem
/// </summary>
public class CartItem
{
    private string strID, strName, strProductDesc;
    private double dblPrice, dblUnitPrice;
    private int intQty, intStock, intReOrderlevel, intCategoryID;
    private static int cartCount = 0;

    public CartItem(string pID, string pName, double pPrice, int pQty)
    {
        this.strID = pID;
        this.strName = pName;
        this.dblPrice = pPrice;
        this.intQty = pQty;

    } // end of constructor

    public CartItem(string pID, string newName, string newDesc, double newRprice, int newReOrderLevel)
    {
        this.strID = pID;
        this.strName = newName;
        this.strProductDesc = newDesc;
        this.dblPrice = newRprice;
        this.intReOrderlevel = newReOrderLevel;
    }

    public CartItem()
    {
    }

    public string getID()
    {
        return this.strID;
    } // end of getID accessor

    public void setID(string parID)
    {
        this.strID = parID;
    } // end of setID modifier

    public string getName()
    {
        return this.strName;
    } // end of getName accessor

    public void setName(string parName)
    {
        this.strName = parName;
    } // end of setName modifier

    public double getPrice()
    {
        return this.dblPrice;
    } // end of getPrice accessor

    public void setPrice(double parPrice)
    {
        this.dblPrice = parPrice;
    } // end of setPrice modifier

    public int getQty()
    {
        return this.intQty;
    }  // end of getQty accessor

    public void setQty(int parQty)
    {
        this.dblPrice = parQty;
    } // end of setQty modifier



    public string getProductDesc()
    {
        return this.strProductDesc;
    }

    public void setProductDesc(string pProductDesc)
    {
        this.strProductDesc = pProductDesc;
    }

    public double getUnitPrice()
    {
        return this.dblUnitPrice;
    }

    public void setUnitPrice(double pUnitPrice)
    {
        dblUnitPrice = pUnitPrice;
    }
    
    public void setIntStock(int pStock)
    {
        intStock = pStock;
    }

    public int getIntStock()
    {
        return this.intStock;
    }

    public void setReOrderLevel(int pReOrder)
    {
        intReOrderlevel = pReOrder;
    }

    public int getReOrderLevel()
    {
        return this.intReOrderlevel;
    }

    public void setCategoryID(int pCatID)
    {
        intCategoryID = pCatID;
    }

    public int getCategoryID()
    {
        return this.intCategoryID;
    }

    public void createOrderItem(int intInvoiceNum)
    {
        DataAccess.createOrderItem(this, intInvoiceNum);

    } //createOrderItem

    public static int getInCartCount()
    {
        return cartCount;
    }

    public static void setInCartCount(int num)
    {
        cartCount = num;
    }




}//class


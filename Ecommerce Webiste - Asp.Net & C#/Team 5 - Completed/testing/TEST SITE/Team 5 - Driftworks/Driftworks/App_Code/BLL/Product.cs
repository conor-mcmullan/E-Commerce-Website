using System;
using System.Collections.Generic;
using System.Collections;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    private string strProductID, strProductName, strProductDesc;
    private string strImageFile;
    private double dblPrice, dblUnitPrice;
    private int intStock, intReOrderlevel, intCategoryID;
    


    public Product()
    {

    }

    public Product(string newID, string newName, string newDesc, double newUprice, double newRprice, 
                   string newImgUrl, int newStockLevel, int newReOrderLevel, int newCatID ){

        this.strProductID = newID;
        this.strProductName = newName;
        this.strProductDesc = newDesc;
        this.dblUnitPrice = newUprice;
        this.dblPrice = newRprice;
        this.strImageFile = newImgUrl;
        this.intStock = newStockLevel;
        this.intReOrderlevel = newReOrderLevel;
        this.intCategoryID = newCatID;
    }


    public void createProduct()
    {
        int retProductNum = DataAccess.createNewProduct
            (
                strProductID, 
                strProductName, 
                strProductDesc, 
                dblUnitPrice, 
                dblPrice,
                strImageFile, 
                intStock, 
                intReOrderlevel, 
                intCategoryID
            );

        retProductNum++;
    } //createProduct





    public void loadProduct(string pProductID)
    {
        Product tmpProduct = DataAccess.getProduct(pProductID);

        strProductID = tmpProduct.getStrProductID();
        strProductName = tmpProduct.getStrProductName();
        strProductDesc = tmpProduct.getStrProductDesc();
        dblUnitPrice = tmpProduct.getUnitPrice();
        dblPrice = tmpProduct.getDblPrice();
        strImageFile = tmpProduct.getStrImageFile();
        intStock = tmpProduct.getIntStock();
        intReOrderlevel = tmpProduct.getReOrderLevel();
        intCategoryID = tmpProduct.getCategoryID();
    }//loadProduct
    


    public string getStrProductID()
    {
        return strProductID;
    }

    public void setStrProductID(string pProductID)
    {
        strProductID = pProductID;
    }

    public string getStrProductName()
    {
        return strProductName;
    }

    public void setStrProductName(string pProductName)
    {
        strProductName = pProductName;
    }

    public string getStrProductDesc()
    {
        return strProductDesc;
    }

    public void setStrProductDesc(string pDescription)
    {
        strProductDesc = pDescription;
    }

    public string getStrImageFile()
    {
        return strImageFile;
    }

    public void setStrImageFile(string pImageFile)
    {
        strImageFile = pImageFile;
    }

    public double getUnitPrice()
    {
        return dblUnitPrice;
    }

    public void setUnitPrice(double pUnitPrice)
    {
        dblUnitPrice = pUnitPrice;
    }

    public double getDblPrice()
    {
        return dblPrice;
    }

    public void setDblPrice(double pPrice)
    {
        dblPrice = pPrice;
    }

    public void setIntStock(int pStock)
    {
        intStock = pStock;
    }

    public int getIntStock()
    {
        return intStock;
    }

    public void setReOrderLevel(int pReOrder)
    {
        intReOrderlevel = pReOrder;
    }

    public int getReOrderLevel()
    {
        return intReOrderlevel;
    }

    public void setCategoryID(int pCatID)
    {
        intCategoryID = pCatID;
    }

    public int getCategoryID()
    {
        return intCategoryID;
    }
    
    public string getCategoryName(int catID)
    {
        return DataAccess.getCategoryName(catID);
    }
    
    public static int updateStock(ArrayList parBasket)
    {
        return DataAccess.updateStock(parBasket);
    }


    public static int addStock(ArrayList parBasket)
    {
        return DataAccess.addStock(parBasket);
    }


    public static int removeProduct(ArrayList parBasket)
    {
        return DataAccess.removeProduct(parBasket);
    }

    public static int editProduct(ArrayList parBasket)
    {
        return DataAccess.updateProductDetails(parBasket);
    }





}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

/// <summary>
/// Summary description for GlobalVar
/// </summary>
public static class GlobalVar
{
    
    public static int specificCat = 0, imgNum = 1; // default all and first image
    public static Boolean allCats = false;
    public static Boolean editproduct = false;
    public static string carName = "Mercedes C63 AMG"; // default first car


    public static DataSet getProducts()
    {
        return DataAccess.getProducts();
    }


    public static void setSpecificCategory(int viewCat, Boolean viewAll, Boolean edit) // set from link click
    {
        specificCat = viewCat;
        allCats = viewAll;
        editproduct = edit;
    }

    public static int getSpecificCategory()
    {
        return specificCat;
    }

    public static Boolean allCategories()
    {
        return allCats;
    }

    public static Boolean editAProduct()
    {
        return editproduct;
    }



    public static void setLHCNum(int i)
    {
        imgNum = i;
    }

    public static int getLHCNum()
    {
        return imgNum;
    }



    public static void setCarSlider(string type)
    {
        carName = type; 
    }

    public static string getCarSlider()
    {
        return carName;
    }











}
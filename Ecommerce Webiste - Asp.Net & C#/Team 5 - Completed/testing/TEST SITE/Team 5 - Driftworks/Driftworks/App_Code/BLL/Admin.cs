using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Admin
/// </summary>
public class Admin
{
    private string email, pwd;

    public Admin(string email, string pwd)
    {
        this.email = email;
        this.pwd = pwd;
    }

    public static Admin checkAdminLogin(string email, string pwd)
    {
       return DataAccess.checkAdminLogin(email, pwd);
    }//checkLogin

    public string getEmail()
    {
        return email;
    }
}
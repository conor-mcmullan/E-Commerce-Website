using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer
{
   
       private string email, lastname, firstname, address, city,
                                                  postcode, phone, pwd;

    public Customer(string email, string lastname,
                     string firstname, string address, string city,
                     string postcode, string phone, string pwd)
    {
        this.email = email;
        this.lastname = lastname;
        this.firstname = firstname;
        this.address = address;
        this.city = city;
        this.postcode = postcode;
        this.phone = phone;
        this.pwd = pwd;
    }//constructor

    //code Added-----------------------------------------------------------------------------------------------------

    public void createCustomer()
    {
        int retCustomernum = DataAccess.createNewCustomer(email, lastname, firstname, address, city,
                                                  postcode, phone, pwd);

        retCustomernum++;
    } //createInvoice


    public Customer()
    {
        
    }//constructor


    public string getEmail()
    {
        return email;
    }

    public void setEmail(string CusEmail)
    {
        email = CusEmail;
    }

    public string getlastName()
    {
        return lastname;
    }

    public void setLastName(string CuslastName)
    {
        lastname = CuslastName;
    }

    public string getFirstName()
    {
        return firstname;
    }

    public void setFirstName(string CusFirstName)
    {
        firstname = CusFirstName;
    }

    public string getHomeAddress()
    {
        return address;
    }

    public void setHomeAddress(string CusAddress)
    {
        address = CusAddress;
    }

    public string getCity()
    {
        return city;
    }

    public void setCity(string CusCity)
    {
        city = CusCity;
    }

    public void setPostcode(string CusPostcode)
    {
        postcode = CusPostcode;
    }

    public string getPostcode()
    {
        return postcode;
    }

       public void setPhone(string CusPhone)
    {
        phone = CusPhone;
    }

    public string getPhone()
    {
        return phone;
    }
    public void setPwd(string CusPwd)
    {
        pwd = CusPwd;
    }

    public string getPwd()
    {
        return pwd;
    }
    
    public void loadCustomer(string CusEmail)
    {
        Customer tmpEmail = DataAccess.getCustomer(CusEmail);

        Email = tmpEmail.getEmail();
        lastname = tmpEmail.getlastName();
        firstname = tmpEmail.getFirstName();
        address = tmpEmail.getHomeAddress();
        city = tmpEmail.getCity();
        postcode = tmpEmail.getPostcode();
        phone = tmpEmail.getPhone();

        pwd = tmpEmail.getPwd();
    }//loadProduct

    //Code added for MyAccountpage------------------------------------------------------------------------------------------------
    
    //public property for field email
    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            email = value;
        }
    }//Email

    public string getFullName()
    {
        string details = "";
        details = this.firstname + " " + this.lastname;
        return details;
    }//getFullname

    public string getAddress()
    {
        string details = "";
        details = this.address;
        details += "<br/>";
        details += this.city;
        details += "<br/>";
        details += this.postcode;
        details += "<br/>";
        return details;
    }//getAddress

    public static Customer checkLogin(string email, string pwd)
    {
        return DataAccess.checkLogin(email, pwd);
    }//checkLogin

    public void storeEmail(string storedEM)
    {
        ProductList.getMyProducts(storedEM);
    }


}//class

    


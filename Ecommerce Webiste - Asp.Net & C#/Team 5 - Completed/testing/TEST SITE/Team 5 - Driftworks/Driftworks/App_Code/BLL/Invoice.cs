using System;
using System.Collections.Generic;
using System.Collections;
using System.Web;

/// <summary>
/// Summary description for Invoice
/// </summary>
public class Invoice
{
    private int intInvoice;
    private string strEmail;
    private DateTime orderDate;
    private double subTotal, total, shippingPrice;
    private string strShipping;

    public Invoice(string pstrEmail, double psubTotal,
                                  double pshipCost, string pshipping)
    {
        strShipping = pshipping;
        shippingPrice = pshipCost;

        strEmail = pstrEmail;
        orderDate = DateTime.Now;
        subTotal = psubTotal;
        total = subTotal + shippingPrice;
    } // Invoice constructor

    public void createInvoice()
    {
        int retInvoiceNum = DataAccess.createNewInvoice(strEmail,
                 strShipping, orderDate, subTotal, total, shippingPrice);

        intInvoice = retInvoiceNum;
    } //createInvoice

    public int getInvoice()
    {
        return intInvoice;
    } //getInvoice


}//Invoice

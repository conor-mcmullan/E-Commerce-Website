using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;


public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, typeof(Page), "JavaScript", "showSlides(1);", true);
        GlobalVar.setSpecificCategory(0, true, false);



        imgHomeLhc.ImageUrl = "~/images/extra/home/lhc/" + GlobalVar.getLHCNum() + ".jpg";
        txtLhc.Text = File.ReadAllText(Server.MapPath("~/Files/home/lhc/" + GlobalVar.getLHCNum() + ".txt"));


        lblCarName.Text = GlobalVar.getCarSlider();
        img1.ImageUrl = "~/images/cars/" + GlobalVar.getCarSlider() + "/1.jpg";
        img2.ImageUrl = "~/images/cars/" + GlobalVar.getCarSlider() + "/2.jpg";
        img3.ImageUrl = "~/images/cars/" + GlobalVar.getCarSlider() + "/3.jpg";
        img4.ImageUrl = "~/images/cars/" + GlobalVar.getCarSlider() + "/4.jpg";
        txtCarDescription.Text = File.ReadAllText(Server.MapPath("~/Files/home/rhc/cars/" + GlobalVar.getCarSlider() + "/desc.txt"));


        imgHomeLhc.Height = 150;
        imgHomeLhc.Width = 275;
        txtLhc.Height = 174;
        txtCarDescription.Height = 377;


        if (!IsPostBack)
        {
            if (User.Identity.IsAuthenticated && Session["customerObj"]!=null)
            {
                lblOutput.Text = "Welcome " + User.Identity.Name;
            }

            if (Session["ADMIN"] != null)
            {
                lblOutput.Text = "ADMIN CONTROLS AVAILABLE";

                chkLhcTxt.Visible = true;
                btnChangeLhcTxt.Visible = true;
                ddlLhcTxt.Visible = true;
                ddlChangeSlider.Visible = true;
                chkChangeSlider.Visible = true;
                btnChangeSlider.Visible = true;
                lblNCheader.Visible = true;
                lblNCName.Visible = true;
                txtNCName.Visible = true;
                lblNCImgs.Visible = true;
                lblNC1.Visible = true;
                fulNC1.Visible = true;
                lblNC2.Visible = true;
                fulNC2.Visible = true;
                lblNC3.Visible = true;
                fulNC3.Visible = true;
                lblNC4.Visible = true;
                fulNC4.Visible = true;
                lblNCDesc.Visible = true;
                fulNCtxt.Visible = true;
                chkNCAdd.Visible = true;
                btnNewCar.Visible = true;
                txtLhc.Height = 133;
                txtCarDescription.Height = 30;
            }
            else
            {
                lblOutput.Text = "";
                chkLhcTxt.Visible = false;
                btnChangeLhcTxt.Visible = false;
                ddlLhcTxt.Visible = false;
                ddlChangeSlider.Visible = false;
                chkChangeSlider.Visible = false;
                btnChangeSlider.Visible = false;
                lblNCheader.Visible = false;
                lblNCName.Visible = false;
                txtNCName.Visible = false;
                lblNCImgs.Visible = false;
                lblNC1.Visible = false;
                fulNC1.Visible = false;
                lblNC2.Visible = false;
                fulNC2.Visible = false;
                lblNC3.Visible = false;
                fulNC3.Visible = false;
                lblNC4.Visible = false;
                fulNC4.Visible = false;
                lblNCDesc.Visible = false;
                fulNCtxt.Visible = false;
                chkNCAdd.Visible = false;
                btnNewCar.Visible = false;
            }

        }
    }
    

    protected void btnChangeLhcTxt_Click(object sender, ImageClickEventArgs e)
    {
        if (chkLhcTxt.Checked == true)
        {
            GlobalVar.setLHCNum(Convert.ToInt32(ddlLhcTxt.SelectedValue));
            Response.Redirect("Home.aspx");
        }
    }


    protected void btnChangeSlider_Click(object sender, ImageClickEventArgs e)
    {
        if (chkChangeSlider.Checked == true){
            string car = ddlChangeSlider.SelectedValue.ToString();
            GlobalVar.setCarSlider(car);
            Response.Redirect("Home.aspx");
        }
    }



    protected void btnNewCar_Click(object sender, ImageClickEventArgs e)
    {
            string newCarName = txtNCName.Text; // the new folder name to make
            string newFileFolder = Server.MapPath("~/Files/home/rhc/cars/" + newCarName);
            string newImageFolder = Server.MapPath("~/images/cars/" + newCarName);
        if (chkNCAdd.Checked == true)// check box ticked
        { 
            Directory.CreateDirectory(newFileFolder);
            Directory.CreateDirectory(newImageFolder);
            ddlChangeSlider.Items.Add(new ListItem(newCarName, newCarName));
            fulNC1.PostedFile.SaveAs(Server.MapPath("~/images/cars/" + newCarName + "/1.jpg"));
            fulNC2.PostedFile.SaveAs(Server.MapPath("~/images/cars/" + newCarName + "/2.jpg"));
            fulNC3.PostedFile.SaveAs(Server.MapPath("~/images/cars/" + newCarName + "/3.jpg"));
            fulNC4.PostedFile.SaveAs(Server.MapPath("~/images/cars/" + newCarName + "/4.jpg"));
            fulNCtxt.PostedFile.SaveAs(Server.MapPath("~/Files/home/rhc/cars/" + newCarName + "/desc.txt"));
            //Response.Redirect("Home.aspx");
        }        
    }






}
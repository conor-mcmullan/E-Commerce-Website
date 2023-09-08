<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
       

        /* start */
        .col {
            height: 600px;
            background-color: white;
            border: solid 0.5px blue;
            float: left;
            margin-left: 10px;
        }

        .inCol {
            text-align: center;
            font-size: medium;
        }

        #left {
            margin: 10px;
            margin-top: 4px;
            width: 300px;
        }

        #center {
            margin: 5px;
            margin-top: 4px;
            width: 300px;
        }

        #right {
            margin: 5px;
            margin-top: 4px;
            width: 300px;
        }



        /*slideshow*/
        /* Slideshow container */
* {box-sizing:border-box}
body {font-family: Verdana,sans-serif;margin:0}
.mySlides {display:none}

.slideshow-container {
  max-width: 1000px;
  position: relative;
  margin: auto;
            top: -40px;
            left: 0px;
            height: 180px;
            width: 280px;
            border: solid 1px #64bff0;
        }

/* Next & previous buttons */
.prev, .next {
  cursor: pointer;
  position: absolute;
  top: 46%;
  width: 0px;
  margin-top: -22px;
  padding: 16px;
  color:lightslategrey;
  font-weight: bold;
  font-size: 18px;
  transition: 0.6s ease;
  border-radius: 0 3px 3px 0;
  left: 240px;
  }

/* Position the "next button" to the right */
.next {
    margin-right:0px;
    /*//float:right;*/
  right: 7px;
  border-radius: 3px 0 0 3px;
}

/* Position the "next button" to the right */
.prev {
    margin-left:0px;
    float:left;
    left: 10px;
    border-radius: 3px 0 0 3px;
}


/* On hover, add a black background color with a little bit see-through */
.prev:hover, .next:hover {
  /*background-color: rgba(0,0,0,0.8);*/
  background-color: #64bff0;
}

/* Caption text */
.text {
  color: black;
  font-size: 15px;
  padding: 8px 12px;
  position: absolute;
  bottom: 8px;
  width: 100%;
  text-align: center;
}

/* Number text (1/3 etc) */
.numbertext {
  color: #64bff0;
  font-size: 12px;
  padding: 8px 12px;
  position: absolute;
  top: 0;
}

/* The dots/bullets/indicators */
.dot {
  cursor:pointer;
  height: 13px;
  width: 13px;
  /*margin: 0 2px;*/
  background-color: #64bff0;
  border-radius: 50%;
  display: inline-block;
  transition: background-color 0.6s ease;
}

.active, .dot:hover {
  background-color: black;
}

/* Fading animation */
.fade {
  -webkit-animation-name: fade;
  -webkit-animation-duration: 1.5s;
  animation-name: fade;
  animation-duration: 1.5s;
}

@-webkit-keyframes fade {
  from {opacity: .4} 
  to {opacity: 1}
}

@keyframes fade {
  from {opacity: .4} 
  to {opacity: 1}
}
        /*slideshow*/
        /* end */
        .auto-style3 {
            text-align: left;
            color: #000000;
        }
        .auto-style4 {
            font-size: large;
            color: rgb(100, 191, 240);
            text-align:center;
        }
        .auto-style5 {
            text-align: center;
            font-size: medium;
            height: 590px;
        }
        .auto-style6 {
            color: #000000;
        }
        .btnStyles {
        background-color:#64BFF0;
        width:150px;
        color:white;
        font-family:Calibri;
        font-size:medium;
        }

        .slideImg {
        width: 190px;
        height: 100px;
        }


        .auto-style7 {
            margin-left: 6px;
        }


        .auto-style8 {
            height: 16px;
        }
        .auto-style9 {
            max-width: 1000px;
            position: relative;
            margin: auto;
            top: -40px;
            left: 0px;
            height: 145px;
            width: 280px;
            border: solid 1px #64bff0;
        }


        </style>


<script language="javascript" type="text/javascript" >
var slideIndex = 1;
showSlides(slideIndex);

function plusSlides(n) {
  showSlides(slideIndex += n);
}

function currentSlide(n) {
  showSlides(slideIndex = n);
}

function showSlides(n) {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  if (n > slides.length) {slideIndex = 1}    
  if (n < 1) {slideIndex = slides.length}
  for (i = 0; i < slides.length; i++) {
      slides[i].style.display = "none";  
  }
  for (i = 0; i < dots.length; i++) {
      dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block";  
  dots[slideIndex-1].className += " active";
}
</script>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
 
        <div class="container">   
            
            <div id="left" class="col">
                  <div class="inCol">  
            <asp:Label ID="lblOutput" runat="server"></asp:Label>
                    
              <br />
                      
     
<div>                
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>  
        <asp:Timer ID="Timer1" runat="server" Interval="5000"></asp:Timer>  
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers><asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" /></Triggers>
        <ContentTemplate>
            <asp:AdRotator ID="AdRotator1" runat="server"  BorderColor="#64BFF0" BorderStyle="Solid" BorderWidth="1px" Height="100px" Width="140px" AlternateTextField="Image missing" DataSourceID="XmlDataSource1"/>
            <asp:AdRotator ID="AdRotator2" runat="server"  BorderColor="#64BFF0" BorderStyle="Solid" BorderWidth="1px" Height="100px" Width="140px" AlternateTextField="Image missing" DataSourceID="XmlDataSource2"/>
            <asp:AdRotator ID="AdRotator3" runat="server"  BorderColor="#64BFF0" BorderStyle="Solid" BorderWidth="1px" Height="100px" Width="140px" AlternateTextField="Image missing" DataSourceID="XmlDataSource3"/>
            <asp:AdRotator ID="AdRotator4" runat="server"  BorderColor="#64BFF0" BorderStyle="Solid" BorderWidth="1px" Height="100px" Width="140px" AlternateTextField="Image missing" DataSourceID="XmlDataSource4"/>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/ads1.xml"></asp:XmlDataSource>
            <asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="~/App_Data/ads2.xml"></asp:XmlDataSource>
            <asp:XmlDataSource ID="XmlDataSource3" runat="server" DataFile="~/App_Data/ads3.xml"></asp:XmlDataSource>
            <asp:XmlDataSource ID="XmlDataSource4" runat="server" DataFile="~/App_Data/ads4.xml"></asp:XmlDataSource>
        </ContentTemplate>
    </asp:UpdatePanel>
</div> 
    
                      
                      
                      
    <hr />Meet The Team<br />
    <asp:Image ID="imgHomeLhc" runat="server" /> 
    <br />
    
    <asp:TextBox ID="txtLhc" runat="server" BorderColor="#64BFF0" BorderStyle="Solid" BorderWidth="1px" Columns="1" CssClass="auto-style3" ReadOnly="True" TextMode="MultiLine" Width="280px" Font-Size="11px" style="font-family: Calibri; font-style: normal; text-align: left;"></asp:TextBox>
    <br />
        

    <%--admin content below--%>
    
    <asp:DropDownList ID="ddlLhcTxt" runat="server" BorderColor="#64BFF0" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style3" Height="30px" Width="130px" Visible="False">
        <asp:ListItem Value="1">1. Contact Us</asp:ListItem>
        <asp:ListItem Value="2">2. About Us</asp:ListItem>
        <asp:ListItem Value="3">3. Meet The Team</asp:ListItem>
        <asp:ListItem Value="4">4. Drifting Info</asp:ListItem>
    </asp:DropDownList>

    <asp:CheckBox ID="chkLhcTxt" runat="server" Text="Confirm" Visible="False" />
    <asp:ImageButton Height="30px" Width="70px" ID="btnChangeLhcTxt" runat="server" ImageUrl="~/images/extra/buttons/btnChange.png" OnClick="btnChangeLhcTxt_Click" Visible="False" />
                      
                                                              
    <br /><br />                  
    <%--admin content above--%>
    
                          
          </div>
    </div>

            <div id="center" class="col">
                  <div class="inCol" style="font-family: Calibri; font-size: 16px; font-style: normal; text-align: left; height: 353px;" align="left">
                        <h2 class="auto-style4">THE WORLDS LARGEST DRIFTING WEBSITE, PARTS STORE AND FORUM.</h2>
                          <p style="font-family: calibri; font-size: medium; font-weight: normal; font-style: normal; font-variant: normal">
                    <span class="auto-style6">
                        Welcome to Driftworks! We are proud to be part of the small group of friends that first established drifting in the UK and Europe.
                        <br /><br />Our journey from first gear donuts to competing and winning international drifting competitions has been one of the most difficult, rewarding, and most of all fun things we’ve ever had the pleasure to be a part of.<br />
                        <br />Now we share our wealth of experience and knowledge to provide you with the parts and setup advice to build an amazing practice toy, or competition winning weapon.
                    </span>
                      </p>
                      <br /> 
                      <div>
                      <iframe width="280" height="158" src="https://www.youtube.com/embed/FsW9lE3VoK8" frameborder="0" allowfullscreen="true" class="auto-style7"></iframe>
                      </div>
                    <br />
                           

                      <br />       
                  </div>
            </div>


            <div id="right" class="col">
                  <div class="auto-style5">
        
                      <br /><br /><br />

                    <div class="auto-style9">
                        <br />
                          <div class="mySlides fade">
                          <div class="numbertext">1 / 4</div><br />
                            <%--<img src="images/cars/1.jpg" style="width:190px; height:100px;">--%>
                            <asp:Image ID="img1" runat="server" CssClass="slideImg"  /> 
                          </div>

                         <div class="mySlides fade">
                            <div class="numbertext">2 / 4</div><br />
                            <%--<img src="images/cars/2.jpg" style="width:190px; height:100px;">--%>
                            <asp:Image ID="img2" runat="server" CssClass="slideImg"  /> 
                         </div>

                          <div class="mySlides fade">
                            <div class="numbertext">3 / 4</div><br />
                            <%--<img src="images/cars/3.jpg" style="width:190px; height:100px;">--%>
                            <asp:Image ID="img3" runat="server" CssClass="slideImg"  />
                          </div>

                         <div class="mySlides fade">
                            <div class="numbertext">4 / 4</div><br />
                            <%--<img src="images/cars/8.jpg" style="width:190px; height:100px;">--%>
                             <asp:Image ID="img4" runat="server" CssClass="slideImg"  />
                         </div>                          

                          <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
                          <a class="next" onclick="plusSlides(1)">&#10095;</a>
                          
                        </div>

                      <div class="auto-style8" style="text-align:center; margin-top: -40px;">
                          <span class="dot" onclick="currentSlide(1)"></span> 
                          <span class="dot" onclick="currentSlide(2)"></span> 
                          <span class="dot" onclick="currentSlide(3)"></span> 
                          <span class="dot" onclick="currentSlide(4)"></span>     
                    </div>

                        
                      
                        

                      <hr /> 
                      <asp:Label ID="lblCarName" runat="server" ></asp:Label>
                      <br />
                      <asp:TextBox ID="txtCarDescription" runat="server" BorderColor="#64BFF0" BorderStyle="Solid" BorderWidth="1px" Columns="1" CssClass="auto-style3" ReadOnly="True" Rows="4" TextMode="MultiLine" Width="280px" style="font-family: Calibri; font-style: normal; text-align: left;" Font-Size="11px" Height="19px">Text file </asp:TextBox>   
                      <br />
                      <hr />
                      <asp:DropDownList ID="ddlChangeSlider" runat="server">
                          <asp:ListItem>Mercedes C63 AMG</asp:ListItem>
                          <asp:ListItem>Nissan Skyline R33</asp:ListItem>
                          <asp:ListItem>Pontiac GTO</asp:ListItem>
                      </asp:DropDownList>
                      <asp:CheckBox ID="chkChangeSlider" runat="server" Text="Confirm" />
                      <asp:ImageButton ID="btnChangeSlider" runat="server" Height="30px" Width="70px" ImageUrl="~/images/extra/buttons/btnChange.png" OnClick="btnChangeSlider_Click" />
                      <hr />
                      <asp:Label ID="lblNCheader" runat="server" Text="Add New Car Details Below."></asp:Label>
                      <br /><br />
                      <asp:Label ID="lblNCName" runat="server" Text="Car Name: "></asp:Label>
                      &nbsp;&nbsp;&nbsp;
                      <asp:TextBox ID="txtNCName" runat="server"></asp:TextBox>
                      <br /><br />
                      <asp:Label ID="lblNCImgs" runat="server" Text="New Car Images Below."></asp:Label>
                      <br />
                      <asp:Label ID="lblNC1" runat="server" Text="Image 1"></asp:Label>
                      &nbsp;&nbsp;&nbsp;
                      <asp:FileUpload ID="fulNC1" runat="server" Width="180px" />
                      <br />
                      <asp:Label ID="lblNC2" runat="server" Text="Image 2"></asp:Label>
                      &nbsp;&nbsp;&nbsp;
                      <asp:FileUpload ID="fulNC2" runat="server" Width="180px" />
                      <br />
                      <asp:Label ID="lblNC3" runat="server" Text="Image 3"></asp:Label>
                      &nbsp;&nbsp;&nbsp;
                      <asp:FileUpload ID="fulNC3" runat="server" Width="180px" />
                      <br />
                      <asp:Label ID="lblNC4" runat="server" Text="Image 4"></asp:Label>
                      &nbsp;&nbsp;&nbsp;
                      <asp:FileUpload ID="fulNC4" runat="server" Width="180px" />
                      <br /><br />
                      <asp:Label ID="lblNCDesc" runat="server" Text="New Car Details Below."></asp:Label>
                      <br />
                      <asp:FileUpload ID="fulNCtxt" runat="server" Width="179px" />
                      <asp:CheckBox ID="chkNCAdd" runat="server" Text="Confirm" />
                      <asp:ImageButton ID="btnNewCar" runat="server" Height="30px" Width="50px" ImageUrl="~/images/extra/buttons/btnAdd.png" OnClick="btnNewCar_Click" />
                      
                        





                  </div>
            </div>

            <%-- finish --%>
        </div>
    <br />
    

    



</asp:Content>


<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Popularity.aspx.vb" Inherits="Popularity" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title></title>
		<link href="css/style.css" rel="stylesheet" type="text/css"  media="all" />
		<link href='http://fonts.googleapis.com/css?family=Roboto+Condensed' rel='stylesheet' type='text/css'>
		<link href='http://fonts.googleapis.com/css?family=Armata|Julius+Sans+One' rel='stylesheet' type='text/css'>
		<link rel="stylesheet" href="css/craftyslide.css" />
		<SCRIPT src="js/jquery.min.js" type=text/javascript></SCRIPT>
</head>
	<body>
	<form id="Form1" runat="server">
		<!--  start-wrap -->
		<div class="wrap">
			<!--  start-Header -->
			<div class="header">
				<!--  start-logo -->
				<div class="logo">
					<a href="index.html"><img src="images/logo.png" alt=""/></a>
				</div>
				
				<!--End-logo -->
				<div class="clear"> </div>
				<!--TOP-NAV-->
				
			</div>
				<!--END-TOP-NAV-->
			<div class="clear"> </div>
			<!--image-slider-->
			<div id="slideshow">
	        <ul>
	          <li>
	            <img src="images/slide1.png" alt="" title=" " />
	          </li>
	          
	          <li>
	            <img src="images/slide2.png" alt="" title="" />
	          </li>
	          
	          <li>           
	            <img src="images/slide3.png" alt="" title="" />
	          </li>
	          
	          <li>           
	            <img src="images/slide1.png" alt="" title="" />
	          </li>
	          
	          <li>           
	            <img src="images/slide2.png" alt="" title=" " />
	          </li>	                         
	        </ul>
      </div>   
      
      <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.1/jquery.min.js"></script>
      <script src="js/craftyslide.min.js"></script>
      
      <script>
        $("#slideshow").craftyslide();
      </script> 
      <div class="clear"> </div>  
      <!--End-image-slider-->
       <!--banner-->
      <div class="banner">
      	<div class="banner-grid">
      		<ul>
      			<li><h2>Welcome</h2></li>
      			<li><p></p>
      		</li>
      		<li></li>
      		<div class="clear"> </div>
      		</ul>
      	</div>
      	</div>
      	<div class="clear"> </div>
      	<!--banner-end-->
      	<div class="clear"> </div>
      	<!--content-grids-->
      	<div class="content-grids">
      	          
            
            <div style="width:25%;float:left;">
            <div class="content-last">
      		<div class="grid2">
			 <h4>Name Popularity</h4>
		      <div class="booking">	
                <form action="#" id="reservation-form">
	              <fieldset>
	              
	              <div class="field">
	                	<h5>Select Details:<hr style="margin-right :20px;"/></h5>
	                  <label style="padding-right:10px;">Name</label>
	                  
                <asp:TextBox ID="txtName" runat="server" Width="100px" Height="10px"></asp:TextBox>
	          
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ErrorMessage="*" ToolTip="Can't Blank" ControlToValidate="txtName" 
                            ValidationGroup="a"></asp:RequiredFieldValidator>
	                </div>
	              
	                
	              
	              
	                <div class="field">
	                	
	                  <label style="padding-right:23px;">Year</label>
	                  
	                  
                <asp:DropDownList ID="ddlYear" runat="server">
                </asp:DropDownList>
	                </div>
	                <div class="field">
	                  <label>Gender </label>
	                  
                    <asp:DropDownList ID="ddlGender" runat="server">
                    </asp:DropDownList>
                   
	                </div>
	                
	                <div class="button">
                        <asp:Button ID="Button1" runat="server" Text="Filter" CssClass="Button"/>
                        
                        <asp:Button ID="btnBack" runat="server" Text="<< Back" CssClass="Button"/>
                        </div>
	              </fieldset>
            </form>
           <div class="clear"> </div>
         </div>
		</div>
      	</div>
            </div>
            
            <div style="width:75%;float:right ;">
                    <br />
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" Width="100%" EmptyDataText="No Result Avaliable.">
                    <RowStyle BackColor="#EFF3FB" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" 
                        HorizontalAlign="Left" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </div>
      	</div>
    
      	
      		
           
 
           
           
           
           
           
           
           
           
           
           
           
        
      	<div class="clear"> 	</div>
      
		<div class="footer">
			<div class="wrap">
      		<div class="footer-nav"> 
					
			</div>
			<div class="copy-right">
				
			</div>
			</div>
      	</div>
   </form>
	</body>
</html>

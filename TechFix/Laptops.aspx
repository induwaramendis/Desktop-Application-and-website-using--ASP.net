<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Laptops.aspx.cs" Inherits="TechFix.Laptops" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lenovo</title>

    <style>
        /* Basic Styles */
body {
    font-family: Arial, sans-serif;
    background-color: #f9f9f9;
    margin: 0;
    padding: 0;
}

.container {
    display: flex;
    flex-wrap: wrap;
    padding: 20px;
}

.breadcrumb {
    width: 100%;
    padding: 10px;
    background-color: #ff0000;
    display: flex;
    justify-content: space-between;
    align-items: center;
    font-size: 14px;
    color: white;
    margin-bottom: 20px;
}

/* Filter Section */
.filter-section {
    width: 35%;
    background-color: #fff;
    padding: 20px;
    border-radius: 10px;
}

.filter-section h3 {
    font-size: 16px;
    margin-bottom: 10px;
}

.price-filter input {
    width: 50%;
    padding: 5px;
    margin-right: 5px;
}

.price-filter button {
    padding: 5px 10px;
    background-color: #007bff;
    color: white;
    border: none;
    cursor: pointer;
}

.filter label {
    font-size: 14px;
}

/* Product Section */
.product-section {
    width: 90%;
    margin-left: 20px;
}

.sort-bar {
    display: flex;
    justify-content: flex-end;
    margin-bottom: 20px;
}

.sort-bar select {
    padding: 5px;
    border: 1px solid #ccc;
    border-radius: 5px;
}

.product-grid {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 20px;
}

.product-card {
    background-color: #fff;
    padding: 15px;
    border-radius: 10px;
    box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
    text-align: center;
}
.product-card :hover{
    background-color:#ff0000;
    color:white;
}


.product-badge {
    position: absolute;
    top: 10px;
    left: 10px;
    background-color: #ff6f00;
    color: #fff;
    padding: 5px;
    border-radius: 5px;
    font-size: 12px;
}

.product-img img {
    width: 100%;
    height: auto;
}

.product-info h4 {
    font-size: 16px;
    color: #333;
    margin: 10px 0;
}

.product-info p {
    font-size: 14px;
    color: #666;
}

.price {
    font-size: 18px;
    color: #d9534f;
}

.price del {
    color: #999;
}

.product-actions {
    margin-top: 10px;
}

.product-actions button {
    padding: 8px 12px;
    margin: 5px;
    background-color: #007bff;
    color: #fff;
    border: none;
    border-radius: 5px;
    cursor: pointer;
}.navbar1 ul {
    list-style-type: none;
    margin: 0;
    padding: 0;
    width: 25%;
    background-color: #f1f1f1;
    position: absolute;
    height: 100%;
    overflow: auto;
    border: 1px solid #555;
    transition: width 2s,height 2s  ;
}

.navbar1 li a {
    display: block;
    color: #000;
    font-size: 24px;
    font-weight: bold;
    padding: 20px 16px;
    text-decoration: none;
    border-bottom: 1px solid #555;
   
}

    .navbar1 li a.active {
        background-color: #04AA6D;
        color: white;
    }

        .navbar1 li a:hover:not(.active) {
            background-color: #ff0000;
            color: white;
            width: 500px;
            height: 1;
        }
                header {
    background-color: #fff;
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 20px;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}

    header .logo h1 {
        padding-left:5px;
        font-size: 32px;
        color: #ff0000;
        margin-left:10px;
    }
    .navbar ul {
    list-style: none;
    display: flex;
}

    .navbar ul li {
        margin: 0 15px;
    }

        .navbar ul li a {
            font-size: 16px;
            color: #333;
        }


    </style>
</head>
<body>
        <header>
    <div class="logo">
        <h1>TechFix</h1>
    </div>
             <nav class="navbar">
     <ul>
         <li><a href="CustomerHomePage.aspx">Home</a></li>
         
        <li><a href="NewArrivals.aspx">New Arrivals</a></li>
         <li><a href="#brands">Our Brands</a></li>
         <li><a href="Repairs.aspx">Repairs</a></li>
         <li><a href="Orders.aspx">Place Order</a></li>
          <li><a href="Messages.aspx">Contact Us</a></li>
        
     </ul>
 </nav>
   
</header>
    <form id="form1" runat="server">
        <div class="container">
        <!-- Breadcrumb -->
        <div class="breadcrumb">
            <p>Home / Shop / Laptops</p>
            
        </div>
                                    <nav class="navbar1">
<ul>
<li><a href="Console.aspx">Console & Handheld Gaming</a></li>
<li><a href="Graphics_Tablet.aspx">Graphics Tablet / Tab</a></li>
<li><a href="Laptops.aspx">Laptops</a></li>
<li><a href="Desktop_Workstations.aspx">Desktop Workstations</a></li>
  <li><a href="Gaming Desktops.aspx">Gaming Desktops</a></li>
  <li><a href="Budget_Desktop_Computers.aspx">Budget Desktop Computers</a></li>
  <li><a href="Processors.aspx">Processors</a></li>
  <li><a href="MotherBoards.aspx">MotherBoards</a></li>
  <li><a href="Memory (RAM).aspx">Memory (RAM)</a></li>
   <li><a href="Graphic Cards.aspx">Graphic Cards</a></li>
   <li><a href="POWER SUPPLy.aspx">POWER SUPPLY, UPS & SURGE PROTECTORS</a></li>
   <li><a href="GAMING CHAIRS.aspx">GAMING CHAIRS</a></li>
   <li><a href="MONITORS_ACCESSORIES.aspx">MONITORS & ACCESSORIES</a></li>

</ul>
</nav>
        <!-- Filter Section --><div style="margin-left:25%;padding:10px 16px;height:5px;">
       
</div>
             <div style="margin-left:35%;padding:1px 16px;height:1000px;width:1800px">
        <!-- Product Section -->
       

            <div class="product-grid">
                <div class="product-card">
                    <div class="product-badge flash-deal">Flash Deal</div>
                    <div class="product-img">
                        <img src="images/Lenovo Legion.jpg" alt="HP Victus 15">
                    </div>
                    <div class="product-info">
                        <h4>Lenovo Legion 9 | 16IRX9 | i9-14900HX | RTX 4090</h4>
                        <p>GAMING LAPTOPS, Lenovo <span class="condition">Brand New</span></p>
                        <p class="price"><del>₨1,499,000.00</del> ₨1,395,000.00</p>
                        
                    </div>
                </div>

                 <div class="product-card">
                    <div class="product-badge flash-deal">Flash Deal</div>
                         <div class="product-img">
                              <img src="images/Lenovo LOQ.jpg" alt="HP Victus 15">
                         </div>
                      <div class="product-info">
                          <h4>Lenovo LOQ 15IRX9 | i7 13th GEN | HX + RTX 4050 6GB</h4>
                              <p>GAMING LAPTOPS, Lenovo <span class="condition">Brand New</span></p>
                                 <p class="price">₨399,000.00</p>
                                    
                         </div>
                    </div>

                               <div class="product-card">
 <div class="product-badge flash-deal">Flash Deal</div>
     <div class="product-img">
         <img src="images/LENOVO IDEAPAD 5 2-in-1.jpg" alt="HP Victus 15">
     </div>
    <div class="product-info">
            <h4>LENOVO IDEAPAD 5 | 2-in-1 |INTEL CORE 7 14TH GEN </h4>
                  <p>LAPTOPS, Lenovo <span class="condition">Brand New</span></p>
                  <p class="price">₨319,000.00</p>
       
     </div>
</div>

                   

                 <div class="product-card">
    <div class="product-badge flash-deal">Flash Deal</div>
        <div class="product-img">
            <img src="images/LENOVO IDEAPAD SLIM 3.jpeg" alt="HP Victus 15">
        </div>
       <div class="product-info">
               <h4>LENOVO IDEAPAD SLIM 3 | 15IRU8 CORE I3 | 13TH GEN | 8GB </h4>
                     <p>LAPTOPS, Lenovo <span class="condition">Brand New</span></p>
                     <p class="price">₨153,000.00</p>
           
        </div>
   </div>

                <div class="product-card">
    <div class="product-badge flash-deal">Flash Deal</div>
    <div class="product-img">
        <img src="images/MacBook-Air-13.jpg" alt="HP Victus 15">
    </div>
    <div class="product-info">
        <h4>APPLE MACBOOK AIR M3 | 8GB 256GB | 13" | (2024)</h4>
        <p> LAPTOPS, Apple <span class="condition">Brand New</span></p>
        <p class="price"><del>₨365,000.00</del> ₨349,000.00</p>
        
    </div>
</div>
                 <div class="product-card">
    <div class="product-badge flash-deal">Flash Deal</div>
        <div class="product-img">
            <img src="images/APPLE MACBOOK AIR M2.jpg" alt="HP Victus 15">
        </div>
       <div class="product-info">
               <h4>APPLE MACBOOK AIR M2 | 8GB 256GB | 15" | (2023)</h4>
                     <p>LAPTOPS, Apple <span class="condition">Brand New</span></p>
                     <p class="price"><del>₨410,000.00</del> ₨395,000.00</p>
           
        </div>
   </div>
                <div class="product-card">
          <div class="product-badge flash-deal">Flash Deal</div>
             <div class="product-img">
             <img src="images/Mac Mini M2 Pro.jpeg" alt="HP Victus 15">
            </div>
     <div class="product-info">
              <h4>Mac Mini M2 Pro | 16GB 512GB</h4>
                 <p>LAPTOPS, Apple <span class="condition">Brand New</span></p>
                 <p class="price"> ₨449,000.00</p>
            
     </div>
    </div>
                             <div class="product-card">
<div class="product-badge flash-deal">Flash Deal</div>
     <div class="product-img">
          <img src="images/MacBook Pro M3 Pro.jpeg" alt="HP Victus 15">
     </div>
  <div class="product-info">
      <h4>APPLE MACBOOK AIR M3 pro | 18GB 1TB | 14" | (2024)</h4>
          <p>GAMING LAPTOPS, Apple <span class="condition">Brand New</span></p>
             <p class="price">₨659,000.00</p>
               
     </div>
</div>
                <div class="product-card">
    <div class="product-badge flash-deal">Flash Deal</div>
    <div class="product-img">
        <img src="images/asus_zenbookpeg.jpeg" alt="HP Victus 15">
    </div>
    <div class="product-info">
        <h4>Asus Zenbook 14 | Q415MA Intel Core Ultra 5-125H | 8GB DDR5 | 512GB SSD | Intel Graphics | 14" WUXGA 60Hz OLED Touch Screen Display | Windows 11 Home | Jasper Gray NoteBook</h4>
        <p> LAPTOPS, Asus <span class="condition">Brand New</span></p>
        <p class="price"> ₨264,000.00</p>
       
    </div>
</div>
                <div class="product-card">
   <div class="product-badge flash-deal">Flash Deal</div>
        <div class="product-img">
             <img src="images/asus-rog.jpg" alt="HP Victus 15">
        </div>
     <div class="product-info">
         <h4>ASUS ROG Strix G16 G614JV | 16" 2K FHD+ IPS 165Hz Display | Intel Core i9-13980HX | 16GB RAM | 1TB SSD | GeForce RTX 4060 8GB GPU | ENG Backlit K/B | Win 11</h4>
             <p> LAPTOPS, Asus <span class="condition">Brand New</span></p>
                <p class="price">₨210,000.00</p>
                 
        </div>
   </div>
                <div class="product-card">
   <div class="product-badge flash-deal">Flash Deal</div>
       <div class="product-img">
           <img src="images/asus_tuf.jpeg" alt="HP Victus 15">
       </div>
      <div class="product-info">
              <h4>ASUS TUF Gaming A15 AMD Ryzen™ 7 7435HS | RTX 4050 6GB DDR6 | 16GB DDR5 | 15.6-inch 144Hz - Mecha Gray Gaming Laptop </h4>
                    <p>LAPTOPS, Asus <span class="condition">Brand New</span></p>
                    <p class="price"><del>₨345,000.00</del> ₨322,500.00</p>
         
       </div>
  </div>
                <div class="product-card">
          <div class="product-badge flash-deal">Flash Deal</div>
             <div class="product-img">
             <img src="images/asus_vivo.jpeg" alt="HP Victus 15">
            </div>
     <div class="product-info">
              <h4>ASUS Vivobook Pro 15 OLED 2024 | 15.6" FHD | 16-Core Intel Ultra 7 155H | 16GB DDR5 | 1TB SSD | NVIDIA GeForce RTX 3050 6GB | Win10 Pro Gaming Laptop</h4>
                 <p>LAPTOPS, Asus <span class="condition">Brand New</span></p>
                 <p class="price"> ₨359,000.00</p>
            
     </div>
    </div>
                <div class="product-card">
    <div class="product-badge flash-deal">Flash Deal</div>
    <div class="product-img">
        <img src="images/dell_inspiron.png" alt="HP Victus 15">
    </div>
    <div class="product-info">
        <h4>Dell Inspiron 3520 | i5 12th Generation</h4>
        <p>GAMING LAPTOPS, DELL <span class="condition">Brand New</span></p>
        <p class="price"> ₨179,000.00</p>
        
    </div>
</div>
                <div class="product-card">
   <div class="product-badge flash-deal">Flash Deal</div>
        <div class="product-img">
             <img src="images/dell_vostro.jpg" alt="HP Victus 15">
        </div>
     <div class="product-info">
         <h4>DELL VOSTRO 3520 i5-1235U | 8GB DDR4 | 256GB NVME | WINDOWS 11 PRO</h4>
             <p> LAPTOPS, DELL <span class="condition">Brand New</span></p>
                <p class="price">₨210,000.00</p>
                  
        </div>
   </div>
                <div class="product-card">
   <div class="product-badge flash-deal">Flash Deal</div>
       <div class="product-img">
           <img src="images/dell_latitude.jpg" alt="HP Victus 15">
       </div>
      <div class="product-info">
              <h4>Dell Latitude 7430 | 8GB DDR4 | 512GB NVME | WINDOWS 10 PRO </h4>
                    <p>LAPTOPS, DELL <span class="condition">Brand New</span></p>
                    <p class="price"><del>₨504,000.00</del> ₨490,000.00</p>
         
       </div>
  </div>
                <div class="product-card">
          <div class="product-badge flash-deal">Flash Deal</div>
             <div class="product-img">
             <img src="images/Dell-XPS.jpg" alt="HP Victus 15">
            </div>
     <div class="product-info">
              <h4>Dell XPS 13 9340 | Ultra 7 | 1TB | 16GB | Windows 11</h4>
                 <p>LAPTOPS, DELL <span class="condition">Brand New</span></p>
                 <p class="price"> ₨649,000.00</p>
            
     </div>
    </div>
                <div class="product-card">
    <div class="product-badge flash-deal">Flash Deal</div>
    <div class="product-img">
        <img src="images/hp-vitus.jpeg" alt="HP Victus 15">
    </div>
    <div class="product-info">
        <h4>HP Victus 15-15 FB2082WM | AMD Ryzen 5 | 8GB RAM | 512GB SSD</h4>
        <p>GAMING LAPTOPS, HP <span class="condition">Brand New</span></p>
        <p class="price"><del>₨285,000.00</del> ₨272,000.00</p>
        
    </div>
</div>
                <div class="product-card">
   <div class="product-badge flash-deal">Flash Deal</div>
        <div class="product-img">
             <img src="images/hp_omen.jpg" alt="HP Victus 15">
        </div>
     <div class="product-info">
         <h4>HP OMEN 16-wd0073dx | i7-13620H | 16GB DDR5 | 1TB NVMe | RTX 4060 | 16.1'' 165Hz FHD | Win11</h4>
             <p>GAMING LAPTOPS, HP <span class="condition">Brand New</span></p>
                <p class="price">₨440,000.00</p>
                  
        </div>
   </div>
                <div class="product-card">
   <div class="product-badge flash-deal">Flash Deal</div>
       <div class="product-img">
           <img src="images/hp_13thgen.jpg" alt="HP Victus 15">
       </div>
      <div class="product-info">
              <h4>HP VICTUS 15 i5 13TH GEN | RTX 3050 6GB | 8GB RAM | 512GB NVME | 15.6" Full HD 144Hz | WIN 11 HOME</h4>
                    <p>LAPTOPS, HP <span class="condition">Brand New</span></p>
                    <p class="price"><del>₨310,000.00</del> ₨265,000.00</p>
          
       </div>
  </div>
                <div class="product-card">
          <div class="product-badge flash-deal">Flash Deal</div>
             <div class="product-img">
             <img src="images/hp-envy.png" alt="HP Victus 15">
            </div>
     <div class="product-info">
              <h4>HP ENVY X360 | 14-ES1013DX Core 5 | 14th GEN</h4>
                 <p>LAPTOPS, HP <span class="condition">Brand New</span></p>
                 <p class="price"> ₨249,000.00</p>
            
     </div>
    </div>

                <!-- Additional Product Cards here -->
            </div>
        </div>
    </div>
</div>
    </form>
</body>
</html>
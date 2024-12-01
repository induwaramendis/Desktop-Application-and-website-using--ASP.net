<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home Page.aspx.cs" Inherits="TechFix.Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TechFix - Website</title>
    <link rel="stylesheet" href="styles.css">
    <script src="script.js"></script>

<style>
             * {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: Arial, sans-serif;
}

a {
    text-decoration: none;
    color: #333;
}

/* Top Bar */
.top-bar {
    background-color: #ff0000;
    color: white;
    padding: 10px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    font-size: 14px;
}

.top-bar-right a {
    color: white;
    margin-left: 15px;
    text-decoration: none;
    font-size: 14px;
    padding: 8px 12px;
    border: 1px solid white;
    border-radius: 4px;
    transition: background-color 0.3s;
}

    .top-bar-right a:hover {
        background-color: white;
        color: white;
    }

/* Header */
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
.header-buttons {
    display: flex;
}

    .header-buttons .btn {
        background-color: #ff0000;
        padding: 8px 15px;
        margin-left: 10px;
        border: none;
        border-radius: 5px;
        text-decoration: none;
        font-size: 20px;
        font-weight: bold;
        cursor: pointer;
        color:white;
    }

        .header-buttons .btn:hover {
            background-color: #0056b3;
            color: white;
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

/* Search Bar */
.search-bar {
    background-color: #f1f1f1;
    padding: 20px;
    display: flex;
    justify-content: center;
}

    .search-bar input {
        width: 50%;
        padding: 10px;
        font-size: 16px;
    }

    .search-bar button {
        padding: 10px 20px;
        background-color: #ff0000;
        color: white;
        border: none;
        cursor: pointer;
        font-size: 16px;
    }
.navbar1 ul {
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
        height: 100px;
    }
/* Hero Section */
/* Hero Section */
.hero {
    background-color: #ff0000;
    padding: 50px 20px;
    position: relative;
    overflow: hidden;
    width: 1200px;
    height: 700px;
}

.slides {
    position: relative;
    width: 100%;
    height: 100%;
}

.hero-slide {
    position: absolute;
    top: 0;
    left: 0;
    width: 1200px;
    height: 600px;
    opacity: 0;
    transition: opacity 0.5s ease-in-out;
}

    .hero-slide.active {
        opacity: 1;
    }

.hero-text h2 {
    font-size: 36px;
    color: white;
}

.hero-text p {
    font-size: 18px;
    color: white;
}

.hero-image img {
    align-items:center;
    width: 800px;
    height: 550px;
}


/* Brands Section */
.brands-section {
    padding: 50px 20px;
    text-align: center;
}

    .brands-section h2 {
        font-size: 28px;
        margin-bottom: 20px;
    }

.brand-logos {
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
}

    .brand-logos img {
        width: 100px;
        height: auto;
        margin: 10px;
    }

/* Responsive Design */
@media (max-width: 768px) {
    .hero {
        flex-direction: column;
        text-align: center;
    }

    .search-bar input {
        width: 80%;
    }
}


 .footer .grid{
   display: grid;
   grid-template-columns: repeat(auto-fit, minmax(27rem, 1fr));
   gap:1.5rem;
   align-items: flex-start;
}

.footer .grid .box{
   border:var(--border);
   padding:2rem;
   text-align: center;
}

.footer .grid .box img{
   height: 10rem;
   width: 100%;
   object-fit: contain;
   margin-bottom: .5rem;
}

.footer .grid .box h3{
   margin:1rem 0;
   font-size: 2rem;
   color:black;
   text-transform: capitalize;
}

.footer .grid .box p,
.footer .grid .box a{
   display: block;
   font-size: 1.7rem;
   color:bisque;
   line-height: 1.8;
}

.footer .grid .box a:hover{
   text-decoration: underline;
}

.credit{
   padding:3rem 2rem;
   text-align: center;
   background-color: black;
   color:white;
   font-size: 2rem;
   text-transform: capitalize;
   /* padding-bottom: 10rem; */
}

.credit span{
   color:yellow;
}

.loader{
   position: fixed;
   top:0; left:0; right:0; bottom: 0;
   z-index: 100;
   background-color: white;
   display: flex;
   align-items: center;
   justify-content: center;
}

.loader img{
   height: 25rem;
}
.header-buttons {

    background-color:#ff0000;
    
}
</style>
</head>
<body>
    <form id="form1" runat="server">
       <!-- Top Bar -->
    <div class="top-bar">
        <div class="contact-info">
            <span>Hotline: </span><a href="tel:+94779426462">077 942 6462</a>
        </div>
       
    </div>

    <!-- Header -->
    <header>
        <div class="logo">
            <h1>TechFix</h1>
        </div>
        <nav class="navbar">
            <ul>
                <li><a href="Home Page.aspx">Home</a></li>
                <li><a href="#">New Arrivals</a></li>
                <li><a href="#">Place Order</a></li>
                <li><a href="#brands">Our Brands</a></li>
                <li><a href="#">Repairs</a></li>
                <li><a href="#">Contact Us</a></li>
                 
            </ul>
        </nav>
       
        <div class="header-buttons">
            <a href="Login Page.aspx" class="btn login">Login</a>
           
        </div>
    </header>

    <!-- Search Bar -->
    <div class="search-bar">
        <input type="text" placeholder="Search Your Products">
        <button>Search</button>
    </div>
<nav class="navbar1">
<ul>
  <li><a href="#">Console & Handheld Gaming</a></li>
  <li><a href="#">Graphics Tablet / Tab</a></li>
  <li><a href="#">Laptops</a></li>
  <li><a href="#">Desktop Workstations</a></li>
    <li><a href="#">Gaming Desktops</a></li>
    <li><a href="#">Budget Desktop Computers</a></li>
    <li><a href="#">Processors</a></li>
    <li><a href="#">MotherBoards</a></li>
    <li><a href="#">Memory (RAM)</a></li>
     <li><a href="#">Graphic Cards</a></li>
     <li><a href="#">POWER SUPPLY, UPS & SURGE PROTECTORS</a></li>
     <li><a href="#">GAMING CHAIRS</a></li>
     <li><a href="#">MONITORS & ACCESSORIES</a></li>

</ul>
</nav>
<div style="margin-left:25%;padding:1px 16px;height:1000px;">
    <!-- Hero Section -->
  <center> <div class="hero">
    <div class="slides">
        <div class="hero-slide active">
            <div class="hero-text">
                <h2>KOORUI</h2>
                <p><b>Leading the new trend of gaming and office</b></p>
            </div>
            <div class="hero-image">
                <img src="images/1.png" alt="Prolink WiFi Hotspot">
            </div>
        </div>
        <div class="hero-slide">
            <div class="hero-text">
                <h2>New Deals Every Day!</h2>
                <p>Check out our flash sales for exclusive discounts.</p>
            </div>
            <div class="hero-image">
                <img src="images/2.png" alt="Flash Deals">
            </div>
        </div>
        <div class="hero-slide">
            <div class="hero-text">
                <h2>Top Tech Brands</h2>
                <p>Find products from HP, Dell, Asus, and more.</p>
            </div>
            <div class="hero-image">
                <img src="images/3.png" alt="Top Brands">
            </div>
        </div>
    </div>
</div></center>


    <!-- Brands Section -->
    <div class="brands-section">
        <h2 id="brands">Our Brands</h2>
        <div class="brand-logos">
            <a href="hp.aspx">
            <img src="images/hp-logo.png" alt="HP" target="blank">
                </a>
            <a href="#">
            <img src="images/dell-logo.png" alt="Dell"></a>
            <a href="#">
            <img src="images/asus-logo.png" alt="Asus"></a>
            <a href="#">
            <img src="images/apple-logo.png" alt="Apple"></a>
            <a href="#">
            <img src="images/lenovo-logo.png" alt="Lenovo"></a>
            
        </div>
    </div>


   
 </div>

    </form>

   

    <script>

        // JavaScript for Auto-Playing Slideshow
        document.addEventListener('DOMContentLoaded', () => {
            let currentSlide = 0;
            const slides = document.querySelectorAll('.hero-slide');
            const totalSlides = slides.length;

            // Function to switch slides
            const showSlide = (index) => {
                // Hide all slides
                slides.forEach(slide => slide.classList.remove('active'));

                // Show the selected slide
                slides[index].classList.add('active');
            };

            // Auto-play slides every 5 seconds
            const startSlideShow = () => {
                setInterval(() => {
                    currentSlide = (currentSlide + 1) % totalSlides;
                    showSlide(currentSlide);
                }, 5000); // 5000ms = 5 seconds
            };

            // Start slideshow on page load
            startSlideShow();
        });

    
    </script>
    <footer class="footer">
   <section class="grid">
 
       <div class="box">
          <img src="images/email.png" alt="">
          <h3>our email</h3>
          <a href="mailto:techfix@gmail.com">techfix@gmail.com</a>
          
       </div>
 
       <div class="box">
          <img src="images/clock.png" alt="">
          <h3>opening hours</h3>
          <p>00:07am to 00:10pm </p>
       </div>
 
       <div class="box">
          <img src="images/map.png" alt="">
          <h3>our address</h3>
          <a href="https://www.google.com/maps">Colombo 10 , Sri Lanka</a>
       </div>
 
       <div class="box">
          <img src="images/telephone.png" alt="">
          <h3>our number</h3>
          <a href="tel:94779426462">+94-779-426-462</a>
          
       </div>
 
    </section>
 
    <div class="credit">&copy; copyright @ 2024 by <span>Induwara Jayanga</span> | all rights reserved!</div>
 
 </footer>


<!--<div class="loader">
   <img src="images/loader.gif" alt="">
</div>-->
</body>
</html>

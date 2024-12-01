<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierDashboard.aspx.cs" Inherits="TechFix.SupplierDashboard" %>



<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Supplier Dashboard</title>
    <link rel="stylesheet" href="styles.css">

    <style>
        * {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: Arial, sans-serif;
}

body {
       background-image:url(images/adminbackground.jpg);
background-repeat:no-repeat;  
}
h1{
    color:white;
}

.nav-bar {
    display: flex;
    justify-content: space-between;
    align-items: center;
    background-color: #fff;
    padding: 10px 30px;
    border-bottom: 1px solid #ccc;
}

.logo {
    font-size: 1.5rem;
    font-weight: bold;
}

.logo span {
    color: #ff0000;
}

nav ul {
    display: flex;
    list-style: none;
}

nav ul li {
    margin: 0 15px;
}

nav ul li a {
    text-decoration: none;
    color: #333;
    font-size: 1rem;
}

.user-icon {
    font-size: 1.5rem;
}

.dashboard {
    max-width: 1200px;
    margin: 50px auto;
    text-align: center;
}

.dashboard h1 {
    font-size: 2rem;
    margin-bottom: 20px;
}

.card-container {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 20px;
    padding: 20px;
}

.card {
    background-color: #fff;
    border-radius: 8px;
    padding: 20px;
    box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
    text-align: center;
}

.card h2 {
    font-size: 1.5rem;
    margin-bottom: 10px;
}

.card p {
    font-size: 1rem;
    color: #777;
    margin-bottom: 15px;
}

.card button {
    background-color: #ff0000;
    color: white;
    border: none;
    padding: 10px 20px;
    border-radius: 5px;
    cursor: pointer;
}
.card button a{
     color: white;
}
.card button:hover {
    background-color:#0780fa;
}

    </style>
</head>
<body>
    <header>
          <div class="nav-bar">
        <div class="logo">Supplier<span>Panel<b>(Techfix)</b></span></div>
        <nav>
            <ul>
               <li><a href="SupplierDashboard.aspx">home</a></li>
              
                <li><a href="Home Page.aspx">Website</a></li>
               
                
                
            </ul>
        </nav>
       
      
    </div>
    
   </header>

    <main>
        <section class="dashboard">
            <h1>DASHBOARD</h1>
            <div class="card-container">
                <div class="card">
               
                    <h2>Supplier-01 Inventory</h2>
                    <button><a href="SupplierLogin.aspx" >Inventory</a></button>
                </div>
                <div class="card">
                    
                    <h2>Supplier-02 Inventory</h2>
                     <button><a href="SupplierLogin.aspx" >Inventory</a></button>
                </div>
                <div class="card">
                    
                    <h2>Customer Quates</h2>
                    <button><a href="AdminQuotations.aspx" >Quotations</a></button>
                </div>
         
                
            </div>
        </section>
    </main>
</body>
</html>
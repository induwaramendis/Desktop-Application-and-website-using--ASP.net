﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="TechFix.AdminDashboard" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Admin Panel Dashboard</title>
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

.nav-bar {
    display: flex;
    justify-content: space-between;
   
    background-color: #fff;
    padding: 10px 30px;
    border-bottom: 1px solid #ccc;
}

.logo {
    font-size: 1.5rem;
    font-weight: bold;
}

.logo span {
    color: #FF0000;
}

nav ul {
     float: right;
    display: flex;
    list-style: none;
    font-size:18px;
  

}

nav ul li {
    float: right;
    padding-left:50px;
    margin-left:20px;
    justify-content:space-between;
}

nav ul li a {
   
    color: #333;
    font-family:'Times New Roman';
    font-size: 1.5rem;
}
nav ul li a:hover{
    background-color:palevioletred;
    width:200px;
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
    color:white;
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
    color:white;
    margin-bottom: 15px;
}

.card button {
    background-color: #FF0000;
    color:white;
    border: none;
    padding: 10px 20px;
    border-radius: 5px;
    cursor: pointer;
    font-size:15px;
   
    
}
.card button a{
     color: white;
}
.card button:hover {
    background-color:#0780fa;
}

.card-container.form-group{
    background-color:deepskyblue
}

    </style>
</head>
<body>
    <header>
        <div class="nav-bar">
            <div class="logo">Admin<span>Panel<b>(Techfix)</b></span></div>
            <nav>
                <ul>
                   <li><a href="#">home</a></li>
                  
                    <li><a href="Home Page.aspx">Website</a></li>
                   
                    <li style="float:right"><a href="AdminS1Inventory.aspx">Supplier 01 Inventory</a></li>
                    <li style="float:right"><a href="AdminS2Inventory.aspx">Supplier 02 Inventory</a></li>
                    
                </ul>
            </nav>
           
          
        </div>
         <form runat="server">
     <asp:Button ID="LogoutButton" runat="server" Text="Logout" BackColor="Red" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="44px" Width="114px" OnClick="LogoutButton_Click"  />
    </form>
    </header>

    <main>
        <section class="dashboard">
            <h1>DASHBOARD</h1>
            <div class="card-container">
                <div class="card">
                   
                    <h2>Repairs Request</h2>
       <button><a href="AdminRepairs.aspx">View Repair Requests</a></button>
                </div>
                <div class="card">
                    <h2>Customer Orders</h2>
                    <button><a href="AdminOrders.aspx">View Orders</a></button>
                </div>
                 <div class="card">
     
                     <h2>Messages</h2>
                     <button><a href="AdminMessages.aspx">See Messages</a></button>
                    </div>
                <div class="card">
                    
                    <h2>Products</h2>
                    <button><a href ="AdminProducts.aspx"> Products</a></button>
                </div>
               
                 <div class="card">
     
                    <h2>Customer Quotations</h2>
                     <button><a href ="AdminQuotations.aspx"> Products</a></button>
                  </div>

                 <div class="card">
     
                 <h2>Added Inventories</h2>
                      <button><a href ="AdminaddedInventories.aspx"> Products</a></button>
                 </div>
                

               
            </div>
        </section>
    </main>
</body>
</html>
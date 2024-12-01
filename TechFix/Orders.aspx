<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="TechFix.Orders" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>TechFix</title>
   
    <style>
        /* General Styles */
* {margin: 0;
    padding: 0;
    box-sizing: border-box;}
body {font-family: Arial, sans-serif;
        background-image:url(images/adminbackground.jpg);
background-repeat:no-repeat;  
    color: #333;}
/* Container */
.container {width: 90%;
    max-width: 600px;
    margin: 50px auto;
    background-color: white;
    padding: 30px;
    border-radius: 10px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);}
h1 {text-align: center;
    margin-bottom: 30px;
    color: #ff0000;}
/* Input fields */
.input-text {width: 100%;
    padding: 10px;
    margin-bottom: 20px;
    border: 1px solid #ccc;
    border-radius: 5px;
    font-size: 16px;}
/* Submit Button */
.btn-submit {width: 100%;
    padding: 12px;
    background-color: #ff0000;
    color: white;
    font-size: 16px;
    font-weight: bold;
    border: none;
    border-radius: 5px;
    cursor: pointer;
    transition: background-color 0.3s ease;}
.btn-submit:hover {background-color: #f5b041;}
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
    <h1>TechFix - Orders</h1>
</div>
<nav class="navbar">
    <ul>
        <li><a href="CustomerHomePage.aspx">Home</a></li>
        
       
        
    </ul>
</nav>

      </header>
     <form id="form1" runat="server">
        <div class="container">
            <h1>Place Order</h1>
            <label for="txtOrderName">Item:</label>
            <asp:TextBox ID="txtOrderID" runat="server" CssClass="input-text"></asp:TextBox><br /><br />

          <label for="txtOrderDate">Customer Name:</label>
<asp:TextBox ID="txtcustmer" runat="server" CssClass="input-text"></asp:TextBox><br /><br />

            <label for="txtOrderDate">Order Date:</label>
            <asp:TextBox ID="txtOrderDate" runat="server" CssClass="input-text"></asp:TextBox><br /><br />

            <label for="txtTotalAmount">Extra Note:</label>
            <asp:TextBox ID="txtnote" runat="server" CssClass="input-text"></asp:TextBox><br /><br />

            <label for="txtContact Number">Contact Number:</label>
            <asp:TextBox ID="txtnumber" runat="server" CssClass="input-text"></asp:TextBox><br /><br />

            <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order" CssClass="btn-submit" OnClick="btnPlaceOrder_Click" />
        </div>
    </form>
</body>
</html>

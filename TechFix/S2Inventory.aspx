<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="S2Inventory.aspx.cs" Inherits="TechFix.S2Inventory" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Inventory Management</title>
    <style>
        /* Add your CSS styling here */
        body {
            font-family: Arial, sans-serif;
           background-image:url(images/adminbackground.jpg);
            background-repeat:no-repeat;  
            margin: 0;
            padding: 0;
        }
        .container {
            width: 50%;
            margin: auto;
            background-color: #fff;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
        }
        .form-group input {
            width: 100%;
            padding: 10px;
            box-sizing: border-box;
        }
        .form-group2 button {
            padding: 10px 20px;
            background-color: #007bff;
            color: #fff;
            border: none;
            cursor: pointer;
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
        color: #003366;
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
    </style>
</head>
<body>

     <header>
    <div class="nav-bar">
      <div class="logo">Supplier-02<span>Panel<b>(Techfix)</b></span></div>
      <nav>
          
      </nav>
     
    
  </div>
   
   
    </header><br />

    
    <div class="container">
        <center><h1>Inventory Management</h1></center>
        <center><h2>Supplier-02</h2></center>

        <form id="inventoryForm" runat="server">
            <div class="form-group">
                <label for="itemId">Item ID</label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;</div>
            <div class="form-group">
                <label for="supplierId">Supplier ID</label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;</div>
            <div class="form-group">
                <label for="itemName">Item Name</label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;</div>
            <div class="form-group">
                <label for="quantity">Quantity</label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;</div>
            <div class="form-group">
                <label for="unitPrice">Unit Price</label>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;</div>
            
    <div class="form-group">
        <label for="itemImage">Item Image</label>
        <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;</div>
            <div class="form-group2">
               <center>
                <asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="btninsert_Click" BackColor="Red" BorderColor="White" Font-Size="Medium" ForeColor="White"    /><br /><br />
                <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" BackColor="Red" BorderColor="White" Font-Size="Medium" ForeColor="White"   /><br /><br />
                 <asp:Button ID="btndelete" runat="server" Text="Delete" BackColor="Red" BorderColor="White" Font-Size="Medium" ForeColor="White"   /><br /><br />
                 <asp:Button ID="btnback" runat="server" Text="Back" OnClick="btnback_Click" BackColor="Red" BorderColor="White" Font-Size="Medium" ForeColor="White"     /><br /><br />
                </center> 
            </div>
        </form>
    </div>
</body>
</html>


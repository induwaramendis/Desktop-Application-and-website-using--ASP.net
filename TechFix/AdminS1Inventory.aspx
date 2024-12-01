<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminS1Inventory.aspx.cs" Inherits="TechFix.AdminS1Inventory" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier 01 Inventory</title>
        <style>
  body {
            font-family: Arial, sans-serif;
            background-image:url(images/adminbackground.jpg);
 background-repeat:no-repeat;  
            margin: 0;
            padding: 0;
        }

        .container {
            width: 80%;
            margin: 20px auto;
            background: #fff;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h1 {
            text-align: center;
            color: #333;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin: 20px 0;
        }

        table, th, td {
            border: 1px solid #ddd;
        }

        th, td {
            padding: 12px;
            text-align:center;
           
        }

        th {
            background-color: #ff0000;
            color:white;
        }

        tr:nth-child(even) {
            background-color: #f9f9f9;
        }

        tr:hover {
            background-color: #f1f1f1;
        }

        img {
            max-width: 100px;
            height: auto;
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
    color: #fff;
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
    color:#f2f2f2;
}

.card button:hover {
    background-color: #0056b3;
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

            .auto-style1 {
                width: 144px;
            }

    </style>
</head>

 
<body>


    <body>
    <div class="container">
       <center> <h2>Supplier - 01</h2></center>
        
        <br />
        <table>
            <thead>
                <tr>
                    <th>ItemID</th>
                    <th>SupplierID</th>
                    <th class="auto-style1">ItemName</th>
                    <th>Quantitiy</th>
                    <th>UnitPrice</th>
                    <th>Image</th>
                    
                    
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="ProductsRequestRepeater" runat="server">
                    <ItemTemplate>
                        <tr>

                            <td><%# Eval("ItemID") %></td>
                            <td><%# Eval("SupplierID") %></td>
                            <td><%# Eval("ItemName") %></td>
                            <td><%# Eval("Quantity") %></td>
                            <td><%# Eval("UnitPrice") %></td>
                            <td>
    <img src='<%# ResolveUrl("~/s1inventory/" + Eval("Image")) %>' alt='Product Image' width='100'/>
</td>

                           
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>

        
</body>
  
</body>
</html>
